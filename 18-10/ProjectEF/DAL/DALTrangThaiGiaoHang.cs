using DTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class API_TrangThaiGiaoHang
    {
        public List<DTOTrangThaiGiaoHang> GetListDataFrom()
        {
            Uri Url = new Uri("http://data.gonsa.com.vn/api/order/getTrangThaiGiaoHang");
            var restClient = new RestClient(Url);
            RestRequest restRequest = new RestRequest("", Method.Get);
            var restResponse = restClient.Execute<List<DTOTrangThaiGiaoHang>>(restRequest);

            if (restResponse.IsSuccessful)
            {
                var data = restResponse.Data;
                //dgvTrangThaiDonHang.DataSource = data;
                return data;
            }
            else
            {
                Console.WriteLine(restResponse.ErrorMessage);
                return null;
            }
        }
    }
}
