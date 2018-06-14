using System;
using Model;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public partial class Cadastro : Form
    {
        public static string NOME_ARQUIVO = "Youtuber.bin";
        public int posicao = -1;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Achou que eu iria salvar?");
            MessageBox.Show("Logo EU");



        }

        

        private void button1_Click_2(object sender, EventArgs e)
        {
            Youtuber youtuber = new Youtuber();
            try
            {
                youtuber.SetNome(txtNome.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            try
            {
                if (cbSimAnuncio.Checked)
                {
                    youtuber.SetAnuncio(true);
                }
                else
                {
                    youtuber.SetAnuncio(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                youtuber.SetApelido(txtApelido.Text);
            }
            catch
            {
                MessageBox.Show("Apelido deve ser preenchido");
                return;
            }
            try
            {
                youtuber.SetSobrenome(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Sobrenome deve ser preenchido");
                return;
            }
            try
            {
                youtuber.SetQuantidadeDeInscritos(Convert.ToInt32(txtTotalInscritos.Text));
            }
            catch
            {
                MessageBox.Show("Quantidade de inscritos deve ser preenchida");
                return;
            }
            try
            {
                youtuber.SetQuantidadeDeLikes(Convert.ToInt32(txtQuantidadeDeLikes.Text));
            }
            catch
            {
                MessageBox.Show("Quantidade de likes deve ser preenchido");
                return;
            }
            try
            {
                youtuber.SetQuantidadeDeViews(Convert.ToInt64(txtQuantidadeDeViews.Text));
            }
            catch
            {
                MessageBox.Show("Quantidade de views deve ser preenchida");
                return;
            }
            try
            {
                youtuber.SetDescricao(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Descricao deve ser preenchido");
                return;
            }

            try
            {
                youtuber.SetRenda(Convert.ToInt64(txtRenda.Text));
            }
            catch
            {
                MessageBox.Show("Renda deve ser preenchido");
                return;
            }
            try
            {
                youtuber.SetLink(txtLink.Text);
            }
            catch
            {
                MessageBox.Show("Link deve ser preenchido");
                return;
            }
            try
            {
                youtuber.SetNacionalidade(txtNacionalidade.Text);
            }
            catch
            {
                MessageBox.Show("Nacionalidade deve ser preenchido");
                return;
            }
            try
            {
                youtuber.SetQuantidadeDeVideos(Convert.ToInt32(numericUpDown1.Value));
            }
            catch
            {
                MessageBox.Show("Quantidade de videos deve ser preenchido");
                return;
            }

            try
            {
                youtuber.SetCategoria(txtCategoria.Text);
            }
            catch
            {
                MessageBox.Show("Categoria deve ser preenchida");
                return;
            }

            try
            {
                youtuber.SetQuantidadeStrikes(Convert.ToInt32(nudQuantidadeStrikes.Value));
            }
            catch
            {
                MessageBox.Show("Quantidade De strikes deve ser preenchido");

            }


            YoutuberRepository tudo = new YoutuberRepository();
            if (posicao == -1)
            {
                tudo.AdicionarYoutuber(youtuber);
                MessageBox.Show("Youtuber Cadastrado com sucesso");
            }
            else
            {
                tudo.EditarYoutuber(youtuber, posicao);
                MessageBox.Show("Youtuber alterado com sucesso");
            }


        }

        











        





    }
}
