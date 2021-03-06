﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace UnitTestCompetencia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaDeVehiculosInstanciada()
        {

            Competencia<AutoF1> c = new Competencia<AutoF1>(4, 8, Competencia<AutoF1>.TipoCompetencia.F1);
            //Assert
            Assert.IsNotNull(c.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void ExcepcionCompetenciaMotocrossAgregaAuto()
        {

            Competencia<MotoCross> c = new Competencia<MotoCross>(4, 8, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            AutoF1 a = new AutoF1(1, "Malboro");
            //Act
            bool agrega = c + a;

        }
        [TestMethod]
        public void CompetenciaMotocrossAgregaMoto()
        {
            //Arrange
            Competencia<MotoCross> c = new Competencia<MotoCross>(4, 8, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(1, "Malboro");
            //Act
            bool agrega;
            bool lanzada = false;
            try
            {
                agrega = c + m;

            }
            catch (Exception)
            {
                lanzada = true;
            }
            //Assert
            Assert.IsFalse(lanzada);
        }
        [TestMethod]
        public void SeAgregaVehiculo()
        {
            //Arrange
            Competencia<MotoCross> c = new Competencia<MotoCross>(4, 8, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(1, "Malboro");
            //Act
            bool agrega;
            agrega = c + m;
            bool esta = c == m;
            //Assert
            Assert.IsTrue(agrega);
            Assert.IsTrue(esta);
        }
        [TestMethod]
        public void SeQuitaVehiculo()
        {
            //Arrange
            Competencia<MotoCross> c = new Competencia<MotoCross>(4, 8, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(1, "Malboro");
            //Act
            bool agrega;
            agrega = c + m;
            agrega = c - m;
            bool noEsta = c != m;
            //Assert
            Assert.IsTrue(noEsta);
        }
    }
}
