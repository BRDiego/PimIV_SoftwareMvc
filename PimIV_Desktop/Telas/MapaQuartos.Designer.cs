
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAlterarStatus = new System.Windows.Forms.Button();
            this.dgviewQuartos = new System.Windows.Forms.DataGridView();
            this.panelAcoesQuarto = new System.Windows.Forms.Panel();
            this.comboAlterar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.btnAlterarStatus.Location = new System.Drawing.Point(210, 0);
            this.btnAlterarStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarStatus.Name = "btnAlterarStatus";
            this.btnAlterarStatus.Size = new System.Drawing.Size(163, 45);
            this.btnAlterarStatus.TabIndex = 53;
            this.btnAlterarStatus.Text = "Alterar status";
            this.btnAlterarStatus.UseVisualStyleBackColor = false;
            this.btnAlterarStatus.Click += new System.EventHandler(this.btnAlterarStatus_Click);
            // 
            // dgviewQuartos
            // 
            this.dgviewQuartos.AllowUserToAddRows = false;
            this.dgviewQuartos.AllowUserToDeleteRows = false;
            this.dgviewQuartos.AllowUserToResizeColumns = false;
            this.dgviewQuartos.AllowUserToResizeRows = false;
            this.dgviewQuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewQuartos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgviewQuartos.ColumnHeadersHeight = 60;
            this.dgviewQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewQuartos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgviewQuartos.Location = new System.Drawing.Point(18, 75);
            this.dgviewQuartos.MultiSelect = false;
            this.dgviewQuartos.Name = "dgviewQuartos";
            this.dgviewQuartos.ReadOnly = true;
            this.dgviewQuartos.RowHeadersVisible = false;
            this.dgviewQuartos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgviewQuartos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgviewQuartos.RowTemplate.Height = 50;
            this.dgviewQuartos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewQuartos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgviewQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewQuartos.Size = new System.Drawing.Size(965, 508);
            this.dgviewQuartos.TabIndex = 54;
            this.dgviewQuartos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewQuartos_CellDoubleClick);
            // 
            // panelAcoesQuarto
            // 
            this.panelAcoesQuarto.Controls.Add(this.btnAlterarStatus);
            this.panelAcoesQuarto.Controls.Add(this.comboAlterar);
            this.panelAcoesQuarto.Enabled = false;
            this.panelAcoesQuarto.Location = new System.Drawing.Point(500, 22);
            this.panelAcoesQuarto.Name = "panelAcoesQuarto";
            this.panelAcoesQuarto.Size = new System.Drawing.Size(382, 47);
            this.panelAcoesQuarto.TabIndex = 55;
            this.panelAcoesQuarto.EnabledChanged += new System.EventHandler(this.panelAcoesQuarto_EnabledChanged);
            // 
            // comboAlterar
            // 
            this.comboAlterar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAlterar.FormattingEnabled = true;
            this.comboAlterar.Location = new System.Drawing.Point(3, 10);
            this.comboAlterar.Name = "comboAlterar";
            this.comboAlterar.Size = new System.Drawing.Size(179, 28);
            this.comboAlterar.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(74, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 24);
            this.label9.TabIndex = 56;
            this.label9.Text = "Clique em um quarto para alterar seu status:";
            // 
            // MapaQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelAcoesQuarto);
            this.Controls.Add(this.dgviewQuartos);
            this.Name = "MapaQuartos";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Enter += new System.EventHandler(this.MapaQuartos_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewQuartos)).EndInit();
            this.panelAcoesQuarto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarStatus;
        private System.Windows.Forms.DataGridView dgviewQuartos;
        private System.Windows.Forms.Panel panelAcoesQuarto;
        private System.Windows.Forms.ComboBox comboAlterar;
        private System.Windows.Forms.Label label9;
    }
}
