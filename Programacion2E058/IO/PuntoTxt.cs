using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string objeto)
        {
            StreamWriter writer = null;
            try
            {
                ValidarArchivo(ruta, true);
                writer = new StreamWriter(ruta);

                foreach (char item in objeto)
                {
                    writer.Write(item);
                }

            }
            catch (Exception ex)
            {
                throw;

            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();

                }
            }
            return true;

        }

        public bool GuardarComo(string ruta, string objeto)
        {
            StreamWriter writer = null;
            try
            {
                ValidarArchivo(ruta, false);
                writer = new StreamWriter(ruta);

                foreach (char item in objeto)
                {
                    writer.Write(item);
                }
               
            }
            catch (Exception ex)
            {
                throw;

            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();

                }
            }
            return true;

        }

        public string Leer(string ruta)
        {
            StreamReader reader = null;
            string retorno = string.Empty;
            try
            {
                reader = new StreamReader(ruta);
                retorno = reader.ReadToEnd();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (!(reader is null))
                    reader.Close();
            }
            return retorno;
        }
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool extencionTxt = false;
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        extencionTxt = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un txt.");
                    }
                }
            }
            catch (FileNotFoundException fnf)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", fnf);
            }
            return extencionTxt;
        }

    }
}
