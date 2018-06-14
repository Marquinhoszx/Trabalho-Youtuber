namespace WindowsFormsApplication1
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalInscritos = new System.Windows.Forms.TextBox();
            this.txtQuantidadeDeLikes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidadeDeViews = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudQuantidadeStrikes = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSalvar1 = new System.Windows.Forms.Button();
            this.cbSimPatrocinador = new System.Windows.Forms.CheckBox();
            this.cbNaoPatrocinador = new System.Windows.Forms.CheckBox();
            this.cbNaoAnuncio = new System.Windows.Forms.CheckBox();
            this.cbSimAnuncio = new System.Windows.Forms.CheckBox();
            this.cbNãoStreamer = new System.Windows.Forms.CheckBox();
            this.cbSimStreamer = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDeInscritos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDeVizu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDeVideos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Streamer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeStrikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(427, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(102, 88);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(173, 20);
            this.txtApelido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apelido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sobrenome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total de Inscritos";
            // 
            // txtTotalInscritos
            // 
            this.txtTotalInscritos.Location = new System.Drawing.Point(102, 135);
            this.txtTotalInscritos.Name = "txtTotalInscritos";
            this.txtTotalInscritos.Size = new System.Drawing.Size(173, 20);
            this.txtTotalInscritos.TabIndex = 7;
            // 
            // txtQuantidadeDeLikes
            // 
            this.txtQuantidadeDeLikes.Location = new System.Drawing.Point(392, 135);
            this.txtQuantidadeDeLikes.Name = "txtQuantidadeDeLikes";
            this.txtQuantidadeDeLikes.Size = new System.Drawing.Size(137, 20);
            this.txtQuantidadeDeLikes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade de Likes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade de Views";
            // 
            // txtQuantidadeDeViews
            // 
            this.txtQuantidadeDeViews.Location = new System.Drawing.Point(392, 183);
            this.txtQuantidadeDeViews.Name = "txtQuantidadeDeViews";
            this.txtQuantidadeDeViews.Size = new System.Drawing.Size(137, 20);
            this.txtQuantidadeDeViews.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 458);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(427, 146);
            this.textBox3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descrição";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Renda";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(102, 186);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(173, 20);
            this.txtRenda.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Link";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(102, 225);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(427, 20);
            this.txtLink.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(21, 274);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 13);
            this.label.TabIndex = 19;
            this.label.Text = "Nacionalidade";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(102, 274);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(180, 20);
            this.txtNacionalidade.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Quantidade de Vídeos";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(409, 273);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(102, 318);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(180, 20);
            this.txtCategoria.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Possui anûncio?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Patrocinado?";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Quantidade de STRIKES";
            // 
            // nudQuantidadeStrikes
            // 
            this.nudQuantidadeStrikes.Location = new System.Drawing.Point(140, 413);
            this.nudQuantidadeStrikes.Name = "nudQuantidadeStrikes";
            this.nudQuantidadeStrikes.Size = new System.Drawing.Size(93, 20);
            this.nudQuantidadeStrikes.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 415);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Streamer?";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(269, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Plataforma";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(335, 363);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 20);
            this.textBox4.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 486);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "(Obrigatório)";
            // 
            // btnSalvar1
            // 
            this.btnSalvar1.BackColor = System.Drawing.Color.Red;
            this.btnSalvar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar1.ForeColor = System.Drawing.Color.Lime;
            this.btnSalvar1.Location = new System.Drawing.Point(102, 610);
            this.btnSalvar1.Name = "btnSalvar1";
            this.btnSalvar1.Size = new System.Drawing.Size(159, 85);
            this.btnSalvar1.TabIndex = 39;
            this.btnSalvar1.Text = "Salvar";
            this.btnSalvar1.UseVisualStyleBackColor = false;
            this.btnSalvar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSimPatrocinador
            // 
            this.cbSimPatrocinador.AutoSize = true;
            this.cbSimPatrocinador.Location = new System.Drawing.Point(102, 360);
            this.cbSimPatrocinador.Name = "cbSimPatrocinador";
            this.cbSimPatrocinador.Size = new System.Drawing.Size(43, 17);
            this.cbSimPatrocinador.TabIndex = 41;
            this.cbSimPatrocinador.Text = "Sim";
            this.cbSimPatrocinador.UseVisualStyleBackColor = true;
            // 
            // cbNaoPatrocinador
            // 
            this.cbNaoPatrocinador.AutoSize = true;
            this.cbNaoPatrocinador.Location = new System.Drawing.Point(202, 359);
            this.cbNaoPatrocinador.Name = "cbNaoPatrocinador";
            this.cbNaoPatrocinador.Size = new System.Drawing.Size(46, 17);
            this.cbNaoPatrocinador.TabIndex = 42;
            this.cbNaoPatrocinador.Text = "Não";
            this.cbNaoPatrocinador.UseVisualStyleBackColor = true;
            // 
            // cbNaoAnuncio
            // 
            this.cbNaoAnuncio.AutoSize = true;
            this.cbNaoAnuncio.Location = new System.Drawing.Point(483, 321);
            this.cbNaoAnuncio.Name = "cbNaoAnuncio";
            this.cbNaoAnuncio.Size = new System.Drawing.Size(46, 17);
            this.cbNaoAnuncio.TabIndex = 43;
            this.cbNaoAnuncio.Text = "Não";
            this.cbNaoAnuncio.UseVisualStyleBackColor = true;
            // 
            // cbSimAnuncio
            // 
            this.cbSimAnuncio.AutoSize = true;
            this.cbSimAnuncio.Location = new System.Drawing.Point(409, 321);
            this.cbSimAnuncio.Name = "cbSimAnuncio";
            this.cbSimAnuncio.Size = new System.Drawing.Size(43, 17);
            this.cbSimAnuncio.TabIndex = 44;
            this.cbSimAnuncio.Text = "Sim";
            this.cbSimAnuncio.UseVisualStyleBackColor = true;
            // 
            // cbNãoStreamer
            // 
            this.cbNãoStreamer.AutoSize = true;
            this.cbNãoStreamer.Location = new System.Drawing.Point(483, 416);
            this.cbNãoStreamer.Name = "cbNãoStreamer";
            this.cbNãoStreamer.Size = new System.Drawing.Size(46, 17);
            this.cbNãoStreamer.TabIndex = 45;
            this.cbNãoStreamer.Text = "Não";
            this.cbNãoStreamer.UseVisualStyleBackColor = true;
            // 
            // cbSimStreamer
            // 
            this.cbSimStreamer.AutoSize = true;
            this.cbSimStreamer.Location = new System.Drawing.Point(372, 414);
            this.cbSimStreamer.Name = "cbSimStreamer";
            this.cbSimStreamer.Size = new System.Drawing.Size(43, 17);
            this.cbSimStreamer.TabIndex = 46;
            this.cbSimStreamer.Text = "Sim";
            this.cbSimStreamer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(372, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 85);
            this.button1.TabIndex = 47;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dgvListar
            // 
            this.dgvListar.AllowUserToAddRows = false;
            this.dgvListar.AllowUserToDeleteRows = false;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Apelido,
            this.QuantidadeDeInscritos,
            this.QuantidadeDeVizu,
            this.Nacionalidade,
            this.QuantidadeDeVideos,
            this.Categoria,
            this.Plataforma,
            this.Streamer});
            this.dgvListar.Location = new System.Drawing.Point(535, 186);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(865, 344);
            this.dgvListar.TabIndex = 48;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Apelido
            // 
            this.Apelido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apelido.HeaderText = "Apelido";
            this.Apelido.Name = "Apelido";
            this.Apelido.ReadOnly = true;
            // 
            // QuantidadeDeInscritos
            // 
            this.QuantidadeDeInscritos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantidadeDeInscritos.HeaderText = "QuantidadeDeInscritos";
            this.QuantidadeDeInscritos.Name = "QuantidadeDeInscritos";
            this.QuantidadeDeInscritos.ReadOnly = true;
            // 
            // QuantidadeDeVizu
            // 
            this.QuantidadeDeVizu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantidadeDeVizu.HeaderText = "QuantidadeDeVizu";
            this.QuantidadeDeVizu.Name = "QuantidadeDeVizu";
            this.QuantidadeDeVizu.ReadOnly = true;
            // 
            // Nacionalidade
            // 
            this.Nacionalidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nacionalidade.HeaderText = "Nacionalidade";
            this.Nacionalidade.Name = "Nacionalidade";
            this.Nacionalidade.ReadOnly = true;
            // 
            // QuantidadeDeVideos
            // 
            this.QuantidadeDeVideos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantidadeDeVideos.HeaderText = "QuantidadeDeVideos";
            this.QuantidadeDeVideos.Name = "QuantidadeDeVideos";
            this.QuantidadeDeVideos.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Plataforma
            // 
            this.Plataforma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plataforma.HeaderText = "Plataforma";
            this.Plataforma.Name = "Plataforma";
            this.Plataforma.ReadOnly = true;
            // 
            // Streamer
            // 
            this.Streamer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Streamer.HeaderText = "Streamer";
            this.Streamer.Name = "Streamer";
            this.Streamer.ReadOnly = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 771);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSimStreamer);
            this.Controls.Add(this.cbNãoStreamer);
            this.Controls.Add(this.cbSimAnuncio);
            this.Controls.Add(this.cbNaoAnuncio);
            this.Controls.Add(this.cbNaoPatrocinador);
            this.Controls.Add(this.cbSimPatrocinador);
            this.Controls.Add(this.btnSalvar1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudQuantidadeStrikes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtQuantidadeDeViews);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantidadeDeLikes);
            this.Controls.Add(this.txtTotalInscritos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeStrikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalInscritos;
        private System.Windows.Forms.TextBox txtQuantidadeDeLikes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidadeDeViews;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudQuantidadeStrikes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSalvar1;
        private System.Windows.Forms.CheckBox cbSimPatrocinador;
        private System.Windows.Forms.CheckBox cbNaoPatrocinador;
        private System.Windows.Forms.CheckBox cbNaoAnuncio;
        private System.Windows.Forms.CheckBox cbSimAnuncio;
        private System.Windows.Forms.CheckBox cbNãoStreamer;
        private System.Windows.Forms.CheckBox cbSimStreamer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDeInscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDeVizu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDeVideos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Streamer;
    }
}

