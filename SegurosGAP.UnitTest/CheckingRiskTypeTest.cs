using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SegurosGAP.BusinessRules.GenericBusinessRules;
using SegurosGAP.Entities;

namespace SegurosGAP.UnitTest
{
    [TestClass]
    public class CheckingRiskTypeTest
    {
        [TestMethod]
        public void HighRiskType()
        {
            // arrange
            int coveragepercentageHigh = 60;    

            PolizasCliente poliza1 = new PolizasCliente
            {
                IdCliente = 2,
                IdPolizaSeguro = 6,
                PorcentajeCubrimiento = coveragepercentageHigh
            };         

            var polizasClienteRepository = new PolizasClienteRepository();

            bool respuesta = polizasClienteRepository.validarTipoRiesgoPoliza(poliza1);

            Assert.IsFalse(respuesta);
        }
        [TestMethod]
        public void LowRiskType()
        {
            // arrange
            int expected = 20;

            PolizasCliente poliza2 = new PolizasCliente
            {
                IdCliente = 3,
                IdPolizaSeguro = 5,
                PorcentajeCubrimiento = expected
            };

            var polizasClienteRepository = new PolizasClienteRepository();

            bool respuesta = polizasClienteRepository.validarTipoRiesgoPoliza(poliza2);

            Assert.IsTrue(respuesta);
        }
    }
}
