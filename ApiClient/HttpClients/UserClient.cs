using ApiClient.Abstractions;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClient.HttpClients
{
    public class UserClient : MyHttpClient, IUserClient
    {
        public async Task<IEnumerable<User>> GetAll()
        {
            string result = await GetRequest("users/all");
            return JsonConvert.DeserializeObject<IEnumerable<User>>(result);
        }

        public async Task<User> GetById(int id)
        {
            string result = await GetRequest($"users/{id}");
            return JsonConvert.DeserializeObject<User>(result);
        }
    }
}
