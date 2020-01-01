using System;
using System.Threading.Tasks;

namespace DasomNet.EventBus.Abstractions
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
