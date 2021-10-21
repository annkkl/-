namespace Экскурсионное_бюро
{
    partial class ИнформацияПоСтрудникам
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ИнформацияПоСтрудникам));
            this.managers = new System.Windows.Forms.Button();
            this.drivers = new System.Windows.Forms.Button();
            this.guides = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managers
            // 
            this.managers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("managers.BackgroundImage")));
            this.managers.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managers.Location = new System.Drawing.Point(34, 57);
            this.managers.Name = "managers";
            this.managers.Size = new System.Drawing.Size(134, 57);
            this.managers.TabIndex = 0;
            this.managers.Text = "Менеджеры";
            this.managers.UseVisualStyleBackColor = true;
            this.managers.Click += new System.EventHandler(this.managers_Click);
            // 
            // drivers
            // 
            this.drivers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drivers.BackgroundImage")));
            this.drivers.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drivers.Location = new System.Drawing.Point(422, 57);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(134, 57);
            this.drivers.TabIndex = 1;
            this.drivers.Text = "Водители";
            this.drivers.UseVisualStyleBackColor = true;
            this.drivers.Click += new System.EventHandler(this.drivers_Click);
            // 
            // guides
            // 
            this.guides.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guides.BackgroundImage")));
            this.guides.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guides.Location = new System.Drawing.Point(228, 57);
            this.guides.Name = "guides";
            this.guides.Size = new System.Drawing.Size(134, 57);
            this.guides.TabIndex = 2;
            this.guides.Text = "Гиды";
            this.guides.UseVisualStyleBackColor = true;
            this.guides.Click += new System.EventHandler(this.guides_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(454, 224);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 40);
            this.exit.TabIndex = 3;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ИнформацияПоСтрудникам
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 292);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.guides);
            this.Controls.Add(this.drivers);
            this.Controls.Add(this.managers);
            this.Name = "ИнформацияПоСтрудникам";
            this.Text = "ИнформацияПоСтрудникам";
            this.Load += new System.EventHandler(this.ИнформацияПоСтрудникам_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managers;
        private System.Windows.Forms.Button drivers;
        private System.Windows.Forms.Button guides;
        private System.Windows.Forms.Button exit;
    }
}