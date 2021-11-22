
namespace PimIV_Desktop.Telas
{
    partial class GerirConsumos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgviewConsumos = new System.Windows.Forms.DataGridView();
            this.gboxNovoConsumo = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.comboRes = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewConsumos)).BeginInit();
            this.gboxNovoConsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // dgviewConsumos
            // 
            this.dgviewConsumos.AllowUserToAddRows = false;
            this.dgviewConsumos.AllowUserToDeleteRows = false;
            this.dgviewConsumos.AllowUserToResizeColumns = false;
            this.dgviewConsumos.AllowUserToResizeRows = false;
            this.dgviewConsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewConsumos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewConsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgviewConsumos.ColumnHeadersHeight = 60;
            this.dgviewConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewConsumos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgviewConsumos.Location = new System.Drawing.Point(22, 101);
            this.dgviewConsumos.MultiSelect = false;
            this.dgviewConsumos.Name = "dgviewConsumos";
            this.dgviewConsumos.ReadOnly = true;
            this.dgviewConsumos.RowHeadersVisible = false;
            this.dgviewConsumos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgviewConsumos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgviewConsumos.RowTemplate.Height = 50;
            this.dgviewConsumos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewConsumos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgviewConsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewConsumos.Size = new System.Drawing.Size(965, 485);
            this.dgviewConsumos.TabIndex = 55;
            this.dgviewConsumos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewConsumos_CellDoubleClick);
            // 
            // gboxNovoConsumo
            // 
            this.gboxNovoConsumo.Controls.Add(this.txtValor);
            this.gboxNovoConsumo.Controls.Add(this.comboProdutos);
            this.gboxNovoConsumo.Controls.Add(this.comboRes);
            this.gboxNovoConsumo.Controls.Add(this.btnDeletar);
            this.gboxNovoConsumo.Controls.Add(this.btnAdicionar);
            this.gboxNovoConsumo.Controls.Add(this.lblTotal);
            this.gboxNovoConsumo.Controls.Add(this.label3);
            this.gboxNovoConsumo.Controls.Add(this.label2);
            this.gboxNovoConsumo.Controls.Add(this.label5);
            this.gboxNovoConsumo.Controls.Add(this.label1);
            this.gboxNovoConsumo.Controls.Add(this.nudQtde);
            this.gboxNovoConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNovoConsumo.ForeColor = System.Drawing.Color.Snow;
            this.gboxNovoConsumo.Location = new System.Drawing.Point(22, 4);
            this.gboxNovoConsumo.Name = "gboxNovoConsumo";
            this.gboxNovoConsumo.Size = new System.Drawing.Size(965, 91);
            this.gboxNovoConsumo.TabIndex = 56;
            this.gboxNovoConsumo.TabStop = false;
            this.gboxNovoConsumo.Text = "Dados do consumo";
            this.gboxNovoConsumo.Enter += new System.EventHandler(this.gboxNovoConsumo_Enter);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(668, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(99, 26);
            this.txtValor.TabIndex = 3;
            // 
            // comboProdutos
            // 
            this.comboProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(178, 47);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(299, 28);
            this.comboProdutos.TabIndex = 1;
            this.comboProdutos.SelectionChangeCommitted += new System.EventHandler(this.comboProdutos_SelectionChangeCommitted);
            // 
            // comboRes
            // 
            this.comboRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRes.FormattingEnabled = true;
            this.comboRes.Location = new System.Drawing.Point(16, 47);
            this.comboRes.Name = "comboRes";
            this.comboRes.Size = new System.Drawing.Size(132, 28);
            this.comboRes.TabIndex = 0;
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
            this.btnAdicionar.Size = new System.Drawing.Size(129, 39);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Salvar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(628, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 29);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Text = "R$ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Reserva:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Produto:";
            // 
            // nudQtde
            // 
            this.nudQtde.Enabled = false;
            this.nudQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtde.Location = new System.Drawing.Point(519, 47);
            this.nudQtde.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtde.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(53, 28);
            this.nudQtde.TabIndex = 2;
            this.nudQtde.ValueChanged += new System.EventHandler(this.nudQtde_ValueChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(833, 49);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(129, 39);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // GerirConsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.gboxNovoConsumo);
            this.Controls.Add(this.dgviewConsumos);
            this.Name = "GerirConsumos";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Leave += new System.EventHandler(this.GerirConsumos_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewConsumos)).EndInit();
            this.gboxNovoConsumo.ResumeLayout(false);
            this.gboxNovoConsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgviewConsumos;
        private System.Windows.Forms.GroupBox gboxNovoConsumo;
        private System.Windows.Forms.NumericUpDown nudQtde;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.ComboBox comboRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnDeletar;
    }
}
