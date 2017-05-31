using System;
using System.Collections.Generic;
namespace kinoteatr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.film1 = new System.Windows.Forms.Button();
            this.film2 = new System.Windows.Forms.Button();
            this.film3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // film1
            // 
            this.film1.FlatAppearance.BorderSize = 0;
            this.film1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.film1.Image = ((System.Drawing.Image)(resources.GetObject("film1.Image")));
            this.film1.Location = new System.Drawing.Point(56, 95);
            this.film1.Name = "film1";
            this.film1.Size = new System.Drawing.Size(128, 174);
            this.film1.TabIndex = 0;
            this.film1.UseVisualStyleBackColor = true;
            this.film1.Click += new System.EventHandler(this.film1_Click);
            // 
            // film2
            // 
            this.film2.FlatAppearance.BorderSize = 0;
            this.film2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.film2.Image = ((System.Drawing.Image)(resources.GetObject("film2.Image")));
            this.film2.Location = new System.Drawing.Point(248, 95);
            this.film2.Name = "film2";
            this.film2.Size = new System.Drawing.Size(120, 174);
            this.film2.TabIndex = 1;
            this.film2.UseVisualStyleBackColor = true;
            // 
            // film3
            // 
            this.film3.FlatAppearance.BorderSize = 0;
            this.film3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.film3.Image = ((System.Drawing.Image)(resources.GetObject("film3.Image")));
            this.film3.Location = new System.Drawing.Point(433, 95);
            this.film3.Name = "film3";
            this.film3.Size = new System.Drawing.Size(129, 174);
            this.film3.TabIndex = 2;
            this.film3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.film3);
            this.Controls.Add(this.film2);
            this.Controls.Add(this.film1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button film1;
        private System.Windows.Forms.Button film2;
        private System.Windows.Forms.Button film3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

