
namespace PimIV_Desktop.Telas
{
    partial class GerirProdutos
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
            this.gboxNovoConsumo = new System.Windows.Forms.GroupBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.dgviewProdutos = new System.Windows.Forms.DataGridView();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxNovoConsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxNovoConsumo
            // 
            this.gboxNovoConsumo.Controls.Add(this.dtpValidade);
            this.gboxNovoConsumo.Controls.Add(this.lblTotal);
            this.gboxNovoConsumo.Controls.Add(this.txtValor);
            this.gboxNovoConsumo.Controls.Add(this.txtNome);
            this.gboxNovoConsumo.Controls.Add(this.btnDeletar);
            this.gboxNovoConsumo.Controls.Add(this.btnAdicionar);
            this.gboxNovoConsumo.Controls.Add(this.label3);
            this.gboxNovoConsumo.Controls.Add(this.label2);
            this.gboxNovoConsumo.Controls.Add(this.label5);
            this.gboxNovoConsumo.Controls.Add(this.label1);
            this.gboxNovoConsumo.Controls.Add(this.nudQtde);
            this.gboxNovoConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNovoConsumo.ForeColor = System.Drawing.Color.Snow;
            this.gboxNovoConsumo.Location = new System.Drawing.Point(18, 9);
            this.gboxNovoConsumo.Name = "gboxNovoConsumo";
            this.gboxNovoConsumo.Size = new System.Drawing.Size(965, 88);
            this.gboxNovoConsumo.TabIndex = 58;
            this.gboxNovoConsumo.TabStop = false;
            this.gboxNovoConsumo.Text = "Dados do produto";
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(653, 45);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(121, 26);
            this.dtpValidade.TabIndex = 65;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(282, 45);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 29);
            this.lblTotal.TabIndex = 64;
            this.lblTotal.Text = "R$ ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(337, 47);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(99, 26);
            this.txtValor.TabIndex = 63;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(236, 26);
            this.txtNome.TabIndex = 63;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(832, 48);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(129, 38);
            this.btnDeletar.TabIndex = 60;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Visible = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(832, 10);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(129, 38);
            this.btnAdicionar.TabIndex = 60;
            this.btnAdicionar.Text = "Salvar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Validade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Nome do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Valor:";
            // 
            // nudQtde
            // 
            this.nudQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtde.Location = new System.Drawing.Point(519, 46);
            this.nudQtde.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtde.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudQtde.Size = new System.Drawing.Size(53, 28);
            this.nudQtde.TabIndex = 57;
            // 
            // dgviewProdutos
            // 
            this.dgviewProdutos.AllowUserToAddRows = false;
            this.dgviewProdutos.AllowUserToDeleteRows = false;
            this.dgviewProdutos.AllowUserToResizeColumns = false;
            this.dgviewProdutos.AllowUserToResizeRows = false;
            this.dgviewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewProdutos.ColumnHeadersHeight = 60;
            this.dgviewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgviewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProduto,
            this.PrecoProduto,
            this.QuantidadeProduto,
            this.ValidadeProduto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgviewProdutos.Location = new System.Drawing.Point(18, 103);
            this.dgviewProdutos.MultiSelect = false;
            this.dgviewProdutos.Name = "dgviewProdutos";
            this.dgviewProdutos.ReadOnly = true;
            this.dgviewProdutos.RowHeadersVisible = false;
            this.dgviewProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgviewProdutos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgviewProdutos.RowTemplate.Height = 50;
            this.dgviewProdutos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgviewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewProdutos.Size = new System.Drawing.Size(965, 488);
            this.dgviewProdutos.TabIndex = 57;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // PrecoProduto
            // 
            this.PrecoProduto.HeaderText = "Preço";
            this.PrecoProduto.Name = "PrecoProduto";
            this.PrecoProduto.ReadOnly = true;
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.HeaderText = "Qtde";
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.ReadOnly = true;
            // 
            // ValidadeProduto
            // 
            this.ValidadeProduto.HeaderText = "Validade";
            this.ValidadeProduto.Name = "ValidadeProduto";
            this.ValidadeProduto.ReadOnly = true;
            // 
            // GerirProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.gboxNovoConsumo);
            this.Controls.Add(this.dgviewProdutos);
            this.Name = "GerirProdutos";
            this.Size = new System.Drawing.Size(1000, 600);
            this.gboxNovoConsumo.ResumeLayout(false);
            this.gboxNovoConsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxNovoConsumo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQtde;
        private System.Windows.Forms.DataGridView dgviewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidadeProduto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpValidade;
    }
}
