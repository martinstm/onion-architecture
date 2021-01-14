using ApiClient.Abstractions;
using System;
using System.Net.Http;

namespace ApiClient
{
    public class MyApiClient : IApiClient
    {
        public MyApiClient(IUserClient userClient, IGroupClient groupClient)
        {
            UserClient = userClient;
            GroupClient = groupClient;
        }

        public IUserClient UserClient { get; }
        public IGroupClient GroupClient { get; }
    }
}
