namespace WFA_KostebekOyunu
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSkor = new System.Windows.Forms.Label();
            this.pnlYuva = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDuraklatDevamet = new System.Windows.Forms.Button();
            this.btnYenidenBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSkor
            // 
            this.lblSkor.BackColor = System.Drawing.Color.Wheat;
            this.lblSkor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSkor.Font = new System.Drawing.Font("Ravie", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.Location = new System.Drawing.Point(249, 5);
            this.lblSkor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(362, 102);
            this.lblSkor.TabIndex = 2;
            this.lblSkor.Text = "PUAN\r\n0";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlYuva
            // 
            this.pnlYuva.BackColor = System.Drawing.Color.Maroon;
            this.pnlYuva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYuva.Location = new System.Drawing.Point(12, 174);
            this.pnlYuva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlYuva.Name = "pnlYuva";
            this.pnlYuva.Size = new System.Drawing.Size(618, 634);
            this.pnlYuva.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblSkor);
            this.panel3.Controls.Add(this.btnDuraklatDevamet);
            this.panel3.Controls.Add(this.btnYenidenBasla);
            this.panel3.Location = new System.Drawing.Point(12, 48);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 116);
            this.panel3.TabIndex = 5;
            // 
            // btnDuraklatDevamet
            // 
            this.btnDuraklatDevamet.BackgroundImage = global::WFA_KostebekOyunu.Properties.Resources.Play;
            this.btnDuraklatDevamet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDuraklatDevamet.Location = new System.Drawing.Point(4, 5);
            this.btnDuraklatDevamet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDuraklatDevamet.Name = "btnDuraklatDevamet";
            this.btnDuraklatDevamet.Size = new System.Drawing.Size(112, 103);
            this.btnDuraklatDevamet.TabIndex = 0;
            this.btnDuraklatDevamet.UseVisualStyleBackColor = true;
            this.btnDuraklatDevamet.Click += new System.EventHandler(this.BtnDuraklatDevamet_Click);
            // 
            // btnYenidenBasla
            // 
            this.btnYenidenBasla.BackgroundImage = global::WFA_KostebekOyunu.Properties.Resources.Replay;
            this.btnYenidenBasla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYenidenBasla.Enabled = false;
            this.btnYenidenBasla.Location = new System.Drawing.Point(126, 5);
            this.btnYenidenBasla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYenidenBasla.Name = "btnYenidenBasla";
            this.btnYenidenBasla.Size = new System.Drawing.Size(114, 103);
            this.btnYenidenBasla.TabIndex = 0;
            this.btnYenidenBasla.UseVisualStyleBackColor = true;
            this.btnYenidenBasla.Click += new System.EventHandler(this.BtnYenidenBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(606, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(644, 820);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlYuva);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDuraklatDevamet;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Button btnYenidenBasla;
        private System.Windows.Forms.Panel pnlYuva;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

