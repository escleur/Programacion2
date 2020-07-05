using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        string contenido;


        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            Stream fs = null;
            BinaryFormatter ser;
            try
            {
                ValidarArchivo(ruta, true);
                fs = new FileStream(ruta, FileMode.Create);
                ser = new BinaryFormatter();
                ser.Serialize(fs, objeto);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (!(fs is null))
                    fs.Close();

            }

            return true;
        }
        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            Stream fs = null;
            BinaryFormatter ser;
            try
            {
                ValidarArchivo(ruta, false);
                fs = new FileStream(ruta, FileMode.Create);
                ser = new BinaryFormatter();
                ser.Serialize(fs, objeto);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(!(fs is null))
                    fs.Close();

            }

            return true;
        }
        public PuntoDat Leer(string ruta)
        {
            PuntoDat pdat = new PuntoDat();
            Stream fs = null;
            BinaryFormatter ser;
            try
            {
                fs = new FileStream(ruta, FileMode.Open);
                ser = new BinaryFormatter();
                pdat = (PuntoDat)ser.Deserialize(fs);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (!(fs is null))
                    fs.Close();

            }

            return pdat;
        }
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool extencionDat = false;
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".dat")
                    {
                        extencionDat = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un dat.");
                    }
                }
            }catch (FileNotFoundException fnf)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", fnf);
            }
            return extencionDat;
        }
    }
}
