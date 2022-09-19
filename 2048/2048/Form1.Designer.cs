
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
            this.label1 = new System.Windows.Forms.Label();
            this.pont = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.fel.Click += new System.EventHandler(this.fel_Click);
            // 
            // balra
            // 
            this.balra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.balra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balra.Location = new System.Drawing.Point(435, 202);
            this.balra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.balra.Name = "balra";
            this.balra.Size = new System.Drawing.Size(66, 56);
            this.balra.TabIndex = 26;
            this.balra.Text = "Ad sinistram";
            this.balra.UseVisualStyleBackColor = false;
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
            this.le.Text = "Sucus";
            this.le.UseVisualStyleBackColor = true;
            // 
            // jobbra
            // 
            this.jobbra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.jobbra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jobbra.Location = new System.Drawing.Point(599, 202);
            this.jobbra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jobbra.Name = "jobbra";
            this.jobbra.Size = new System.Drawing.Size(66, 56);
            this.jobbra.TabIndex = 28;
            this.jobbra.Text = "Ius";
            this.jobbra.UseVisualStyleBackColor = false;
            // 
            // wasd
            // 
            this.wasd.BackColor = System.Drawing.Color.Lime;
            this.wasd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wasd.Location = new System.Drawing.Point(506, 192);
            this.wasd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wasd.Name = "wasd";
            this.wasd.Size = new System.Drawing.Size(88, 75);
            this.wasd.TabIndex = 29;
            this.wasd.Text = "WASD";
            this.wasd.UseVisualStyleBackColor = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Location = new System.Drawing.Point(433, 343);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(230, 56);
            this.reset.TabIndex = 55;
            this.reset.Text = "ITERUM";
            this.reset.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(433, 53);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(230, 23);
            this.progressBar.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(480, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Progressus";
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(140, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Méret választás";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.wasd);
            this.Controls.Add(this.jobbra);
            this.Controls.Add(this.le);
            this.Controls.Add(this.balra);
            this.Controls.Add(this.fel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "2048";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pont;
        private System.Windows.Forms.Label label2;
    }
}

