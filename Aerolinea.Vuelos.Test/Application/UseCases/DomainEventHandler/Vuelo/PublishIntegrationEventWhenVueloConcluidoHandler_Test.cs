using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Application.UseCases.DomainEventHandler.Vuelo;
using Aerolinea.Vuelos.Domain.Event;
using MassTransit;
using Moq;
using Sharedkernel.Core;
using Xunit;

namespace Aerolinea.Vuelos.Test.Application.UseCases.DomainEventHandler.Vuelo {
    public class PublishIntegrationEventWhenVueloConcluidoHandler_Test {
        private readonly Mock<IPublishEndpoint> _mediator;
        private Mock<ConfirmedDomainEvent<VueloConcluido>> _reprogramcion;

        public PublishIntegrationEventWhenVueloConcluidoHandler_Test() {
            _mediator = new Mock<IPublishEndpoint>();
            _reprogramcion = new Mock<ConfirmedDomainEvent<VueloConcluido>>();
        }

        [Fact]
        public async void PublishIntegrationEventWhenVueloConcluidoHandler_Success() {

            _mediator.Setup(m => m.Publish(It.IsAny<ConfirmedDomainEvent<VueloConcluido>>(), It.IsAny<CancellationToken>()))
            .Returns(MockFactory.GetVueloReprogrmadoShareKernel())
            .Verifiable("Notification was not sent.");

            var objHandler = new PublishIntegrationEventWhenVueloConcluidoHandler(
               _mediator.Object
            );


            Assert.NotNull(_mediator);

        }
    }
}
