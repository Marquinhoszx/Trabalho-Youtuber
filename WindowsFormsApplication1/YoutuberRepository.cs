using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class YoutuberRepository
    {
        List<Youtuber> youtuberes = new List<Youtuber>();
        public YoutuberRepository()
        {
            if (File.Exists(Cadastro.NOME_ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(Cadastro.NOME_ARQUIVO);
                youtuberes = ((YoutuberRepository)binaryReader.Deserialize(stream)).ObterYoutuber();
                stream.Close();
            }
        }

        public List<Youtuber> ObterYoutuber()
        {
            return youtuberes;
        }

        internal void AdicionarYoutuber(Youtuber youtuber)
        {
            youtuberes.Add(youtuber);
            EscreverNoArquivoDosYoutubers();
        }
        private void EscreverNoArquivoDosYoutubers()
        {
            BinaryFormatter binaryWriter = new BinaryFormatter();
            Stream stream = new FileStream(Cadastro.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWriter.Serialize(stream, this);
            stream.Close();
        }
        internal void apagarYoutuber(string nome)
        {
            foreach (Youtuber youtuber in youtuberes)
            {
                if (youtuber.GetNome() == nome)
                {
                    youtuberes.Remove(youtuber);
                    EscreverNoArquivoDosYoutubers();
                    return;
                }
            }
        }
        
        internal void EditarYoutuber(Youtuber youtuber, int posicao)
        {
            youtuberes[posicao] = youtuber;
            EscreverNoArquivoDosYoutubers();
        }

        
    }
}
