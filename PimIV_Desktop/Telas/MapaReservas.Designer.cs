
namespace PimIV_Desktop.Telas
{
    partial class MapaReservas
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
            this.dgviewReservas = new System.Windows.Forms.DataGridView();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.dtpChin = new System.Windows.Forms.DateTimePicker();
            this.dtpChout = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.checkChout = new System.Windows.Forms.CheckBox();
            this.checkChin = new System.Windows.Forms.CheckBox();
            this.verReserva1 = new PimIV_Desktop.Telas.VerReserva();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgviewReservas
            // 
            this.dgviewReservas.AllowUserToAddRows = false;
            this.dgviewReservas.AllowUserToDeleteRows = false;
            this.dgviewReservas.AllowUserToResizeColumns = false;
            this.dgviewReservas.AllowUserToResizeRows = false;
            this.dgviewReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewReservas.ColumnHeadersHeight = 60;
            this.dgviewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgviewReservas.Location = new System.Drawing.Point(31, 73);
            this.dgviewReservas.MultiSelect = false;
            this.dgviewReservas.Name = "dgviewReservas";
            this.dgviewReservas.ReadOnly = true;
            this.dgviewReservas.RowHeadersVisible = false;
            this.dgviewReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgviewReservas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgviewReservas.RowTemplate.Height = 50;
            this.dgviewReservas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewReservas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgviewReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewReservas.Size = new System.Drawing.Size(937, 522);
            this.dgviewReservas.TabIndex = 0;
            this.dgviewReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewReservas_CellDoubleClick);
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.Enabled = false;
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "RESERVADA",
            "INICIADA",
            "FINALIZADA",
            "CANCELADA"});
            this.comboStatus.Location = new System.Drawing.Point(115, 42);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(179, 28);
            this.comboStatus.TabIndex = 64;
            // 
            // dtpChin
            // 
            this.dtpChin.Checked = false;
            this.dtpChin.Enabled = false;
            this.dtpChin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChin.Location = new System.Drawing.Point(410, 44);
            this.dtpChin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpChin.Name = "dtpChin";
            this.dtpChin.Size = new System.Drawing.Size(114, 26);
            this.dtpChin.TabIndex = 66;
            // 
            // dtpChout
            // 
            this.dtpChout.Checked = false;
            this.dtpChout.Enabled = false;
            this.dtpChout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChout.Location = new System.Drawing.Point(690, 44);
            this.dtpChout.Margin = new System.Windows.Forms.Padding(2);
            this.dtpChout.Name = "dtpChout";
            this.dtpChout.Size = new System.Drawing.Size(114, 26);
            this.dtpChout.TabIndex = 66;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(839, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 39);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Busca por:";
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStatus.ForeColor = System.Drawing.Color.White;
            this.checkStatus.Location = new System.Drawing.Point(31, 44);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(79, 24);
            this.checkStatus.TabIndex = 68;
            this.checkStatus.Text = "Status:";
            this.checkStatus.UseVisualStyleBackColor = true;
            this.checkStatus.CheckedChanged += new System.EventHandler(this.checkStatus_CheckedChanged);
            // 
            // checkChout
            // 
            this.checkChout.AutoSize = true;
            this.checkChout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkChout.ForeColor = System.Drawing.Color.White;
            this.checkChout.Location = new System.Drawing.Point(582, 46);
            this.checkChout.Name = "checkChout";
            this.checkChout.Size = new System.Drawing.Size(103, 24);
            this.checkChout.TabIndex = 68;
            this.checkChout.Text = "CheckOut:";
            this.checkChout.UseVisualStyleBackColor = true;
            this.checkChout.CheckedChanged += new System.EventHandler(this.checkChout_CheckedChanged);
            // 
            // checkChin
            // 
            this.checkChin.AutoSize = true;
            this.checkChin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkChin.ForeColor = System.Drawing.Color.White;
            this.checkChin.Location = new System.Drawing.Point(315, 46);
            this.checkChin.Name = "checkChin";
            this.checkChin.Size = new System.Drawing.Size(91, 24);
            this.checkChin.TabIndex = 68;
            this.checkChin.Text = "CheckIn:";
            this.checkChin.UseVisualStyleBackColor = true;
            this.checkChin.CheckedChanged += new System.EventHandler(this.checkChin_CheckedChanged);
            // 
            // verReserva1
            // 
            this.verReserva1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.verReserva1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verReserva1.Location = new System.Drawing.Point(0, 0);
            this.verReserva1.Name = "verReserva1";
            this.verReserva1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.verReserva1.Size = new System.Drawing.Size(997, 597);
            this.verReserva1.TabIndex = 1;
            this.verReserva1.Visible = false;
            // 
            // MapaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.checkChin);
            this.Controls.Add(this.checkChout);
            this.Controls.Add(this.checkStatus);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpChout);
            this.Controls.Add(this.dtpChin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.dgviewReservas);
            this.Controls.Add(this.verReserva1);
            this.Name = "MapaReservas";
            this.Size = new System.Drawing.Size(1000, 600);
            this.VisibleChanged += new System.EventHandler(this.MapaReservas_VisibleChanged);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MapaReservas_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgviewReservas;
        private VerReserva verReserva1;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.DateTimePicker dtpChin;
        private System.Windows.Forms.DateTimePicker dtpChout;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.CheckBox checkChout;
        private System.Windows.Forms.CheckBox checkChin;
    }
}
