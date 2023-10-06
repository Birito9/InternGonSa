using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using RestSharp;

namespace DAL
{
    public class API_TrangThaiGiaoHang
    {
        public List<OrderData_TrangThaiGiaoHang> GetListDataFrom()
        {
            Uri Url = new Uri("http://data.gonsa.com.vn/api/order/getTrangThaiGiaoHang");
            var restClient = new RestClient(Url);
            RestRequest restRequest = new RestRequest("", Method.Get);
            var restResponse = restClient.Execute<List<OrderData_TrangThaiGiaoHang>>(restRequest);

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
