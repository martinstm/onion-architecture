using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Example.CommandPattern
{
    public abstract class CommandHandler<TCommand> : ICommandHandler<TCommand>
    {
        public abstract void Handle(TCommand command);

        public void HandleRetry(TCommand command, int retries)
        {
            Console.WriteLine("Handle Retry implementation");

            try
            {
                Handle(command);
            }
            catch (Exception)
            {
                if (retries <= 0)
                    throw;

                Thread.Sleep(300);

                HandleRetry(command, retries--);
            }
        }
    }
}
