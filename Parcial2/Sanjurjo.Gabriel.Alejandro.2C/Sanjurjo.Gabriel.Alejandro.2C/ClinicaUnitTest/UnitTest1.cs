using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicaLogic.Entidades;
using ClinicaLogic.Comun;
using ClinicaLogic.Interfaces;

namespace ClinicaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SerializacionXml()
        {
            TurnoSerializador turnoOrigen = new TurnoSerializador(10, 15, DateTime.Now, "Las observaciones.");
            TurnoSerializador turnoDestino = new TurnoSerializador();
            XmlBinario.SerializarTurnoXml(Environment.CurrentDirectory+"\\pruebaxml.xml", turnoOrigen);
            turnoDestino = XmlBinario.DeserializarTurnoXml(Environment.CurrentDirectory + "\\pruebaxml.xml");
            Assert.AreEqual(turnoOrigen.Paciente, turnoDestino.Paciente);
            Assert.AreEqual(turnoOrigen.Especialista, turnoDestino.Especialista);
            Assert.AreEqual(turnoOrigen.FechaTurno, turnoDestino.FechaTurno);
            Assert.AreEqual(turnoOrigen.ObservacionesTurno, turnoDestino.ObservacionesTurno);


        }

        [TestMethod]
        public void SerializacionBinaria()
        {
            TurnoSerializador turnoOrigen = new TurnoSerializador(10, 15, DateTime.Now, "Las observaciones.");
            TurnoSerializador turnoDestino = new TurnoSerializador();
            XmlBinario.SerializarTurnoBinario(Environment.CurrentDirectory + "\\pruebabin.bin", turnoOrigen);
            turnoDestino = XmlBinario.DeserializarTurnoBinario(Environment.CurrentDirectory + "\\pruebabin.bin");
            Assert.AreEqual(turnoOrigen.Paciente, turnoDestino.Paciente);
            Assert.AreEqual(turnoOrigen.Especialista, turnoDestino.Especialista);
            Assert.AreEqual(turnoOrigen.FechaTurno, turnoDestino.FechaTurno);
            Assert.AreEqual(turnoOrigen.ObservacionesTurno, turnoDestino.ObservacionesTurno);


        }

        [TestMethod]
        [ExpectedException(typeof(ClinicaLogic.Comun.ClinicaNoCoincideException))]
        public void AltaTurnoException()
        {
            Clinica c = new Clinica();
            //paciente desde sql
            IPaciente p = new PacienteDB(1, "Huch", "Guille", 42, "Masculino", "Tacuari", ClinicaLogic.Comun.Enumerado.ObraSocial.CoberturaBasica);
            //paciente desde archivo
            IEspecialista e = new Especialista(1, "Just", "Pedro", 42, "Masculino", "Chile", ClinicaLogic.Comun.Enumerado.Especialidad.Obtetricia);

            c.AgregarTurno(p, e);

        }
    }
}
