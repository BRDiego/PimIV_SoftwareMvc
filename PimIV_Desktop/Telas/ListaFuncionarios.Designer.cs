
namespace PimIV_Desktop.Telas
{
    partial class ListaFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.gboxBuscaHospede = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaCPF = new System.Windows.Forms.MaskedTextBox();
            this.dgviewFuncionarios = new System.Windows.Forms.DataGridView();
            this.dadosFuncionario1 = new PimIV_Desktop.Telas.DadosFuncionario();
            this.gboxBuscaHospede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovoFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnNovoFuncionario.Location = new System.Drawing.Point(621, 27);
            this.btnNovoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(184, 45);
            this.btnNovoFuncionario.TabIndex = 1;
            this.btnNovoFuncionario.Text = "Novo funcionário";
            this.btnNovoFuncionario.UseVisualStyleBackColor = false;
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnListarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodos.ForeColor = System.Drawing.Color.White;
            this.btnListarTodos.Location = new System.Drawing.Point(806, 27);
            this.btnListarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(184, 45);
            this.btnListarTodos.TabIndex = 2;
            this.btnListarTodos.Text = "Listar todos";
            this.btnListarTodos.UseVisualStyleBackColor = false;
            // 
            // gboxBuscaHospede
            // 
            this.gboxBuscaHospede.Controls.Add(this.comboStatus);
            this.gboxBuscaHospede.Controls.Add(this.label8);
            this.gboxBuscaHospede.Controls.Add(this.btnBuscar);
            this.gboxBuscaHospede.Controls.Add(this.label1);
            this.gboxBuscaHospede.Controls.Add(this.txtBuscaCPF);
            this.gboxBuscaHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxBuscaHospede.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gboxBuscaHospede.Location = new System.Drawing.Point(32, 10);
            this.gboxBuscaHospede.Name = "gboxBuscaHospede";
            this.gboxBuscaHospede.Size = new System.Drawing.Size(584, 69);
            this.gboxBuscaHospede.TabIndex = 0;
            this.gboxBuscaHospede.TabStop = false;
            this.gboxBuscaHospede.Text = "Busca personalizada";
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.comboStatus.Location = new System.Drawing.Point(302, 25);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(144, 28);
            this.comboStatus.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(225, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Status:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(453, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 45);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "CPF:";
            // 
            // txtBuscaCPF
            // 
            this.txtBuscaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCPF.Location = new System.Drawing.Point(67, 25);
            this.txtBuscaCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscaCPF.Mask = "000,000,000-00";
            this.txtBuscaCPF.Name = "txtBuscaCPF";
            this.txtBuscaCPF.Size = new System.Drawing.Size(131, 28);
            this.txtBuscaCPF.TabIndex = 0;
            this.txtBuscaCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dgviewFuncionarios
            // 
            this.dgviewFuncionarios.AllowUserToAddRows = false;
            this.dgviewFuncionarios.AllowUserToDeleteRows = false;
            this.dgviewFuncionarios.AllowUserToResizeColumns = false;
            this.dgviewFuncionarios.AllowUserToResizeRows = false;
            this.dgviewFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewFuncionarios.ColumnHeadersHeight = 60;
            this.dgviewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgviewFuncionarios.Location = new System.Drawing.Point(32, 85);
            this.dgviewFuncionarios.MultiSelect = false;
            this.dgviewFuncionarios.Name = "dgviewFuncionarios";
            this.dgviewFuncionarios.ReadOnly = true;
            this.dgviewFuncionarios.RowHeadersVisible = false;
            this.dgviewFuncionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgviewFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgviewFuncionarios.RowTemplate.Height = 50;
            this.dgviewFuncionarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewFuncionarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgviewFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewFuncionarios.Size = new System.Drawing.Size(958, 505);
            this.dgviewFuncionarios.TabIndex = 3;
            // 
            // dadosFuncionario1
            // 
            this.dadosFuncionario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dadosFuncionario1.Location = new System.Drawing.Point(10, 10);
            this.dadosFuncionario1.Name = "dadosFuncionario1";
            this.dadosFuncionario1.Size = new System.Drawing.Size(980, 580);
            this.dadosFuncionario1.TabIndex = 57;
            this.dadosFuncionario1.Visible = false;
            // 
            // ListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnNovoFuncionario);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.gboxBuscaHospede);
            this.Controls.Add(this.dgviewFuncionarios);
            this.Controls.Add(this.dadosFuncionario1);
            this.Name = "ListaFuncionarios";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Leave += new System.EventHandler(this.ListaFuncionarios_Leave);
            this.gboxBuscaHospede.ResumeLayout(false);
            this.gboxBuscaHospede.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoFuncionario;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.GroupBox gboxBuscaHospede;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBuscaCPF;
        private System.Windows.Forms.DataGridView dgviewFuncionarios;
        private DadosFuncionario dadosFuncionario1;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label8;
    }
}
