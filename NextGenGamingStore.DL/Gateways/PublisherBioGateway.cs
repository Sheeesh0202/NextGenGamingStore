using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;
using System.Threading;
using NextGenGamingStore.DL.Interfaces;
using NextGenGamingStore.Models.Responses;
using NextGenGamingStore.Models.DTO;
using System.Numerics;
namespace NextGenGamingStore.DL.Gateways
{
    public class PublisherBioGateway : IPublisherBioGateway
    {

        private readonly RestClient _client;

        public PublisherBioGateway()
        {
            var options = new RestClientOptions("https://localhost:7077");

            _client = new RestClient(options);

        }

        public async Task<PublisherBioResponse?> GetBioByPublisher(Publisher publisher)
        {
            var request = new RestRequest($"/PublisherData", Method.Post);

            var json = JsonConvert.SerializeObject(publisher);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            request.AddBody(data);

            var response = await _client.ExecuteAsync<PublisherBioResponse>(request);

            //return response.Data;

            return response.Data;
        }

        public async Task<PublisherBioResponse?> GetBioByPublisherId(string publisherId)
        {
            var request = new RestRequest($"/PublisherData", Method.Get);

            request.AddQueryParameter("publisherId", publisherId);

            var response = await _client.ExecuteAsync<PublisherBioResponse>(request);

            return response.Data;
        }
    }
}
