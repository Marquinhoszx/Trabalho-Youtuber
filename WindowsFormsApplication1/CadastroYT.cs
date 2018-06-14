using System;
using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Achou que eu iria salvar?");
            MessageBox.Show("Logo EU");



        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarYT listar = new ListarYT();
            listar.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                Youtuber youtuber = new Youtuber();
                youtuber.SetNome(txtNome.Text);
                youtuber.SetApelido(txtApelido.Text);
                youtuber.SetSobrenome(textBox1.Text);
                youtuber.SetQuantidadeDeInscritos(Convert.ToInt32(txtTotalInscritos.Text));
                youtuber.SetQuantidadeDeLikes(Convert.ToInt32(txtQuantidadeDeLikes.Text));
                youtuber.SetQuantidadeDeViews(Convert.ToInt64(txtQuantidadeDeViews.Text));
                youtuber.SetDescricao(textBox3.Text);
                youtuber.SetRenda(Convert.ToInt64(txtRenda.Text));
                youtuber.SetLink(txtLink.Text);
                youtuber.SetNacionalidade(txtNacionalidade.Text);
                youtuber.SetQuantidadeDeVideos(Convert.ToInt32(numericUpDown1.Value));
                youtuber.SetCategoria(txtCategoria.Text);
                youtuber.SetAnuncio(Convert.ToBoolean(cbSimAnuncio.Text));
                youtuber.SetAnuncio(Convert.ToBoolean(cbNaoAnuncio.Text));
                youtuber.SetPatrocinador(Convert.ToBoolean(cbSimAnuncio.Text));
                youtuber.SetPatrocinador(Convert.ToBoolean(cbNaoPatrocinador.Text));
                youtuber.SetQuantidadeStrikes(Convert.ToInt32(nudQuantidadeStrikes.Value));
                youtuber.SetStreamer(Convert.ToBoolean(cbSimStreamer.Text));
                youtuber.SetStreamer(Convert.ToBoolean(cbNãoStreamer.Text));

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }







        }

      

       
        
    }
}
