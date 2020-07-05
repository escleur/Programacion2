using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClinicaLogic.Interfaces;
using ClinicaLogic.Entidades;
using ClinicaLogic.Comun;

namespace ClinicaLogic.Comun
{
    public static class DataBase
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader reader;

        /// <summary>
        /// Constructor, instancia la conexion a la base de datos
        /// </summary>
        static DataBase()
        {
            conexion = new SqlConnection("Data source = .\\SQLEXPRESS; Database = ClinicaUtn; Trusted_Connection = True");
            comando = new SqlCommand();

        }

        /// <summary>
        /// Lee la lista de pacientes desde la db, lo pone en objetos PacienteDB
        /// </summary>
        /// <param name="lista"></param>
        public static void LeerPacientes(ref List<IPaciente> lista)
        {
            try
            {

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Pacientes";

                conexion.Open();

                reader = comando.ExecuteReader();

                int id;
                string apellido;
                string nombre;
                int edad;
                string sexo;
                string direccion;
                Comun.Enumerado.ObraSocial obraSocial = Enumerado.ObraSocial.NoTiene;

                while (reader.Read())
                {
                    id = (int)reader["idPaciente"];
                    apellido = reader["apellido"].ToString();
                    nombre = reader["nombre"].ToString();
                    edad = (int)reader["edad"];
                    sexo = reader["sexo"].ToString();
                    direccion = reader["direccion"].ToString();
                    string sos = reader["obraSocial"].ToString();
                    obraSocial = seleccionarObraSocial(sos);

                    PacienteDB paciente = new PacienteDB(id, apellido, nombre, edad, sexo, direccion, obraSocial);
                    lista.Add(paciente);
                }
            }
            catch (Exception e)
            {
                ErrorLog.Log("Error al leer pacientes desde la base de datos. " + e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Lee una lista de especialistas desde la db, lo pone en objetos EspecialistaDB 
        /// </summary>
        /// <param name="lista"></param>
        public static void LeerEspecialistas(ref List<IEspecialista> lista)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Especialistas";

                conexion.Open();

                reader = comando.ExecuteReader();

                int id;
                string apellido;
                string nombre;
                int edad;
                string sexo;
                string direccion;
                Enumerado.Especialidad especialidad = Enumerado.Especialidad.ClinicaGeneral;


                while (reader.Read())
                {
                    id = (int)reader["idEspecialista"];
                    apellido = reader["apellido"].ToString();
                    nombre = reader["nombre"].ToString();
                    edad = (int)reader["edad"];
                    sexo = reader["sexo"].ToString();
                    direccion = reader["direccion"].ToString();
                    string se = reader["especialidad"].ToString();

                    especialidad = seleccionarEspecialidad(se);

                    EspecialistaDB especialista = new EspecialistaDB(id, apellido, nombre, edad, sexo, direccion, especialidad);
                    lista.Add(especialista);
                }
            }
            catch (Exception e)
            {
                ErrorLog.Log("Error al leer especialistas desde la base de datos. " + e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Convierte la cadena de texto en el enumerado ObraSocial
        /// </summary>
        /// <param name="os"></param>
        /// <returns></returns>
        public static Enumerado.ObraSocial seleccionarObraSocial(string os)
        {
            Enumerado.ObraSocial obraSocial = Enumerado.ObraSocial.NoTiene;
            switch (os)
            {
                case "CoberturaBasica":
                    obraSocial = Enumerado.ObraSocial.CoberturaBasica;
                    break;
                case "CoberturaCompleta":
                    obraSocial = Enumerado.ObraSocial.CoberturaCompleta;
                    break;
                case "NoTiene":
                    obraSocial = Enumerado.ObraSocial.NoTiene;
                    break;
                default:
                    ErrorLog.Log("No coincide el campo obra social");
                    break;
            }
            return obraSocial;
        }

        /// <summary>
        /// Convierte la cadena de texto en el enumerado Especialidad
        /// </summary>
        /// <param name="esp"></param>
        /// <returns></returns>
        public static Enumerado.Especialidad seleccionarEspecialidad(string esp)
        {
            Enumerado.Especialidad especialidad = Enumerado.Especialidad.ClinicaGeneral;
            switch (esp)
            {
                case "Oftalmologia":
                    especialidad = Enumerado.Especialidad.Oftalmologia;
                    break;
                case "Odontologia":
                    especialidad = Enumerado.Especialidad.Odontologia;
                    break;
                case "Otorrinolaringologia":
                    especialidad = Enumerado.Especialidad.Otorrinolaringologia;
                    break;
                case "Ginecologia":
                    especialidad = Enumerado.Especialidad.Ginecologia;
                    break;
                case "Dermatologia":
                    especialidad = Enumerado.Especialidad.Dermatologia;
                    break;
                case "Obtetricia":
                    especialidad = Enumerado.Especialidad.Obtetricia;
                    break;
                case "Pediatria":
                    especialidad = Enumerado.Especialidad.Pediatria;
                    break;
                case "Psicologia":
                    especialidad = Enumerado.Especialidad.Psicologia;
                    break;
                case "ClinicaGeneral":
                    especialidad = Enumerado.Especialidad.ClinicaGeneral;
                    break;

                default:
                    ErrorLog.Log("No coincide el campo especialidad");
                    break;
            }
            return especialidad;

        }

        /// <summary>
        /// Guarda el turno en la base de datos
        /// </summary>
        /// <param name="turno"></param>
        public static void GuardarTurno(Turno<IPaciente, IEspecialista> turno)
        {
            try
            {

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO Turnos (idPaciente, idEspecialista, observacionesTurno, fechaTurno)" +
                    " VALUES (@idPaciente, @idEspecialista, @observacionesTurno, @fechaTurno) ";

                comando.Parameters.Add(new SqlParameter("idPaciente", (int)turno.Paciente.Id));
                comando.Parameters.Add(new SqlParameter("idEspecialista", (int)turno.Especialista.Id));
                comando.Parameters.Add(new SqlParameter("observacionesTurno", turno.ObservacionesTurno));
                comando.Parameters.Add(new SqlParameter("fechaTurno", turno.FechaTurno.ToString("dd/MM/yyyy HH:mm:ss")));
                conexion.Open();

                int n = comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                ErrorLog.Log("Error al dar de alta turno en la base de datos. " + e.Message);
            }
            finally
            {
                conexion.Close();
            }


        }

    }
}
