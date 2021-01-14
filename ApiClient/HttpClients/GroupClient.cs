using ApiClient.Abstractions;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClient.HttpClients
{
    public class GroupClient : MyHttpClient, IGroupClient
    {
        public async Task<IEnumerable<Group>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Group> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
