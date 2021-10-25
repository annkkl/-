namespace Экскурсионное_бюро
{
    partial class РедактированиеМенеджеров
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
            System.Windows.Forms.Label номерТелефонаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РедактированиеМенеджеров));
            this.номерТелефонаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            номерТелефонаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номерТелефонаLabel
            // 
            номерТелефонаLabel.AutoSize = true;
            номерТелефонаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            номерТелефонаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерТелефонаLabel.Location = new System.Drawing.Point(51, 153);
            номерТелефонаLabel.Name = "номерТелефонаLabel";
            номерТелефонаLabel.Size = new System.Drawing.Size(123, 19);
            номерТелефонаLabel.TabIndex = 1;
            номерТелефонаLabel.Text = "Номер Телефона:";
            // 
            // номерТелефонаTextBox
            // 
            this.номерТелефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менеджерыBindingSource, "НомерТелефона", true));
            this.номерТелефонаTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерТелефонаTextBox.Location = new System.Drawing.Point(214, 146);
            this.номерТелефонаTextBox.Name = "номерТелефонаTextBox";
            this.номерТелефонаTextBox.Size = new System.Drawing.Size(131, 26);
            this.номерТелефонаTextBox.TabIndex = 2;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            фИОLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.Location = new System.Drawing.Point(51, 77);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(48, 19);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менеджерыBindingSource, "ФИО", true));
            this.фИОTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОTextBox.Location = new System.Drawing.Point(214, 70);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(321, 26);
            this.фИОTextBox.TabIndex = 4;
            // 
            // менеджерыBindingSource
            // 
            this.менеджерыBindingSource.DataSource = typeof(Экскурсионное_бюро.Менеджеры);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(55, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(416, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // РедактированиеМенеджеров
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(593, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(номерТелефонаLabel);
            this.Controls.Add(this.номерТелефонаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Name = "РедактированиеМенеджеров";
            this.Text = "РедактированиеМенеджеров";
            this.Load += new System.EventHandler(this.РедактированиеМенеджеров_Load);
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private System.Windows.Forms.TextBox номерТелефонаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}