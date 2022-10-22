using System;
using System.Diagnostics.CodeAnalysis;
using Sharedkernel.Core;

namespace Sharedkernel.IntegrationEvents {
    [ExcludeFromCodeCoverage]
    public record VueloReprogramado : IntegrationEvent {

        public string fecha { get; set; }
        public Guid vueloId { get; set; }
        public DateTime horaSalida { get; set; }
        public DateTime horaLlegada { get; set; }
        public Guid codAeronave { get; set; }

    }
}

