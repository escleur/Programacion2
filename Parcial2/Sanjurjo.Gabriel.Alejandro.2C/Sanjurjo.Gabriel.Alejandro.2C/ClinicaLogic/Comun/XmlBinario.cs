using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClinicaLogic.Interfaces;
using ClinicaLogic.Entidades;
using ClinicaLogic.Comun;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClinicaLogic.Comun
{
    public static class XmlBinario
    {

        static XmlBinario()
        {

        }

        /// <summary>
        /// Lee pacientes desde el archivo xml, lo pone en un objeto Paciente
        /// </summary>
        /// <param name="lista"></param>
        public static void LeerPacientes(ref List<IPaciente> lista)
        {
            XmlTextReader reader = null;
            XmlSerializer ser = null;
            List<Paciente> p;

            StringBuilder path = new StringBuilder();
            path.Append(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            path.Append("\\SegundoParcialUtn\\ArchivosClinica\\");

            if (!Directory.Exists(path.ToString()))
            {
                DirectoryInfo di = Directory.CreateDirectory(path.ToString());
                ErrorLog.Log("El archivo PacientesSegundaClinica.xml no existe.");
            }

            path.Append("PacientesSegundaClinica.xml");

            if (!File.Exists(path.ToString()))
            {
                ErrorLog.Log("El archivo PacientesSegundaClinica.xml no existe.");
            }

            try
            {
                reader = new XmlTextReader(path.ToString());
                ser = new XmlSerializer(typeof(List<Paciente>));
                p = (List<Paciente>)ser.Deserialize(reader);


                foreach (IPaciente item in p)
                {
                    lista.Add(item);

                }

            }catch(Exception e)
            {
                ErrorLog.Log("Error al leer pacientes desde el archivo xml. " + e.Message);
            }
            finally
            {
                reader.Close();
            }


        }

        /// <summary>
        /// Lee especialistas desde archivo xml, lo pone en Especialista
        /// </summary>
        /// <param name="lista"></param>
        public static void LeerEspecialistas(ref List<IEspecialista> lista)
        {
            XmlTextReader reader = null;
            XmlSerializer ser = null;
            List<Especialista> e;

            StringBuilder path = new StringBuilder();
            path.Append(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            path.Append("\\SegundoParcialUtn\\ArchivosClinica\\");

            if (!Directory.Exists(path.ToString()))
            {
                DirectoryInfo di = Directory.CreateDirectory(path.ToString());
                ErrorLog.Log("El archivo PacientesSegundaClinica.xml no existe.");
            }

            path.Append("DoctoresSegundaClinica.xml");

            if (!File.Exists(path.ToString()))
            {
                ErrorLog.Log("El archivo PacientesSegundaClinica.xml no existe.");
            }

            try
            {
                reader = new XmlTextReader(path.ToString());
                ser = new XmlSerializer(typeof(List<Especialista>));
                e = (List<Especialista>)ser.Deserialize(reader);


                foreach (IEspecialista item in e)
                {
                    lista.Add(item);

                }

            }
            catch (Exception ex)
            {
                ErrorLog.Log("Error al leer pacientes desde el archivo xml");
            }
            finally
            {
                reader.Close();
            }

        }


        /// <summary>
        /// Genera el path y el turno a serializar en xml y llama a la funcion correspondiente
        /// </summary>
        /// <param name="turno"></param>
        public static void GuardarTurno(Turno<IPaciente, IEspecialista> turno)
        {

            StringBuilder path = new StringBuilder();
            path.Append(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            path.Append("\\SegundoParcialUtn\\TurnosClinica\\");

            if (!Directory.Exists(path.ToString()))
            {
                DirectoryInfo di = Directory.CreateDirectory(path.ToString());
                ErrorLog.Log("La ruta MisDocumentos/SegundoParcialUtn/TurnosClinica/ no existe. Se ha creado.");
            }

            path.Append(DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss"));
            path.AppendFormat("-{0}-{1}", ((Paciente)turno.Paciente).Apellido, ((Paciente)turno.Paciente).Nombre);
            path.Append(".xml");

            TurnoSerializador t = new TurnoSerializador(turno.Paciente.Id, turno.Especialista.Id, turno.FechaTurno, turno.ObservacionesTurno);

            XmlBinario.SerializarTurnoXml(path.ToString(), t);

        }

        /// <summary>
        /// Serializa el turno en xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="t"></param>
        public static void SerializarTurnoXml(string archivo, TurnoSerializador t)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser = null;
            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(TurnoSerializador));
                ser.Serialize(writer, t);
            }
            catch (Exception e)
            {
                ErrorLog.Log("Error al grabar turno en xml. " + e.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        /// <summary>
        /// Deserializa el turno desde xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static TurnoSerializador DeserializarTurnoXml(string archivo)
        {
            TurnoSerializador t = new TurnoSerializador();
            XmlTextReader reader = null;
            XmlSerializer ser = null;
            try
            {
                reader = new XmlTextReader(archivo);
                ser = new XmlSerializer(typeof(TurnoSerializador));
                t = (TurnoSerializador)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                ErrorLog.Log("Error al grabar turno en xml. " + e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return t;

        }


        /// <summary>
        /// Serializa el turno en binario
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="t"></param>
        public static void SerializarTurnoBinario(string archivo, TurnoSerializador t)
        {
            Stream fs = null;
            BinaryFormatter ser = null;
            try
            {
                fs = new FileStream(archivo, FileMode.Create);
                ser = new BinaryFormatter();
                ser.Serialize(fs, t);
            }
            catch (Exception e)
            {
                ErrorLog.Log("Error al grabar turno en binario. " + e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// Deserializa el turno desde binario
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static TurnoSerializador DeserializarTurnoBinario(string archivo)
        {
            TurnoSerializador t = new TurnoSerializador();
            Stream fs = null;
            BinaryFormatter ser = null;
            try
            {
                fs = new FileStream(archivo, FileMode.Open);
                ser = new BinaryFormatter();
                t = (TurnoSerializador)ser.Deserialize(fs);
            }
            catch (Exception e)
            {
                ErrorLog.Log("Error al grabar turno en binario. " + e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return t;

        }


    }
}
