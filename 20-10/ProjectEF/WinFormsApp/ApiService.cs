using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;
using System.Net.Http.Json;

namespace GUI
{
    public class ApiService
    {
        private readonly string apiBaseUrl = "https://localhost:7126/api/NhanVien/";
        private readonly HttpClient httpClient;

        public ApiService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(apiBaseUrl);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<NhanVien>> GetNhanViensAsync()
        {
            var response = await httpClient.GetAsync("NhanVienCS");
            if (response.IsSuccessStatusCode)
            {
                var nhanViens = await response.Content.ReadFromJsonAsync<IEnumerable<NhanVien>>();
                return nhanViens;
            }
            return null;
        }

        public async Task<bool> CreateNhanVienAsync(NhanVien nhanVien)
        {
            var json = JsonConvert.SerializeObject(nhanVien);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("NhanVien", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateNhanVienAsync(string maNhanVien, NhanVien nhanVien)
        {
            var json = JsonConvert.SerializeObject(nhanVien);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync($"NhanVien/UpdateNhanVien/{maNhanVien}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteNhanVienAsync(string maNhanVien)
        {
            var response = await httpClient.DeleteAsync($"NhanVien/{maNhanVien}");
            return response.IsSuccessStatusCode;
        }
    }
}
