
namespace PimIV_Desktop.Telas
{
    partial class formConteudo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConteudo));
            this.lblDia = new System.Windows.Forms.Label();
            this.lblSeg = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.panel_Inicial = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.PicBoxLogoUser = new System.Windows.Forms.PictureBox();
            this.PicboxLogoFixo = new System.Windows.Forms.PictureBox();
            this.btnNovaReserva = new System.Windows.Forms.Button();
            this.btnMapaReservas = new System.Windows.Forms.Button();
            this.btnMapaQuartos = new System.Windows.Forms.Button();
            this.btnConsumos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnHospedes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnPrecos = new System.Windows.Forms.Button();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.panelBoasvindas = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.mapaQuartos1 = new PimIV_Desktop.Telas.MapaQuartos();
            this.mapaReservas1 = new PimIV_Desktop.Telas.MapaReservas();
            this.novaReserva1 = new PimIV_Desktop.Telas.NovaReserva();
            this.listaHospedes1 = new PimIV_Desktop.Telas.ListaHospedes();
            this.editarPrecos1 = new PimIV_Desktop.Telas.EditarPrecos();
            this.gerirProdutos1 = new PimIV_Desktop.Telas.GerirProdutos();
            this.gerirConsumos1 = new PimIV_Desktop.Telas.GerirConsumos();
            this.listaFuncionarios1 = new PimIV_Desktop.Telas.ListaFuncionarios();
            this.relatorios1 = new PimIV_Desktop.Telas.Relatorios();
            this.panel_Inicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxLogoFixo)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.panelBoasvindas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDia.Location = new System.Drawing.Point(456, 491);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(450, 91);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Sexta-Feira";
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeg.ForeColor = System.Drawing.Color.White;
            this.lblSeg.Location = new System.Drawing.Point(604, 373);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(87, 63);
            this.lblSeg.TabIndex = 2;
            this.lblSeg.Text = "02";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(22, 506);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(381, 76);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "07 set 2021";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(341, 350);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(284, 108);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "22:22";
            // 
            // panel_Inicial
            // 
            this.panel_Inicial.Controls.Add(this.lblSeg);
            this.panel_Inicial.Controls.Add(this.lblDia);
            this.panel_Inicial.Controls.Add(this.lblHorario);
            this.panel_Inicial.Controls.Add(this.lblData);
            this.panel_Inicial.Controls.Add(this.pictureBox2);
            this.panel_Inicial.Location = new System.Drawing.Point(252, 69);
            this.panel_Inicial.Name = "panel_Inicial";
            this.panel_Inicial.Size = new System.Drawing.Size(1000, 600);
            this.panel_Inicial.TabIndex = 5;
            this.panel_Inicial.LocationChanged += new System.EventHandler(this.panel_Inicial_LocationChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(264, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(451, 323);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo.Location = new System.Drawing.Point(80, 14);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(150, 31);
            this.lblBemVindo.TabIndex = 6;
            this.lblBemVindo.Text = "Bem-vindo ";
            // 
            // PicBoxLogoUser
            // 
            this.PicBoxLogoUser.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxLogoUser.Image")));
            this.PicBoxLogoUser.Location = new System.Drawing.Point(3, 2);
            this.PicBoxLogoUser.Name = "PicBoxLogoUser";
            this.PicBoxLogoUser.Size = new System.Drawing.Size(71, 50);
            this.PicBoxLogoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxLogoUser.TabIndex = 7;
            this.PicBoxLogoUser.TabStop = false;
            // 
            // PicboxLogoFixo
            // 
            this.PicboxLogoFixo.Image = ((System.Drawing.Image)(resources.GetObject("PicboxLogoFixo.Image")));
            this.PicboxLogoFixo.Location = new System.Drawing.Point(51, 14);
            this.PicboxLogoFixo.Name = "PicboxLogoFixo";
            this.PicboxLogoFixo.Size = new System.Drawing.Size(147, 77);
            this.PicboxLogoFixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicboxLogoFixo.TabIndex = 9;
            this.PicboxLogoFixo.TabStop = false;
            this.PicboxLogoFixo.Click += new System.EventHandler(this.PicboxLogoFixo_Click);
            // 
            // btnNovaReserva
            // 
            this.btnNovaReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnNovaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaReserva.ForeColor = System.Drawing.Color.Black;
            this.btnNovaReserva.Location = new System.Drawing.Point(1, 4);
            this.btnNovaReserva.Name = "btnNovaReserva";
            this.btnNovaReserva.Size = new System.Drawing.Size(240, 49);
            this.btnNovaReserva.TabIndex = 0;
            this.btnNovaReserva.Text = "Nova Reserva";
            this.btnNovaReserva.UseVisualStyleBackColor = false;
            this.btnNovaReserva.Visible = false;
            this.btnNovaReserva.Click += new System.EventHandler(this.btnNovaReserva_Click);
            // 
            // btnMapaReservas
            // 
            this.btnMapaReservas.BackColor = System.Drawing.Color.Transparent;
            this.btnMapaReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapaReservas.ForeColor = System.Drawing.Color.Black;
            this.btnMapaReservas.Location = new System.Drawing.Point(1, 67);
            this.btnMapaReservas.Name = "btnMapaReservas";
            this.btnMapaReservas.Size = new System.Drawing.Size(240, 49);
            this.btnMapaReservas.TabIndex = 1;
            this.btnMapaReservas.Text = "Mapa Reservas";
            this.btnMapaReservas.UseVisualStyleBackColor = false;
            this.btnMapaReservas.Visible = false;
            this.btnMapaReservas.Click += new System.EventHandler(this.btnMapaReservas_Click);
            // 
            // btnMapaQuartos
            // 
            this.btnMapaQuartos.BackColor = System.Drawing.Color.Transparent;
            this.btnMapaQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapaQuartos.ForeColor = System.Drawing.Color.Black;
            this.btnMapaQuartos.Location = new System.Drawing.Point(1, 130);
            this.btnMapaQuartos.Name = "btnMapaQuartos";
            this.btnMapaQuartos.Size = new System.Drawing.Size(240, 49);
            this.btnMapaQuartos.TabIndex = 2;
            this.btnMapaQuartos.Text = "Mapa Quartos";
            this.btnMapaQuartos.UseVisualStyleBackColor = false;
            this.btnMapaQuartos.Visible = false;
            this.btnMapaQuartos.Click += new System.EventHandler(this.btnMapaQuartos_Click);
            // 
            // btnConsumos
            // 
            this.btnConsumos.BackColor = System.Drawing.Color.Transparent;
            this.btnConsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumos.ForeColor = System.Drawing.Color.Black;
            this.btnConsumos.Location = new System.Drawing.Point(1, 193);
            this.btnConsumos.Name = "btnConsumos";
            this.btnConsumos.Size = new System.Drawing.Size(240, 49);
            this.btnConsumos.TabIndex = 3;
            this.btnConsumos.Text = "Consumos";
            this.btnConsumos.UseVisualStyleBackColor = false;
            this.btnConsumos.Visible = false;
            this.btnConsumos.Click += new System.EventHandler(this.btnConsumos_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnEstoque.Location = new System.Drawing.Point(1, 256);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(240, 49);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Visible = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnHospedes
            // 
            this.btnHospedes.BackColor = System.Drawing.Color.Transparent;
            this.btnHospedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedes.ForeColor = System.Drawing.Color.Black;
            this.btnHospedes.Location = new System.Drawing.Point(1, 319);
            this.btnHospedes.Name = "btnHospedes";
            this.btnHospedes.Size = new System.Drawing.Size(240, 49);
            this.btnHospedes.TabIndex = 5;
            this.btnHospedes.Text = "Hóspedes";
            this.btnHospedes.UseVisualStyleBackColor = false;
            this.btnHospedes.Visible = false;
            this.btnHospedes.Click += new System.EventHandler(this.btnHospedes_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionarios.Location = new System.Drawing.Point(1, 382);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(240, 49);
            this.btnFuncionarios.TabIndex = 6;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Visible = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.Black;
            this.btnRelatorios.Location = new System.Drawing.Point(1, 445);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(240, 49);
            this.btnRelatorios.TabIndex = 7;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Visible = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnPrecos
            // 
            this.btnPrecos.BackColor = System.Drawing.Color.Transparent;
            this.btnPrecos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecos.ForeColor = System.Drawing.Color.Black;
            this.btnPrecos.Location = new System.Drawing.Point(1, 508);
            this.btnPrecos.Name = "btnPrecos";
            this.btnPrecos.Size = new System.Drawing.Size(240, 49);
            this.btnPrecos.TabIndex = 8;
            this.btnPrecos.Text = "Preços";
            this.btnPrecos.UseVisualStyleBackColor = false;
            this.btnPrecos.Visible = false;
            this.btnPrecos.Click += new System.EventHandler(this.btnPrecos_Click);
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnNovaReserva);
            this.panelBotoes.Controls.Add(this.btnEstoque);
            this.panelBotoes.Controls.Add(this.btnMapaReservas);
            this.panelBotoes.Controls.Add(this.btnHospedes);
            this.panelBotoes.Controls.Add(this.btnMapaQuartos);
            this.panelBotoes.Controls.Add(this.btnPrecos);
            this.panelBotoes.Controls.Add(this.btnFuncionarios);
            this.panelBotoes.Controls.Add(this.btnRelatorios);
            this.panelBotoes.Controls.Add(this.btnConsumos);
            this.panelBotoes.Location = new System.Drawing.Point(6, 111);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(242, 560);
            this.panelBotoes.TabIndex = 1;
            // 
            // panelBoasvindas
            // 
            this.panelBoasvindas.Controls.Add(this.PicBoxLogoUser);
            this.panelBoasvindas.Controls.Add(this.lblBemVindo);
            this.panelBoasvindas.Location = new System.Drawing.Point(768, 12);
            this.panelBoasvindas.Name = "panelBoasvindas";
            this.panelBoasvindas.Size = new System.Drawing.Size(484, 52);
            this.panelBoasvindas.TabIndex = 18;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMensagem.Location = new System.Drawing.Point(250, 46);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(21, 20);
            this.lblMensagem.TabIndex = 56;
            this.lblMensagem.Text = "...";
            // 
            // mapaQuartos1
            // 
            this.mapaQuartos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.mapaQuartos1.Location = new System.Drawing.Point(252, 69);
            this.mapaQuartos1.Name = "mapaQuartos1";
            this.mapaQuartos1.Size = new System.Drawing.Size(1000, 600);
            this.mapaQuartos1.TabIndex = 59;
            this.mapaQuartos1.TabStop = false;
            // 
            // mapaReservas1
            // 
            this.mapaReservas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.mapaReservas1.Location = new System.Drawing.Point(252, 69);
            this.mapaReservas1.Name = "mapaReservas1";
            this.mapaReservas1.Size = new System.Drawing.Size(1000, 600);
            this.mapaReservas1.TabIndex = 58;
            this.mapaReservas1.TabStop = false;
            // 
            // novaReserva1
            // 
            this.novaReserva1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.novaReserva1.Location = new System.Drawing.Point(252, 69);
            this.novaReserva1.Name = "novaReserva1";
            this.novaReserva1.Size = new System.Drawing.Size(1000, 600);
            this.novaReserva1.TabIndex = 57;
            this.novaReserva1.TabStop = false;
            // 
            // listaHospedes1
            // 
            this.listaHospedes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.listaHospedes1.Location = new System.Drawing.Point(252, 69);
            this.listaHospedes1.Name = "listaHospedes1";
            this.listaHospedes1.Size = new System.Drawing.Size(1000, 600);
            this.listaHospedes1.TabIndex = 16;
            this.listaHospedes1.TabStop = false;
            // 
            // editarPrecos1
            // 
            this.editarPrecos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.editarPrecos1.Location = new System.Drawing.Point(252, 67);
            this.editarPrecos1.Name = "editarPrecos1";
            this.editarPrecos1.Size = new System.Drawing.Size(1000, 600);
            this.editarPrecos1.TabIndex = 14;
            this.editarPrecos1.TabStop = false;
            // 
            // gerirProdutos1
            // 
            this.gerirProdutos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gerirProdutos1.Location = new System.Drawing.Point(252, 69);
            this.gerirProdutos1.Name = "gerirProdutos1";
            this.gerirProdutos1.Size = new System.Drawing.Size(1000, 600);
            this.gerirProdutos1.TabIndex = 21;
            this.gerirProdutos1.TabStop = false;
            // 
            // gerirConsumos1
            // 
            this.gerirConsumos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.gerirConsumos1.Location = new System.Drawing.Point(252, 69);
            this.gerirConsumos1.Name = "gerirConsumos1";
            this.gerirConsumos1.Size = new System.Drawing.Size(1000, 600);
            this.gerirConsumos1.TabIndex = 20;
            this.gerirConsumos1.TabStop = false;
            // 
            // listaFuncionarios1
            // 
            this.listaFuncionarios1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.listaFuncionarios1.Location = new System.Drawing.Point(252, 69);
            this.listaFuncionarios1.Name = "listaFuncionarios1";
            this.listaFuncionarios1.Size = new System.Drawing.Size(1000, 600);
            this.listaFuncionarios1.TabIndex = 22;
            this.listaFuncionarios1.TabStop = false;
            // 
            // relatorios1
            // 
            this.relatorios1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.relatorios1.Location = new System.Drawing.Point(252, 69);
            this.relatorios1.Name = "relatorios1";
            this.relatorios1.Size = new System.Drawing.Size(1000, 600);
            this.relatorios1.TabIndex = 23;
            this.relatorios1.TabStop = false;
            // 
            // formConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_Inicial);
            this.Controls.Add(this.mapaQuartos1);
            this.Controls.Add(this.mapaReservas1);
            this.Controls.Add(this.novaReserva1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.PicboxLogoFixo);
            this.Controls.Add(this.panelBoasvindas);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.listaHospedes1);
            this.Controls.Add(this.editarPrecos1);
            this.Controls.Add(this.gerirProdutos1);
            this.Controls.Add(this.gerirConsumos1);
            this.Controls.Add(this.listaFuncionarios1);
            this.Controls.Add(this.relatorios1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formConteudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Conteudo_FormClosed);
            this.Load += new System.EventHandler(this.Conteudo_Load);
            this.SizeChanged += new System.EventHandler(this.formConteudo_SizeChanged);
            this.panel_Inicial.ResumeLayout(false);
            this.panel_Inicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxLogoFixo)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.panelBoasvindas.ResumeLayout(false);
            this.panelBoasvindas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Panel panel_Inicial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.PictureBox PicBoxLogoUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PicboxLogoFixo;
        private System.Windows.Forms.Button btnNovaReserva;
        private System.Windows.Forms.Button btnMapaReservas;
        private System.Windows.Forms.Button btnMapaQuartos;
        private System.Windows.Forms.Button btnConsumos;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnHospedes;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnPrecos;
        private PimIV_Desktop.Telas.EditarPrecos editarPrecos1;
        private PimIV_Desktop.Telas.ListaHospedes listaHospedes1;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Panel panelBoasvindas;
        private PimIV_Desktop.Telas.GerirConsumos gerirConsumos1;
        private PimIV_Desktop.Telas.GerirProdutos gerirProdutos1;
        private PimIV_Desktop.Telas.ListaFuncionarios listaFuncionarios1;
        private Relatorios relatorios1;
        private System.Windows.Forms.Label lblMensagem;
        private NovaReserva novaReserva1;
        private MapaReservas mapaReservas1;
        private MapaQuartos mapaQuartos1;
    }
}