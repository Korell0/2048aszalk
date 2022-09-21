
namespace _2048
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fel = new System.Windows.Forms.Button();
            this.balra = new System.Windows.Forms.Button();
            this.le = new System.Windows.Forms.Button();
            this.jobbra = new System.Windows.Forms.Button();
            this.wasd = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Progressus = new System.Windows.Forms.Label();
            this.pont = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.X4 = new System.Windows.Forms.Button();
            this.X5 = new System.Windows.Forms.Button();
            this.X6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fel
            // 
            this.fel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fel.Location = new System.Drawing.Point(517, 131);
            this.fel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fel.Name = "fel";
            this.fel.Size = new System.Drawing.Size(66, 56);
            this.fel.TabIndex = 25;
            this.fel.Text = "Up";
            this.fel.UseVisualStyleBackColor = true;
            this.fel.Visible = false;
            this.fel.Click += new System.EventHandler(this.fel_Click);
            // 
            // balra
            // 
            this.balra.BackColor = System.Drawing.Color.Transparent;
            this.balra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balra.Location = new System.Drawing.Point(435, 202);
            this.balra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.balra.Name = "balra";
            this.balra.Size = new System.Drawing.Size(66, 56);
            this.balra.TabIndex = 26;
            this.balra.Text = "Left";
            this.balra.UseVisualStyleBackColor = false;
            this.balra.Visible = false;
            this.balra.Click += new System.EventHandler(this.balra_Click);
            // 
            // le
            // 
            this.le.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.le.Cursor = System.Windows.Forms.Cursors.Hand;
            this.le.Location = new System.Drawing.Point(517, 271);
            this.le.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.le.Name = "le";
            this.le.Size = new System.Drawing.Size(66, 56);
            this.le.TabIndex = 27;
            this.le.Text = "Down";
            this.le.UseVisualStyleBackColor = true;
            this.le.Visible = false;
            this.le.Click += new System.EventHandler(this.le_Click);
            // 
            // jobbra
            // 
            this.jobbra.BackColor = System.Drawing.Color.Transparent;
            this.jobbra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jobbra.Location = new System.Drawing.Point(599, 202);
            this.jobbra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jobbra.Name = "jobbra";
            this.jobbra.Size = new System.Drawing.Size(66, 56);
            this.jobbra.TabIndex = 28;
            this.jobbra.Text = "Right";
            this.jobbra.UseVisualStyleBackColor = false;
            this.jobbra.Visible = false;
            this.jobbra.Click += new System.EventHandler(this.jobbra_Click);
            // 
            // wasd
            // 
            this.wasd.BackColor = System.Drawing.Color.Transparent;
            this.wasd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wasd.Location = new System.Drawing.Point(3, 4);
            this.wasd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wasd.Name = "wasd";
            this.wasd.Size = new System.Drawing.Size(88, 75);
            this.wasd.TabIndex = 29;
            this.wasd.Text = "WASD";
            this.wasd.UseVisualStyleBackColor = false;
            this.wasd.Visible = false;
            this.wasd.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.wasd_PreviewKeyDown);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Location = new System.Drawing.Point(433, 343);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(230, 56);
            this.reset.TabIndex = 55;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(433, 53);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(230, 23);
            this.progressBar.TabIndex = 56;
            this.progressBar.Visible = false;
            // 
            // Progressus
            // 
            this.Progressus.AutoSize = true;
            this.Progressus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Progressus.Location = new System.Drawing.Point(480, 13);
            this.Progressus.Name = "Progressus";
            this.Progressus.Size = new System.Drawing.Size(144, 37);
            this.Progressus.TabIndex = 57;
            this.Progressus.Text = "Progressus";
            this.Progressus.Visible = false;
            // 
            // pont
            // 
            this.pont.AutoSize = true;
            this.pont.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pont.Location = new System.Drawing.Point(533, 85);
            this.pont.Name = "pont";
            this.pont.Size = new System.Drawing.Size(32, 37);
            this.pont.TabIndex = 58;
            this.pont.Text = "0";
            this.pont.Visible = false;
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size.Location = new System.Drawing.Point(283, 85);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(117, 21);
            this.size.TabIndex = 59;
            this.size.Text = "Méret választás";
            // 
            // X4
            // 
            this.X4.Location = new System.Drawing.Point(283, 271);
            this.X4.Name = "X4";
            this.X4.Size = new System.Drawing.Size(117, 33);
            this.X4.TabIndex = 60;
            this.X4.Text = "HARD (4X4)";
            this.X4.UseVisualStyleBackColor = true;
            this.X4.Click += new System.EventHandler(this.X4_Click);
            // 
            // X5
            // 
            this.X5.Location = new System.Drawing.Point(283, 202);
            this.X5.Name = "X5";
            this.X5.Size = new System.Drawing.Size(117, 33);
            this.X5.TabIndex = 61;
            this.X5.Text = "MEDIUM (5X5)";
            this.X5.UseVisualStyleBackColor = true;
            this.X5.Click += new System.EventHandler(this.X5_Click);
            // 
            // X6
            // 
            this.X6.Location = new System.Drawing.Point(283, 131);
            this.X6.Name = "X6";
            this.X6.Size = new System.Drawing.Size(117, 33);
            this.X6.TabIndex = 62;
            this.X6.Text = "EASY (6X6)";
            this.X6.UseVisualStyleBackColor = true;
            this.X6.Click += new System.EventHandler(this.X6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wasd);
            this.panel1.Location = new System.Drawing.Point(503, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 83);
            this.panel1.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.X6);
            this.Controls.Add(this.X5);
            this.Controls.Add(this.X4);
            this.Controls.Add(this.size);
            this.Controls.Add(this.pont);
            this.Controls.Add(this.Progressus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.jobbra);
            this.Controls.Add(this.le);
            this.Controls.Add(this.balra);
            this.Controls.Add(this.fel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "2048";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fel;
        private System.Windows.Forms.Button balra;
        private System.Windows.Forms.Button le;
        private System.Windows.Forms.Button jobbra;
        private System.Windows.Forms.Button wasd;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Progressus;
        private System.Windows.Forms.Label pont;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Button X4;
        private System.Windows.Forms.Button X5;
        private System.Windows.Forms.Button X6;
        private System.Windows.Forms.Panel panel1;
    }
}

