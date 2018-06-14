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
        private string Sobrenome;
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
            if (nome.Count() < 4)
            {
                throw new Exception("Nome deve conter no mínimo 4 caracteres");
                

            }
            if(nome.Count() < 4)
            {
                throw new Exception("Nome no máximo deve conter 30 caracteres");
                
            }
            
            this.Nome = nome;
        }
        public void SetApelido(string apelido)
        {
            if (apelido.Count() < 4)
            {
                throw new Exception("Nome deve conter no mínimo 4 caracteres");
            }
            if (apelido.Count() > 30)
            {
                throw new Exception("Nome deve conter no máximo 30 caracteres");
            }

            this.Apelido = apelido;
        }
        public void SetSobrenome(string sobrenome)
        {
            if (sobrenome.Count() < 4)
            {
                throw new Exception("Sobrenome deve conter no mínimo 4 caracteres");
            }
            if (sobrenome.Count() < 30)
            {
                throw new Exception("Sobrenome no máximo deve conter 40 caracteres");
            }
            
            this.Sobrenome = sobrenome;
        }
        public void SetQuantidadeDeInscritos(int quantidadedeinscritos)
        {
            if(quantidadedeinscritos == 0)
            {
                throw new Exception("Quantidade de inscritos deve ser maior de 0");
            }
            this.QuantidadeDeInscritos = quantidadedeinscritos;
        }
        public void SetQuantidadeDeLikes(int quantidadedelikes)
        {
            if (quantidadedelikes == 0)
            {
                throw new Exception("Quantidade de likes deve ser maior qe 0");
            }
            this.QuantidadeDeLikes = quantidadedelikes;
        }
        public void SetQuantidadeDeViews(long quantidadedeviews)
        {
            if (quantidadedeviews == 0)
            {
                throw new Exception("Quantidade de Views deve ser maior de 0");
            }
            
            this.QuantidadeDeViews = quantidadedeviews;
        }
        public void SetDescricao(string descricao)
        {
            if (descricao.Count() == 0)
            {
                throw new Exception("Descrição deve ser preenchido");
            }
            
            this.Descricao = descricao;
        }
        public void SetRenda(long renda)
        {
            if (renda == 0)
            {
                throw new Exception("Renda deve ser maior que 0");
            }
            this.Renda = renda;
        }
        public void SetLink(string link)
        {
            if (link.Count() < 35)
            {
                throw new Exception("Link não deve conter menos de 35 caracteres");
            }
            if (link.Count() > 300)
            {
                throw new Exception("Link não deve conter mais de 300 caracateres");
            }
            this.Link = link;
        }
        public void SetNacionalidade(string nacionalidade)
        {
            if (nacionalidade.Count() < 5)
            {
                throw new Exception("Nacionalidade não deve conter menos que 5 caracteres");
            }
            if (nacionalidade.Count() > 35)
            {
                throw new Exception("Nacionalidade nçao deve conter mais de 35 caracteres");
            }
            this.Nacionalidade = nacionalidade;
        }
        public void SetQuantidadeDeVideos(int quantidadevideos)
        {
            if (quantidadevideos == 0)
            {
                throw new Exception("Quantidade de videos não deve conter menos que 0 videos ");
            }
            this.QuantidadeDeVideos = quantidadevideos;
        }
        public void SetCategoria(string categoria)
        {
            if (categoria.Count() < 5)
            {
                throw new Exception("Categoria não deve conter menos de 5 caracteres");
            }
            if (categoria.Count() > 30)
            {
                throw new Exception("Categoria não deve conter mais que 30 caracteres");
            }
            this.Categoria = categoria;
        }
        public void SetAnuncio(bool anuncio)
        {
            if (anuncio == null)
            {
                throw new Exception("Selecione anuncio");
            }
            this.Anuncio = anuncio;
        }
        public void SetPatrocinador(bool patrocinador)
        {
            this.Patrocinador = patrocinador;
        }
        public void SetQuantidadeStrikes(int quantidadedestrikes)
        {
            if (quantidadedestrikes == -1)
            {
                throw new Exception("Quantidade de strikes não deve conter menos de -1");
            }



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
        public string GetSobrenome() { return Sobrenome; }
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
