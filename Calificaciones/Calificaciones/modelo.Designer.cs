namespace Calificaciones
{
    partial class modelo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.U1txt = new System.Windows.Forms.TextBox();
            this.U2txt = new System.Windows.Forms.TextBox();
            this.U3txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "controlador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombretxt
            // 
            this.nombretxt.AccessibleName = "";
            this.nombretxt.Location = new System.Drawing.Point(49, 77);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(84, 20);
            this.nombretxt.TabIndex = 2;
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(159, 77);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(100, 20);
            this.apellidotxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(185, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Registar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // U1txt
            // 
            this.U1txt.AccessibleName = "";
            this.U1txt.Location = new System.Drawing.Point(278, 77);
            this.U1txt.Name = "U1txt";
            this.U1txt.Size = new System.Drawing.Size(84, 20);
            this.U1txt.TabIndex = 8;
            // 
            // U2txt
            // 
            this.U2txt.AccessibleName = "";
            this.U2txt.Location = new System.Drawing.Point(379, 77);
            this.U2txt.Name = "U2txt";
            this.U2txt.Size = new System.Drawing.Size(84, 20);
            this.U2txt.TabIndex = 9;
            // 
            // U3txt
            // 
            this.U3txt.AccessibleName = "";
            this.U3txt.Location = new System.Drawing.Point(483, 77);
            this.U3txt.Name = "U3txt";
            this.U3txt.Size = new System.Drawing.Size(84, 20);
            this.U3txt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(294, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "U1";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(394, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "U2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(505, 55);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "U3";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Registrar calificacion";
            // 
            // modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 211);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.U3txt);
            this.Controls.Add(this.U2txt);
            this.Controls.Add(this.U1txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellidotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "modelo";
            this.Text = "modelo";
            this.Load += new System.EventHandler(this.modelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox apellidotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox U1txt;
        private System.Windows.Forms.TextBox U2txt;
        private System.Windows.Forms.TextBox U3txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}