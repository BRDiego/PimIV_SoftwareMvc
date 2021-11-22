
namespace PimIV_Desktop.Telas
{
    partial class NovaReserva
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dudQuartos = new System.Windows.Forms.DomainUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudCriancas = new System.Windows.Forms.NumericUpDown();
            this.nudAdultos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnGerarData = new System.Windows.Forms.Button();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mcaEstadia = new System.Windows.Forms.MonthCalendar();
            this.txtPassaporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHospede = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MtxtNasc = new System.Windows.Forms.MaskedTextBox();
            this.CboxSexo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.GBoxDespesas = new System.Windows.Forms.GroupBox();
            this.txtDespesas = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).BeginInit();
            this.GBoxDespesas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dudQuartos
            // 
            this.dudQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudQuartos.Location = new System.Drawing.Point(185, 322);
            this.dudQuartos.Margin = new System.Windows.Forms.Padding(2);
            this.dudQuartos.Name = "dudQuartos";
            this.dudQuartos.Size = new System.Drawing.Size(266, 28);
            this.dudQuartos.TabIndex = 9;
            this.dudQuartos.SelectedItemChanged += new System.EventHandler(this.dudQuartos_SelectedItemChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(54, 324);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 63;
            this.label11.Text = "Tipo Quarto:";
            // 
            // nudCriancas
            // 
            this.nudCriancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCriancas.Location = new System.Drawing.Point(398, 278);
            this.nudCriancas.Margin = new System.Windows.Forms.Padding(2);
            this.nudCriancas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCriancas.Name = "nudCriancas";
            this.nudCriancas.Size = new System.Drawing.Size(53, 28);
            this.nudCriancas.TabIndex = 8;
            // 
            // nudAdultos
            // 
            this.nudAdultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAdultos.Location = new System.Drawing.Point(144, 275);
            this.nudAdultos.Margin = new System.Windows.Forms.Padding(2);
            this.nudAdultos.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAdultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(53, 28);
            this.nudAdultos.TabIndex = 7;
            this.nudAdultos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(302, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "Crianças:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 61;
            this.label6.Text = "Adultos:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkRed;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(838, 419);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 45);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Location = new System.Drawing.Point(828, 490);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(119, 45);
            this.btnReservar.TabIndex = 11;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnGerarData
            // 
            this.btnGerarData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarData.Enabled = false;
            this.btnGerarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarData.ForeColor = System.Drawing.Color.White;
            this.btnGerarData.Location = new System.Drawing.Point(375, 372);
            this.btnGerarData.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerarData.Name = "btnGerarData";
            this.btnGerarData.Size = new System.Drawing.Size(129, 32);
            this.btnGerarData.TabIndex = 10;
            this.btnGerarData.Text = "Gerar Data";
            this.btnGerarData.UseVisualStyleBackColor = false;
            this.btnGerarData.Click += new System.EventHandler(this.btnGerarData_Click);
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOut.Location = new System.Drawing.Point(375, 512);
            this.txtCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.ReadOnly = true;
            this.txtCheckOut.Size = new System.Drawing.Size(130, 28);
            this.txtCheckOut.TabIndex = 60;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckIn.Location = new System.Drawing.Point(375, 445);
            this.txtCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ReadOnly = true;
            this.txtCheckIn.Size = new System.Drawing.Size(130, 28);
            this.txtCheckIn.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(371, 486);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 24);
            this.label10.TabIndex = 58;
            this.label10.Text = "Check-Out:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(371, 419);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "Check-In:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 372);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Estadia:";
            // 
            // mcaEstadia
            // 
            this.mcaEstadia.Enabled = false;
            this.mcaEstadia.Location = new System.Drawing.Point(132, 372);
            this.mcaEstadia.Margin = new System.Windows.Forms.Padding(7);
            this.mcaEstadia.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.mcaEstadia.MaxSelectionCount = 45;
            this.mcaEstadia.Name = "mcaEstadia";
            this.mcaEstadia.TabIndex = 55;
            // 
            // txtPassaporte
            // 
            this.txtPassaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassaporte.Location = new System.Drawing.Point(398, 179);
            this.txtPassaporte.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassaporte.Name = "txtPassaporte";
            this.txtPassaporte.Size = new System.Drawing.Size(130, 28);
            this.txtPassaporte.TabIndex = 6;
            this.txtPassaporte.TextChanged += new System.EventHandler(this.txtPassaporte_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(279, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Passaporte:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(132, 175);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(143, 28);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(350, 132);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 28);
            this.txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "E-mail:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(132, 132);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(143, 28);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Telefone:";
            // 
            // txtHospede
            // 
            this.txtHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospede.Location = new System.Drawing.Point(132, 35);
            this.txtHospede.Margin = new System.Windows.Forms.Padding(2);
            this.txtHospede.Name = "txtHospede";
            this.txtHospede.Size = new System.Drawing.Size(584, 28);
            this.txtHospede.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Hóspede:";
            // 
            // MtxtNasc
            // 
            this.MtxtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtNasc.Location = new System.Drawing.Point(551, 85);
            this.MtxtNasc.Mask = "00/00/0000";
            this.MtxtNasc.Name = "MtxtNasc";
            this.MtxtNasc.Size = new System.Drawing.Size(100, 28);
            this.MtxtNasc.TabIndex = 2;
            this.MtxtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // CboxSexo
            // 
            this.CboxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxSexo.FormattingEnabled = true;
            this.CboxSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CboxSexo.Location = new System.Drawing.Point(132, 83);
            this.CboxSexo.Name = "CboxSexo";
            this.CboxSexo.Size = new System.Drawing.Size(121, 30);
            this.CboxSexo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(343, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "Data de Nascimento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(63, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 24);
            this.label13.TabIndex = 50;
            this.label13.Text = "Sexo:";
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesas.ForeColor = System.Drawing.Color.White;
            this.lblDespesas.Location = new System.Drawing.Point(5, 94);
            this.lblDespesas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(51, 31);
            this.lblDespesas.TabIndex = 62;
            this.lblDespesas.Text = "R$";
            // 
            // GBoxDespesas
            // 
            this.GBoxDespesas.Controls.Add(this.txtDespesas);
            this.GBoxDespesas.Controls.Add(this.lblDespesas);
            this.GBoxDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxDespesas.ForeColor = System.Drawing.SystemColors.Control;
            this.GBoxDespesas.Location = new System.Drawing.Point(538, 399);
            this.GBoxDespesas.Name = "GBoxDespesas";
            this.GBoxDespesas.Size = new System.Drawing.Size(236, 135);
            this.GBoxDespesas.TabIndex = 66;
            this.GBoxDespesas.TabStop = false;
            this.GBoxDespesas.Text = "Valor hospedagem:";
            // 
            // txtDespesas
            // 
            this.txtDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesas.Location = new System.Drawing.Point(61, 98);
            this.txtDespesas.Mask = "00000.00";
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.ReadOnly = true;
            this.txtDespesas.Size = new System.Drawing.Size(91, 29);
            this.txtDespesas.TabIndex = 63;
            this.txtDespesas.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtDespesas.ValidatingType = typeof(int);
            // 
            // NovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.GBoxDespesas);
            this.Controls.Add(this.CboxSexo);
            this.Controls.Add(this.MtxtNasc);
            this.Controls.Add(this.dudQuartos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudCriancas);
            this.Controls.Add(this.nudAdultos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnGerarData);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mcaEstadia);
            this.Controls.Add(this.txtPassaporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHospede);
            this.Controls.Add(this.label1);
            this.Name = "NovaReserva";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.NovaReserva_Load);
            this.Leave += new System.EventHandler(this.NovaReserva_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.nudCriancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).EndInit();
            this.GBoxDespesas.ResumeLayout(false);
            this.GBoxDespesas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dudQuartos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudCriancas;
        private System.Windows.Forms.NumericUpDown nudAdultos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnGerarData;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar mcaEstadia;
        private System.Windows.Forms.TextBox txtPassaporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHospede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MtxtNasc;
        private System.Windows.Forms.ComboBox CboxSexo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDespesas;
        private System.Windows.Forms.GroupBox GBoxDespesas;
        private System.Windows.Forms.MaskedTextBox txtDespesas;
    }
}
