
namespace PimIV_Desktop.Telas
{
    partial class MapaQuartos
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
            this.btnAlterarStatus = new System.Windows.Forms.Button();
            this.btnNovoConsumo = new System.Windows.Forms.Button();
            this.dgviewQuartos = new System.Windows.Forms.DataGridView();
            this.ReservaQuartos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospedeQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAcoesQuarto = new System.Windows.Forms.Panel();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dudQuartos = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewQuartos)).BeginInit();
            this.panelAcoesQuarto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterarStatus
            // 
            this.btnAlterarStatus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAlterarStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarStatus.ForeColor = System.Drawing.Color.White;
            this.btnAlterarStatus.Location = new System.Drawing.Point(-1, -1);
            this.btnAlterarStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarStatus.Name = "btnAlterarStatus";
            this.btnAlterarStatus.Size = new System.Drawing.Size(163, 45);
            this.btnAlterarStatus.TabIndex = 53;
            this.btnAlterarStatus.Text = "Alterar status";
            this.btnAlterarStatus.UseVisualStyleBackColor = false;
            // 
            // btnNovoConsumo
            // 
            this.btnNovoConsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovoConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoConsumo.ForeColor = System.Drawing.Color.White;
            this.btnNovoConsumo.Location = new System.Drawing.Point(179, -1);
            this.btnNovoConsumo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoConsumo.Name = "btnNovoConsumo";
            this.btnNovoConsumo.Size = new System.Drawing.Size(163, 45);
            this.btnNovoConsumo.TabIndex = 53;
            this.btnNovoConsumo.Text = "Novo consumo";
            this.btnNovoConsumo.UseVisualStyleBackColor = false;
            this.btnNovoConsumo.Click += new System.EventHandler(this.btnNovoConsumo_Click);
            // 
            // dgviewQuartos
            // 
            this.dgviewQuartos.AllowUserToAddRows = false;
            this.dgviewQuartos.AllowUserToDeleteRows = false;
            this.dgviewQuartos.AllowUserToResizeColumns = false;
            this.dgviewQuartos.AllowUserToResizeRows = false;
            this.dgviewQuartos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewQuartos.ColumnHeadersHeight = 60;
            this.dgviewQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgviewQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservaQuartos,
            this.NumeroQuarto,
            this.StatusQuarto,
            this.TipoQuarto,
            this.HospedeQuarto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewQuartos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgviewQuartos.Location = new System.Drawing.Point(18, 75);
            this.dgviewQuartos.MultiSelect = false;
            this.dgviewQuartos.Name = "dgviewQuartos";
            this.dgviewQuartos.ReadOnly = true;
            this.dgviewQuartos.RowHeadersVisible = false;
            this.dgviewQuartos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgviewQuartos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgviewQuartos.RowTemplate.Height = 50;
            this.dgviewQuartos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewQuartos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgviewQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewQuartos.Size = new System.Drawing.Size(965, 508);
            this.dgviewQuartos.TabIndex = 54;
            this.dgviewQuartos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewQuartos_CellClick);
            this.dgviewQuartos.Leave += new System.EventHandler(this.dgviewReservas_Leave);
            // 
            // ReservaQuartos
            // 
            this.ReservaQuartos.HeaderText = "Reserva";
            this.ReservaQuartos.Name = "ReservaQuartos";
            this.ReservaQuartos.ReadOnly = true;
            // 
            // NumeroQuarto
            // 
            this.NumeroQuarto.FillWeight = 223.3503F;
            this.NumeroQuarto.HeaderText = "Quarto";
            this.NumeroQuarto.Name = "NumeroQuarto";
            this.NumeroQuarto.ReadOnly = true;
            // 
            // StatusQuarto
            // 
            this.StatusQuarto.FillWeight = 58.88325F;
            this.StatusQuarto.HeaderText = "Status";
            this.StatusQuarto.Name = "StatusQuarto";
            this.StatusQuarto.ReadOnly = true;
            this.StatusQuarto.Width = 120;
            // 
            // TipoQuarto
            // 
            this.TipoQuarto.FillWeight = 58.88325F;
            this.TipoQuarto.HeaderText = "Tipo";
            this.TipoQuarto.Name = "TipoQuarto";
            this.TipoQuarto.ReadOnly = true;
            this.TipoQuarto.Width = 250;
            // 
            // HospedeQuarto
            // 
            this.HospedeQuarto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HospedeQuarto.FillWeight = 58.88325F;
            this.HospedeQuarto.HeaderText = "Hóspede";
            this.HospedeQuarto.Name = "HospedeQuarto";
            this.HospedeQuarto.ReadOnly = true;
            // 
            // panelAcoesQuarto
            // 
            this.panelAcoesQuarto.Controls.Add(this.btnAlterarStatus);
            this.panelAcoesQuarto.Controls.Add(this.btnNovoConsumo);
            this.panelAcoesQuarto.Enabled = false;
            this.panelAcoesQuarto.Location = new System.Drawing.Point(639, 22);
            this.panelAcoesQuarto.Name = "panelAcoesQuarto";
            this.panelAcoesQuarto.Size = new System.Drawing.Size(344, 47);
            this.panelAcoesQuarto.TabIndex = 55;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.comboStatus.Location = new System.Drawing.Point(102, 31);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(179, 28);
            this.comboStatus.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tipo:";
            // 
            // dudQuartos
            // 
            this.dudQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudQuartos.Location = new System.Drawing.Point(377, 33);
            this.dudQuartos.Margin = new System.Windows.Forms.Padding(2);
            this.dudQuartos.Name = "dudQuartos";
            this.dudQuartos.Size = new System.Drawing.Size(214, 28);
            this.dudQuartos.TabIndex = 64;
            // 
            // MapaQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.dudQuartos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.panelAcoesQuarto);
            this.Controls.Add(this.dgviewQuartos);
            this.Name = "MapaQuartos";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.MapaQuartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewQuartos)).EndInit();
            this.panelAcoesQuarto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarStatus;
        private System.Windows.Forms.Button btnNovoConsumo;
        private System.Windows.Forms.DataGridView dgviewQuartos;
        private System.Windows.Forms.Panel panelAcoesQuarto;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservaQuartos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospedeQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudQuartos;
    }
}
