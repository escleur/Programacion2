using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject45
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod1()
        {
            MiClase.MetodoEstatico();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestMethod2()
        {
            MiClase mc = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod3()
        {
            MiClase mc = new MiClase("hola");
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestMethod4()
        {
            OtraClase oc = new OtraClase();
            oc.metodo();
        }

    }
}
