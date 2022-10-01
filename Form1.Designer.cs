
namespace Splines
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.run_neibourg = new System.Windows.Forms.Button();
            this.run_cubic = new System.Windows.Forms.Button();
            this.run_cosine = new System.Windows.Forms.Button();
            this.run_linear = new System.Windows.Forms.Button();
            this.add_point = new System.Windows.Forms.Button();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.run_neibourg);
            this.panel1.Controls.Add(this.run_cubic);
            this.panel1.Controls.Add(this.run_cosine);
            this.panel1.Controls.Add(this.run_linear);
            this.panel1.Controls.Add(this.add_point);
            this.panel1.Controls.Add(this.txt_x);
            this.panel1.Controls.Add(this.txt_y);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 100);
            this.panel1.TabIndex = 1;
            // 
            // run_neibourg
            // 
            this.run_neibourg.Location = new System.Drawing.Point(500, 4);
            this.run_neibourg.Name = "run_neibourg";
            this.run_neibourg.Size = new System.Drawing.Size(35, 23);
            this.run_neibourg.TabIndex = 10;
            this.run_neibourg.Text = "button5";
            this.run_neibourg.UseVisualStyleBackColor = true;
            this.run_neibourg.Click += new System.EventHandler(this.run_neibourg_Click);
            // 
            // run_cubic
            // 
            this.run_cubic.Location = new System.Drawing.Point(369, 4);
            this.run_cubic.Name = "run_cubic";
            this.run_cubic.Size = new System.Drawing.Size(35, 23);
            this.run_cubic.TabIndex = 9;
            this.run_cubic.Text = "button4";
            this.run_cubic.UseVisualStyleBackColor = true;
            this.run_cubic.Click += new System.EventHandler(this.run_cubic_Click);
            // 
            // run_cosine
            // 
            this.run_cosine.Location = new System.Drawing.Point(226, 4);
            this.run_cosine.Name = "run_cosine";
            this.run_cosine.Size = new System.Drawing.Size(35, 23);
            this.run_cosine.TabIndex = 8;
            this.run_cosine.Text = "button3";
            this.run_cosine.UseVisualStyleBackColor = true;
            this.run_cosine.Click += new System.EventHandler(this.run_cosine_Click);
            // 
            // run_linear
            // 
            this.run_linear.Location = new System.Drawing.Point(63, 4);
            this.run_linear.Name = "run_linear";
            this.run_linear.Size = new System.Drawing.Size(35, 23);
            this.run_linear.TabIndex = 7;
            this.run_linear.Text = "button2";
            this.run_linear.UseVisualStyleBackColor = true;
            this.run_linear.Click += new System.EventHandler(this.run_linear_Click);
            // 
            // add_point
            // 
            this.add_point.Location = new System.Drawing.Point(130, 64);
            this.add_point.Name = "add_point";
            this.add_point.Size = new System.Drawing.Size(35, 23);
            this.add_point.TabIndex = 6;
            this.add_point.Text = "button1";
            this.add_point.UseVisualStyleBackColor = true;
            this.add_point.Click += new System.EventHandler(this.add_point_Click);
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(24, 55);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 20);
            this.txt_x.TabIndex = 5;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(24, 77);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 20);
            this.txt_y.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(444, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Neibourg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cosine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(329, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cubic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linear";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Firebrick;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 100);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1290, 542);
            this.canvas.TabIndex = 2;
            this.canvas.RegionChanged += new System.EventHandler(this.canvas_RegionChanged);
            this.canvas.Resize += new System.EventHandler(this.canvas_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 642);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Spline Interpolation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button run_neibourg;
        private System.Windows.Forms.Button run_cubic;
        private System.Windows.Forms.Button run_cosine;
        private System.Windows.Forms.Button run_linear;
        private System.Windows.Forms.Button add_point;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Panel canvas;
    }
}

