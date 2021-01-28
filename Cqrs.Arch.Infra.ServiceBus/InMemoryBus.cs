using Cqrs.Arch.Domain.Core.Bus;
using Cqrs.Arch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs.Arch.Infra.ServiceBus
{
    public sealed class InMemoryBus:IMediatorHandler
    {
        private readonly IMediator _mediator;
        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
