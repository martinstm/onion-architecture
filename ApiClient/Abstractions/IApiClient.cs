using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClient.Abstractions
{
    public interface IApiClient
    {
        IUserClient UserClient { get; }
        IGroupClient GroupClient { get; }
    }
}
