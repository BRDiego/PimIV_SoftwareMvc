﻿
namespace PimIV_Desktop.Telas
{
    partial class DadosFuncionario
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dudSexo = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassaporte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAttFunc = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblAttLogin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAttHosp = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboStatusHos = new System.Windows.Forms.ComboBox();
            this.comboStatusFun = new System.Windows.Forms.ComboBox();
            this.btnSalvarLogin = new System.Windows.Forms.Button();
            this.groupDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.groupDadosLogin = new System.Windows.Forms.GroupBox();
            this.groupDadosPessoais.SuspendLayout();
            this.groupDadosLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkRed;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(253, 302);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 45);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(474, 302);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 45);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(510, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Salário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cargo:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(83, 104);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(144, 28);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(688, 58);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(137, 28);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtpNasc
            // 
            this.dtpNasc.Checked = false;
            this.dtpNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(695, 106);
            this.dtpNasc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNasc.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.dtpNasc.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(114, 26);
            this.dtpNasc.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(99, 58);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(475, 28);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(99, 11);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(537, 28);
            this.txtNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(585, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(565, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome:";
            // 
            // dudSexo
            // 
            this.dudSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudSexo.Location = new System.Drawing.Point(735, 12);
            this.dudSexo.Margin = new System.Windows.Forms.Padding(2);
            this.dudSexo.Name = "dudSexo";
            this.dudSexo.Size = new System.Drawing.Size(90, 28);
            this.dudSexo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(669, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Sexo:";
            // 
            // txtPassaporte
            // 
            this.txtPassaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassaporte.Location = new System.Drawing.Point(373, 104);
            this.txtPassaporte.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassaporte.Name = "txtPassaporte";
            this.txtPassaporte.Size = new System.Drawing.Size(183, 28);
            this.txtPassaporte.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(250, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Passaporte:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Status (funcionário):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(371, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(327, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "Dados contratuais atualizados em:";
            // 
            // lblAttFunc
            // 
            this.lblAttFunc.AutoSize = true;
            this.lblAttFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttFunc.ForeColor = System.Drawing.Color.White;
            this.lblAttFunc.Location = new System.Drawing.Point(697, 267);
            this.lblAttFunc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttFunc.Name = "lblAttFunc";
            this.lblAttFunc.Size = new System.Drawing.Size(68, 24);
            this.lblAttFunc.TabIndex = 45;
            this.lblAttFunc.Text = "dataAt";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(87, 218);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(385, 28);
            this.txtCargo.TabIndex = 9;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DarkRed;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(2, 2);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 45);
            this.btnVoltar.TabIndex = 48;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblAttLogin
            // 
            this.lblAttLogin.AutoSize = true;
            this.lblAttLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttLogin.ForeColor = System.Drawing.Color.White;
            this.lblAttLogin.Location = new System.Drawing.Point(244, 99);
            this.lblAttLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttLogin.Name = "lblAttLogin";
            this.lblAttLogin.Size = new System.Drawing.Size(68, 24);
            this.lblAttLogin.TabIndex = 53;
            this.lblAttLogin.Text = "dataAt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(37, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "Login atualizado em:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(203, 59);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(258, 28);
            this.txtSenha.TabIndex = 1;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(203, 23);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(258, 28);
            this.txtNomeUsuario.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(123, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 24);
            this.label13.TabIndex = 49;
            this.label13.Text = "Senha:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(20, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 24);
            this.label14.TabIndex = 50;
            this.label14.Text = "Nome de Usuário:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(359, 158);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(308, 24);
            this.label15.TabIndex = 45;
            this.label15.Text = "Dados pessoais atualizados em:";
            // 
            // lblAttHosp
            // 
            this.lblAttHosp.AutoSize = true;
            this.lblAttHosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttHosp.ForeColor = System.Drawing.Color.White;
            this.lblAttHosp.Location = new System.Drawing.Point(666, 159);
            this.lblAttHosp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttHosp.Name = "lblAttHosp";
            this.lblAttHosp.Size = new System.Drawing.Size(68, 24);
            this.lblAttHosp.TabIndex = 45;
            this.lblAttHosp.Text = "dataAt";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(13, 158);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 24);
            this.label17.TabIndex = 45;
            this.label17.Text = "Status (hóspede):";
            // 
            // comboStatusHos
            // 
            this.comboStatusHos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatusHos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatusHos.FormattingEnabled = true;
            this.comboStatusHos.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.comboStatusHos.Location = new System.Drawing.Point(195, 158);
            this.comboStatusHos.Name = "comboStatusHos";
            this.comboStatusHos.Size = new System.Drawing.Size(144, 28);
            this.comboStatusHos.TabIndex = 8;
            // 
            // comboStatusFun
            // 
            this.comboStatusFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatusFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatusFun.FormattingEnabled = true;
            this.comboStatusFun.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.comboStatusFun.Location = new System.Drawing.Point(214, 266);
            this.comboStatusFun.Name = "comboStatusFun";
            this.comboStatusFun.Size = new System.Drawing.Size(125, 28);
            this.comboStatusFun.TabIndex = 11;
            // 
            // btnSalvarLogin
            // 
            this.btnSalvarLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalvarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarLogin.ForeColor = System.Drawing.Color.White;
            this.btnSalvarLogin.Location = new System.Drawing.Point(533, 51);
            this.btnSalvarLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarLogin.Name = "btnSalvarLogin";
            this.btnSalvarLogin.Size = new System.Drawing.Size(119, 45);
            this.btnSalvarLogin.TabIndex = 2;
            this.btnSalvarLogin.Text = "Salvar";
            this.btnSalvarLogin.UseVisualStyleBackColor = false;
            this.btnSalvarLogin.Click += new System.EventHandler(this.btnSalvarLogin_Click);
            // 
            // groupDadosPessoais
            // 
            this.groupDadosPessoais.Controls.Add(this.txtSalario);
            this.groupDadosPessoais.Controls.Add(this.label1);
            this.groupDadosPessoais.Controls.Add(this.label9);
            this.groupDadosPessoais.Controls.Add(this.label8);
            this.groupDadosPessoais.Controls.Add(this.txtPassaporte);
            this.groupDadosPessoais.Controls.Add(this.comboStatusFun);
            this.groupDadosPessoais.Controls.Add(this.label7);
            this.groupDadosPessoais.Controls.Add(this.dudSexo);
            this.groupDadosPessoais.Controls.Add(this.txtCPF);
            this.groupDadosPessoais.Controls.Add(this.txtCargo);
            this.groupDadosPessoais.Controls.Add(this.label2);
            this.groupDadosPessoais.Controls.Add(this.txtTelefone);
            this.groupDadosPessoais.Controls.Add(this.lblAttHosp);
            this.groupDadosPessoais.Controls.Add(this.dtpNasc);
            this.groupDadosPessoais.Controls.Add(this.comboStatusHos);
            this.groupDadosPessoais.Controls.Add(this.label6);
            this.groupDadosPessoais.Controls.Add(this.btnLimpar);
            this.groupDadosPessoais.Controls.Add(this.txtEmail);
            this.groupDadosPessoais.Controls.Add(this.lblAttFunc);
            this.groupDadosPessoais.Controls.Add(this.btnCadastrar);
            this.groupDadosPessoais.Controls.Add(this.txtNome);
            this.groupDadosPessoais.Controls.Add(this.label11);
            this.groupDadosPessoais.Controls.Add(this.label10);
            this.groupDadosPessoais.Controls.Add(this.label3);
            this.groupDadosPessoais.Controls.Add(this.label5);
            this.groupDadosPessoais.Controls.Add(this.label17);
            this.groupDadosPessoais.Controls.Add(this.label15);
            this.groupDadosPessoais.Controls.Add(this.label4);
            this.groupDadosPessoais.ForeColor = System.Drawing.Color.White;
            this.groupDadosPessoais.Location = new System.Drawing.Point(67, 52);
            this.groupDadosPessoais.Name = "groupDadosPessoais";
            this.groupDadosPessoais.Size = new System.Drawing.Size(843, 361);
            this.groupDadosPessoais.TabIndex = 58;
            this.groupDadosPessoais.TabStop = false;
            this.groupDadosPessoais.Text = "Dados pessoais";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(601, 214);
            this.txtSalario.Mask = "0000.00";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(91, 29);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.Text = "000000";
            this.txtSalario.ValidatingType = typeof(int);
            // 
            // groupDadosLogin
            // 
            this.groupDadosLogin.Controls.Add(this.label14);
            this.groupDadosLogin.Controls.Add(this.txtSenha);
            this.groupDadosLogin.Controls.Add(this.btnSalvarLogin);
            this.groupDadosLogin.Controls.Add(this.label13);
            this.groupDadosLogin.Controls.Add(this.label12);
            this.groupDadosLogin.Controls.Add(this.lblAttLogin);
            this.groupDadosLogin.Controls.Add(this.txtNomeUsuario);
            this.groupDadosLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupDadosLogin.Location = new System.Drawing.Point(147, 432);
            this.groupDadosLogin.Name = "groupDadosLogin";
            this.groupDadosLogin.Size = new System.Drawing.Size(689, 135);
            this.groupDadosLogin.TabIndex = 59;
            this.groupDadosLogin.TabStop = false;
            this.groupDadosLogin.Text = "Dados conta funcionário:";
            // 
            // DadosFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.groupDadosLogin);
            this.Controls.Add(this.groupDadosPessoais);
            this.Controls.Add(this.btnVoltar);
            this.Name = "DadosFuncionario";
            this.Size = new System.Drawing.Size(980, 580);
            this.Load += new System.EventHandler(this.DadosFuncionario_Load);
            this.Leave += new System.EventHandler(this.DadosFuncionario_Leave);
            this.groupDadosPessoais.ResumeLayout(false);
            this.groupDadosPessoais.PerformLayout();
            this.groupDadosLogin.ResumeLayout(false);
            this.groupDadosLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassaporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAttFunc;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblAttLogin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAttHosp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboStatusHos;
        private System.Windows.Forms.ComboBox comboStatusFun;
        private System.Windows.Forms.Button btnSalvarLogin;
        private System.Windows.Forms.GroupBox groupDadosPessoais;
        private System.Windows.Forms.GroupBox groupDadosLogin;
        private System.Windows.Forms.MaskedTextBox txtSalario;
    }
}
