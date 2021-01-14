using Example.CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.CommandPattern.CommandHandlers
{
    public class OrderCommandHandler : CommandHandler<OrderCommand>
    {
        public override void Handle(OrderCommand command)
        {
            Console.WriteLine("Handle implementation");
        }
    }
}
