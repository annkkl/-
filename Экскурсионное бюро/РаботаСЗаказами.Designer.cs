﻿namespace Экскурсионное_бюро
{
    partial class РаботаСЗаказами
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РаботаСЗаказами));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExitRZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(44, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(280, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Посмотреть заказы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitRZ
            // 
            this.ExitRZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitRZ.BackgroundImage")));
            this.ExitRZ.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitRZ.Location = new System.Drawing.Point(178, 213);
            this.ExitRZ.Name = "ExitRZ";
            this.ExitRZ.Size = new System.Drawing.Size(90, 45);
            this.ExitRZ.TabIndex = 2;
            this.ExitRZ.Text = "Назад";
            this.ExitRZ.UseVisualStyleBackColor = true;
            this.ExitRZ.Click += new System.EventHandler(this.ExitRZ_Click);
            // 
            // РаботаСЗаказами
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(455, 287);
            this.Controls.Add(this.ExitRZ);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "РаботаСЗаказами";
            this.Text = "Работа с заказами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExitRZ;
    }
}