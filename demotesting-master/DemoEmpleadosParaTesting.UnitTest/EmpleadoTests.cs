using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace DemoEmpleadosParaTesting.UnitTest
{
    [TestFixture]
    public class EmpleadoTests
    {
        [Test]
        public void SubirSueldo_Scenario_ExpectedBehavior()
        {
            Empleado emp = new Empleado();

            emp.Sueldo = 1000;
            emp.SubirSueldo(15, "buena");

            emp.ObtenerFicha();

            Assert.That(emp.Sueldo == 1150);
        }
    }
}
