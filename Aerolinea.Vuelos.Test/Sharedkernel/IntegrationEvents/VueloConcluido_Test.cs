using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharedkernel.IntegrationEvents;
using Xunit;

namespace Aerolinea.Vuelos.Test.Sharedkernel.IntegrationEvents {
    public class VueloConcluido_Test {


        [Fact]
        public void IsRequest_Valid() {
            DateTime v_horaConcluido = DateTime.Now;
            DateTime v_horallegada = DateTime.Now;
            string fech_cpncluido = DateTime.Now.ToString();
            string v_estado = "A";
            int precio = 50;
            Guid codVuelo = Guid.NewGuid();
            string fech = DateTime.Now.ToString();


            VueloConcluido vueloConcluido = new VueloConcluido();
            vueloConcluido.horaLLegada = v_horallegada;
            vueloConcluido.estado = v_estado;
            vueloConcluido.precio = precio;
            vueloConcluido.fechaInicio = fech;
            vueloConcluido.vueloId = codVuelo;
            vueloConcluido.horaConcluido = v_horaConcluido;
            vueloConcluido.fechaConcluido = fech_cpncluido;

            Assert.Equal(vueloConcluido.fechaInicio, fech);
            Assert.Equal(vueloConcluido.vueloId, codVuelo);

        }
    }
}
