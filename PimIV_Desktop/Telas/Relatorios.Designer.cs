
namespace PimIV_Desktop.Telas
{
    partial class Relatorios
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOcup = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOcup = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageFinan = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageOcup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocupação atual:";
            // 
            // lblOcup
            // 
            this.lblOcup.AutoSize = true;
            this.lblOcup.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcup.ForeColor = System.Drawing.Color.White;
            this.lblOcup.Location = new System.Drawing.Point(44, 62);
            this.lblOcup.Name = "lblOcup";
            this.lblOcup.Size = new System.Drawing.Size(167, 76);
            this.lblOcup.TabIndex = 0;
            this.lblOcup.Text = "50%";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOcup);
            this.tabControl1.Controls.Add(this.tabPageFinan);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 594);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageOcup
            // 
            this.tabPageOcup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tabPageOcup.Controls.Add(this.label5);
            this.tabPageOcup.Controls.Add(this.label4);
            this.tabPageOcup.Controls.Add(this.lblOcup);
            this.tabPageOcup.Controls.Add(this.label2);
            this.tabPageOcup.Controls.Add(this.label3);
            this.tabPageOcup.Controls.Add(this.label1);
            this.tabPageOcup.Location = new System.Drawing.Point(4, 34);
            this.tabPageOcup.Name = "tabPageOcup";
            this.tabPageOcup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOcup.Size = new System.Drawing.Size(986, 556);
            this.tabPageOcup.TabIndex = 0;
            this.tabPageOcup.Text = "Ocupação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 76);
            this.label5.TabIndex = 0;
            this.label5.Text = "2/12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 76);
            this.label4.TabIndex = 0;
            this.label4.Text = "5/10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Entradas de hoje\r\n(Check-In):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saídas de hoje\r\n(Check-Out):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPageFinan
            // 
            this.tabPageFinan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tabPageFinan.Location = new System.Drawing.Point(4, 34);
            this.tabPageFinan.Name = "tabPageFinan";
            this.tabPageFinan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinan.Size = new System.Drawing.Size(986, 556);
            this.tabPageFinan.TabIndex = 1;
            this.tabPageFinan.Text = "Finanças";
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.tabControl1);
            this.Name = "Relatorios";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Relatorios_Layout);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOcup.ResumeLayout(false);
            this.tabPageOcup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOcup;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOcup;
        private System.Windows.Forms.TabPage tabPageFinan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
