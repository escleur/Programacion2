using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CentralitaHerencia;

namespace UnitTestCentralita
{
    [TestClass]
    public class UnitTestCentralita
    {
        [TestMethod]
        public void TestCentralitaInstanciada()
        {
            //Arrange
            Centralita c1 = new Centralita("Central");

            //Assert
            Assert.IsInstanceOfType(c1.Llamadas, typeof(List<Llamada>));
            Assert.IsNotNull(c1.Llamadas);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestCentralitaExceptionLocal()
        {
            //Arrange
            Centralita c1 = new Centralita("Central");
            Llamada l1 = new Local("333", 10, "555", 2.3f);
            Llamada l2 = new Local("333", 9, "555", 2.5f);
            //Act
            c1 += l1;
            c1 += l2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestCentralitaExceptionProvincial()
        {
            //Arrange
            Centralita c1 = new Centralita("Central");
            Llamada l1 = new Provincial("333", Provincial.Franja.Franja_2, 10, "555");
            Llamada l2 = new Provincial("333", Provincial.Franja.Franja_2, 15, "555");
            //Act
            c1 += l1;
            c1 += l2;
        }
        [TestMethod]
        public void TestCentralitaIgualdadDeLlamadas()
        {
            //Arrange
            Llamada l1 = new Local("333", 10, "555", 2.3f);
            Llamada l2 = new Local("333", 9, "555", 2.5f);
            Llamada p1 = new Provincial("333", Provincial.Franja.Franja_2, 10, "555");
            Llamada p2 = new Provincial("333", Provincial.Franja.Franja_2, 15, "555");
            //Assert
            Assert.IsTrue(l1 == l2);
            Assert.IsTrue(p1 == p2);

            Assert.IsFalse(l1 == p1);
            Assert.IsFalse(l1 == p2);
            Assert.IsFalse(l2 == p1);
            Assert.IsFalse(l2 == p2);

        }

    }
}
