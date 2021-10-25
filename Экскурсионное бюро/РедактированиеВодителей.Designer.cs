namespace Экскурсионное_бюро
{
    partial class РедактированиеВодителей
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
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label фИОLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РедактированиеВодителей));
            this.водителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            возрастLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // водителиBindingSource
            // 
            this.водителиBindingSource.DataSource = typeof(Экскурсионное_бюро.Водители);
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            возрастLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастLabel.Location = new System.Drawing.Point(48, 116);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(65, 19);
            возрастLabel.TabIndex = 1;
            возрастLabel.Text = "Возраст:";
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Возраст", true));
            this.возрастTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.возрастTextBox.Location = new System.Drawing.Point(145, 108);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(100, 26);
            this.возрастTextBox.TabIndex = 2;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            фИОLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.Location = new System.Drawing.Point(48, 51);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(48, 19);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "ФИО", true));
            this.фИОTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОTextBox.Location = new System.Drawing.Point(145, 48);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(334, 26);
            this.фИОTextBox.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(52, 272);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(132, 41);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(347, 272);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(132, 41);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Отмена";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // РедактированиеВодителей
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(518, 384);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Name = "РедактированиеВодителей";
            this.Text = "РедактированиеВодителей";
            this.Load += new System.EventHandler(this.РедактированиеВодителей_Load);
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource водителиBindingSource;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}