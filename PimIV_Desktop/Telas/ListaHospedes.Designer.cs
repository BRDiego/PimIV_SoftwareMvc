
namespace PimIV_Desktop.Telas
{
    partial class ListaHospedes
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
            this.dgviewHospedes = new System.Windows.Forms.DataGridView();
            this.txtBuscaCPF = new System.Windows.Forms.MaskedTextBox();
            this.gboxBuscaHospede = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoHospede = new System.Windows.Forms.Button();
            this.dadosHospede1 = new PimIV_Desktop.Telas.DadosHospede();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewHospedes)).BeginInit();
            this.gboxBuscaHospede.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgviewHospedes
            // 
            this.dgviewHospedes.AllowUserToAddRows = false;
            this.dgviewHospedes.AllowUserToDeleteRows = false;
            this.dgviewHospedes.AllowUserToResizeColumns = false;
            this.dgviewHospedes.AllowUserToResizeRows = false;
            this.dgviewHospedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewHospedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewHospedes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewHospedes.ColumnHeadersHeight = 60;
            this.dgviewHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewHospedes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgviewHospedes.Location = new System.Drawing.Point(30, 91);
            this.dgviewHospedes.MultiSelect = false;
            this.dgviewHospedes.Name = "dgviewHospedes";
            this.dgviewHospedes.ReadOnly = true;
            this.dgviewHospedes.RowHeadersVisible = false;
            this.dgviewHospedes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgviewHospedes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgviewHospedes.RowTemplate.Height = 50;
            this.dgviewHospedes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewHospedes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgviewHospedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgviewHospedes.Size = new System.Drawing.Size(959, 496);
            this.dgviewHospedes.TabIndex = 3;
            // 
            // txtBuscaCPF
            // 
            this.txtBuscaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCPF.Location = new System.Drawing.Point(73, 31);
            this.txtBuscaCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscaCPF.Mask = "000,000,000-00";
            this.txtBuscaCPF.Name = "txtBuscaCPF";
            this.txtBuscaCPF.Size = new System.Drawing.Size(139, 28);
            this.txtBuscaCPF.TabIndex = 0;
            this.txtBuscaCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.gboxBuscaHospede.Location = new System.Drawing.Point(30, 7);
            this.gboxBuscaHospede.Name = "gboxBuscaHospede";
            this.gboxBuscaHospede.Size = new System.Drawing.Size(601, 78);
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
            this.comboStatus.Location = new System.Drawing.Point(310, 31);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(144, 28);
            this.comboStatus.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(233, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Status:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(471, 21);
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
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "CPF:";
            // 
            // btnNovoHospede
            // 
            this.btnNovoHospede.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovoHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoHospede.ForeColor = System.Drawing.Color.White;
            this.btnNovoHospede.Location = new System.Drawing.Point(639, 30);
            this.btnNovoHospede.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoHospede.Name = "btnNovoHospede";
            this.btnNovoHospede.Size = new System.Drawing.Size(173, 45);
            this.btnNovoHospede.TabIndex = 1;
            this.btnNovoHospede.Text = "Novo hóspede";
            this.btnNovoHospede.UseVisualStyleBackColor = false;
            this.btnNovoHospede.Click += new System.EventHandler(this.btnNovoHospede_Click);
            // 
            // dadosHospede1
            // 
            this.dadosHospede1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dadosHospede1.Location = new System.Drawing.Point(10, 10);
            this.dadosHospede1.Name = "dadosHospede1";
            this.dadosHospede1.Size = new System.Drawing.Size(980, 580);
            this.dadosHospede1.TabIndex = 4;
            this.dadosHospede1.TabStop = false;
            this.dadosHospede1.Visible = false;
            // 
            // ListaHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnNovoHospede);
            this.Controls.Add(this.gboxBuscaHospede);
            this.Controls.Add(this.dgviewHospedes);
            this.Controls.Add(this.dadosHospede1);
            this.Name = "ListaHospedes";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Enter += new System.EventHandler(this.ListaHospedes_Enter);
            this.Leave += new System.EventHandler(this.ListaHospedes_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewHospedes)).EndInit();
            this.gboxBuscaHospede.ResumeLayout(false);
            this.gboxBuscaHospede.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgviewHospedes;
        private System.Windows.Forms.MaskedTextBox txtBuscaCPF;
        private System.Windows.Forms.GroupBox gboxBuscaHospede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNovoHospede;
        private DadosHospede dadosHospede1;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label8;
    }
}
