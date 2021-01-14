using System;
using System.Collections.Generic;
using System.Text;

namespace Example.CommandPattern
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
        void HandleRetry(TCommand command, int retries);
    }
}
