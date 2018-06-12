namespace WindowsFormsApplication1
{
    partial class ListarYT
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
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
            this.dgvListar.Location = new System.Drawing.Point(12, 231);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(1127, 344);
            this.dgvListar.TabIndex = 0;
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
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(933, 147);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(206, 68);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(721, 147);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(206, 68);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // ListarYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 614);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvListar);
            this.Name = "ListarYT";
            this.Text = "ListarYT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}