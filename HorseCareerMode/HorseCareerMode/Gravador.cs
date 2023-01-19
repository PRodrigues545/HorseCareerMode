using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    public static class Gravador
    {
        public static void GravarEquipa(Equipa equipaAGravar)
        {

            string fileName = "Equipa.txt";

            //Verificar
            if (File.Exists(fileName))
            {
                Console.WriteLine("Deleting old file");
                File.Delete(fileName);

            }

            //Gravaçao
            FileStream fileStream = File.Create(fileName);
            BinaryFormatter f = new BinaryFormatter();

            f.Serialize(fileStream, equipaAGravar);

            fileStream.Close();

        }

        public static void GravarEstabulo(Estabulo estabuloAGravar)
        {

            string fileName = "Estabulo.txt";

            //Verificar
            if (File.Exists(fileName))
            {
                Console.WriteLine("Deleting old file");
                File.Delete(fileName);

            }

            //Gravaçao
            FileStream fileStream = File.Create(fileName);
            BinaryFormatter f = new BinaryFormatter();

            f.Serialize(fileStream, estabuloAGravar);

            fileStream.Close();

        }

        public static void GravarCentroDeEmprego(CentroDeEmprego centroAGravar)
        {

            string fileName = "Centro.txt";

            //Verificar
            if (File.Exists(fileName))
            {
                Console.WriteLine("Deleting old file");
                File.Delete(fileName);

            }

            //Gravaçao
            FileStream fileStream = File.Create(fileName);
            BinaryFormatter f = new BinaryFormatter();

            f.Serialize(fileStream, centroAGravar);

            fileStream.Close();

        }

        public static void GravarMercado(Mercado mercadoAGravar)
        {

            string fileName = "Mercado.txt";

            //Verificar
            if (File.Exists(fileName))
            {
                Console.WriteLine("Deleting old file");
                File.Delete(fileName);

            }

            //Gravaçao
            FileStream fileStream = File.Create(fileName);
            BinaryFormatter f = new BinaryFormatter();

            f.Serialize(fileStream, mercadoAGravar);

            fileStream.Close();

        }


        public static Equipa LerEquipa()
        {

            string fileName = "Equipa.txt";

            if (File.Exists(fileName))
            {
                FileStream fileStream = File.OpenRead(fileName);
                BinaryFormatter f = new BinaryFormatter();

                return f.Deserialize(fileStream) as Equipa;
            }
            else
            {
                Console.WriteLine("File not found");
                return null;
            }
        }

        public static Estabulo LerEstabulo()
        {

            string fileName = "Estabulo.txt";

            if (File.Exists(fileName))
            {
                FileStream fileStream = File.OpenRead(fileName);
                BinaryFormatter f = new BinaryFormatter();

                return f.Deserialize(fileStream) as Estabulo;
            }
            else
            {
                Console.WriteLine("File not found");
                return null;
            }
        }

        public static CentroDeEmprego LerCentro()
        {

            string fileName = "Centro.txt";

            if (File.Exists(fileName))
            {
                FileStream fileStream = File.OpenRead(fileName);
                BinaryFormatter f = new BinaryFormatter();

                return f.Deserialize(fileStream) as CentroDeEmprego;
            }
            else
            {
                Console.WriteLine("File not found");
                return null;
            }
        }

        public static Mercado LerMercado()
        {

            string fileName = "Mercado.txt";

            if (File.Exists(fileName))
            {
                FileStream fileStream = File.OpenRead(fileName);
                BinaryFormatter f = new BinaryFormatter();

                return f.Deserialize(fileStream) as Mercado;
            }
            else
            {
                Console.WriteLine("File not found");
                return null;
            }
        }
    }
}
