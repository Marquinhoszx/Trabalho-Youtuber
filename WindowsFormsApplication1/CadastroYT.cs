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
                youtuber.SetSobrenome(txtSobrenome.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                youtuber.SetDescricao(txtDescricao.Text);
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
                youtuber.SetQuantidadeDeVideos(Convert.ToInt32(nudQuantidadeDeVideos.Value));
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

            YoutuberRepository youtuberReposiitory = new YoutuberRepository();

            if (posicao == -1)
            {
                tudo.AdicionarYoutuber(youtuber);
                MessageBox.Show("Youtuber cadastrado com sucesso");
            }
            else
            {
                tudo.EditarYoutuber(youtuber, posicao);
                MessageBox.Show("Youtuber alterado com sucesso");
            }
            LimparCampos();
            AtualizarListaYoutuber();
        }

        private void AtualizarListaYoutuber()
        {
            YoutuberRepository youtubers = new YoutuberRepository();
            dgvListar.Rows.Clear();
            foreach (Youtuber youtuber in tudo.ObterPersonagem())
            {
                dgvListar.Rows.Add(new Object[]{
                youtuber.GetNome(),
                youtuber.GetApelido(),
                youtuber.GetCategoria()
                });
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtApelido.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtTotalInscritos.Text = string.Empty;
            txtQuantidadeDeLikes.Text = string.Empty;
            txtQuantidadeDeViews.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtRenda.Text = string.Empty;
            txtLink.Text = string.Empty;
            txtNacionalidade.Text = string.Empty;
            nudQuantidadeStrikes.Value = 0;
            nudQuantidadeDeVideos.Value = 0;
            cbNaoAnuncio.Checked = false;
            cbNaoPatrocinador.Checked = false;
            cbNãoStreamer.Checked = false;
            cbSimAnuncio.Checked = false;
            cbSimPatrocinador.Checked = false;
            cbSimStreamer.Checked = false;
        }

        private void Cadastro_Activated(object sender, EventArgs e)
        {
            AtualizarListaYoutuber();
        }

        private void Cadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.L)
            {
                EditarYoutuber();
            }
        }

        private void EditarYoutuber()
        {
            if (dgvListar.CurrentRow == null)
            {
                MessageBox.Show("Seu zueirinho,Selecione grid para editar");
                return;
            }
            string nome = dgvListar.Rows[dgvListar.CurrentRow.Index].Cells[0].Value.ToString();
            YoutuberRepository repositorio = new YoutuberRepository();
            int quantidade = 0;
            foreach (Youtuber youtuber in repositorio.ObterPersonagem())
            {
                if (youtuber.GetNome() == nome)
                {
                    txtNome.Text = youtuber.GetNome();
                    txtApelido.Text = youtuber.GetApelido();
                    txtSobrenome.Text = youtuber.GetSobrenome();
                    txtTotalInscritos.Text = youtuber.GetQuantidadeDeInscritos();
                    txtQuantidadeDeLikes.Text = youtuber.GetQuantidadeDeInscritos();
                    txtQuantidadeDeViews.Text = youtuber.GetQuantidadeDeViews();
                    txtDescricao.Text = youtuber.GetDescricao();
                    txtRenda.Text = youtuber.GetRenda();
                    txtLink.Text = youtuber.GetLink();
                    txtNacionalidade.Text = youtuber.GetNacionalidade();
                    nudQuantidadeDeVideos.Value = youtuber.GetQuantidadeDeVideos();
                    txtCategoria.Text = youtuber.GetCategoria();
                    if (youtuber.GetAnuncio)
                    {
                        cbSimAnuncio.Checked = true;
                    }
                    else
                    {
                        cbNaoAnuncio.Checked = false;
                    }
                    if (youtuber.GetPatrocinador)
                    {
                        cbSimPatrocinador.Checked = true;
                    }
                    else
                    {
                        cbNaoPatrocinador.Checked = false;
                    }
                    if (youtuber.GetStreamer)
                    {
                        cbSimStreamer.Checked = true;
                    }
                    else
                    {
                        cbNãoStreamer.Checked = false;
                    }
                    nudQuantidadeStrikes.Value = youtuber.GetQuantidadesDeStrikes();
                    txtPlataforma.Text = youtuber.GetPlataforma();
                }
            }
        }

        











        





    }
}
