using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{  
    
   public class Youtuber
    {
        private string Nome;
        private string Apelido;
        private int QuantidadeDeInscritos;
        private int QuantidadeDeLikes;
        private long QuantidadeDeViews;
        private string Descricao;
        private long Renda;
        private string Link;
        private string Nacionalidade;
        private int QuantidadeDeVideos;
        private string Categoria;
        private bool Anuncio;
        private bool Patrocinador;
        private int QuantidadeDeStrikes;
        private string Plataforma;
        private bool Streamer;

        //SETs

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        public void SetApelido(string apelido)
        {
            this.Apelido = apelido;
        }
        public void SetQuantidadeDeInscritos(int quantidadedeinscritos)
        {
            this.QuantidadeDeInscritos = quantidadedeinscritos;
        }
        public void SetQuantidadeDeLikes(int quantidadedelikes)
        {
            this.QuantidadeDeLikes = quantidadedelikes;
        }
        public void SetQuantidadeDeViews(long quantidadedeviews)
        {
            this.QuantidadeDeViews = quantidadedeviews;
        }
        public void SetDescricao(string descricao)
        {
            this.Descricao = descricao;
        }
        public void SetRenda(long renda)
        {
            this.Renda = renda;
        }
        public void SetLink(string link)
        {
            this.Link = link;
        }
        public void SetNacionalidade(string nacionalidade)
        {
            this.Nacionalidade = nacionalidade;
        }
        public void SetQuantidadeDeVideos(int quantidadevideos)
        {
            this.QuantidadeDeVideos = quantidadevideos;
        }
        public void SetCategoria(string categoria)
        {
            this.Categoria = categoria;
        }
        public void SetAnuncio(bool anuncio)
        {
            this.Anuncio = anuncio;
        }
        public void SetPatrocinador(bool patrocinador)
        {
            this.Patrocinador = patrocinador;
        }
        public void SetQuantidadeStrikes(int quantidadedestrikes)
        {
            this.QuantidadeDeStrikes = quantidadedestrikes;
        }
        public void SetPlataforma(string plataforma)
        {
            this.Plataforma = plataforma;
        }
        public void SetStreamer(bool streamer)
        {
            this.Streamer = streamer;
        }

        //GETs

        public string GetNome() { return Nome; }
        public string GetApelido() { return Apelido; }
        public int GetQuantidadeDeInscritos() { return QuantidadeDeInscritos; }
        public int GetQuantidadeDeLikes() { return QuantidadeDeLikes; }
        public long GetQuantidadeDeViews() { return QuantidadeDeViews; }
        public string GetDescricao() { return Descricao; }
        public long GetRenda() { return Renda; }
        public string GetLink() { return Link; }
        public string GetNacionalidade() { return Nacionalidade; }
        public int GetQuantidadeDeVideos() { return QuantidadeDeVideos; }
        public string GetCategoria() { return Categoria; }
        public bool GetAnuncio() { return Anuncio; }
        public bool GetPatrocinador() {return Patrocinador; }
        public int GetQuantidadesDeStrikes() { return QuantidadeDeStrikes;}
        public string GetPlataforma() { return Plataforma; }
        public bool GetStreamer() { return Streamer; }
        

    }
}
