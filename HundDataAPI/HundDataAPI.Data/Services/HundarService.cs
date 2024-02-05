using HundDataAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HundDataAPI.Data.Services
{
    public interface IHundarService
    {
        Task<HundarResponseModel> GetByRegNrAsync(int regNr);
    }

    public class HundarService : IHundarService
    {
        private readonly HttpClient _httpClient;

        public HundarService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HundarResponseModel> GetByRegNrAsync(int regNr)
        {
            var requestModel = new HundarRequestModel { SKKRegNr = regNr.ToString()  };
            var responseModel = await _httpClient.PostAsJsonAsync("HundData", requestModel);
            if (responseModel.IsSuccessStatusCode)
            {
                return await responseModel.Content.ReadFromJsonAsync<HundarResponseModel>();
            }
            else
            {
                return new HundarResponseModel();
            }
        }
    }
}
