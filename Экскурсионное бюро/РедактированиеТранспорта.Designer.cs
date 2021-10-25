namespace Экскурсионное_бюро
{
    partial class РедактированиеТранспорта
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
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label номерАвтобусаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РедактированиеТранспорта));
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.номерАвтобусаTextBox = new System.Windows.Forms.TextBox();
            this.транспортBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            маркаLabel = new System.Windows.Forms.Label();
            номерАвтобусаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.транспортBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            маркаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            маркаLabel.Location = new System.Drawing.Point(54, 115);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(55, 19);
            маркаLabel.TabIndex = 1;
            маркаLabel.Text = "Марка:";
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортBindingSource, "Марка", true));
            this.маркаTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.маркаTextBox.Location = new System.Drawing.Point(201, 112);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(155, 26);
            this.маркаTextBox.TabIndex = 2;
            // 
            // номерАвтобусаLabel
            // 
            номерАвтобусаLabel.AutoSize = true;
            номерАвтобусаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            номерАвтобусаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерАвтобусаLabel.Location = new System.Drawing.Point(54, 40);
            номерАвтобусаLabel.Name = "номерАвтобусаLabel";
            номерАвтобусаLabel.Size = new System.Drawing.Size(122, 19);
            номерАвтобусаLabel.TabIndex = 3;
            номерАвтобусаLabel.Text = "Номер Автобуса:";
            // 
            // номерАвтобусаTextBox
            // 
            this.номерАвтобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.транспортBindingSource, "НомерАвтобуса", true));
            this.номерАвтобусаTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерАвтобусаTextBox.Location = new System.Drawing.Point(201, 40);
            this.номерАвтобусаTextBox.Name = "номерАвтобусаTextBox";
            this.номерАвтобусаTextBox.Size = new System.Drawing.Size(155, 26);
            this.номерАвтобусаTextBox.TabIndex = 4;
            // 
            // транспортBindingSource
            // 
            this.транспортBindingSource.DataSource = typeof(Экскурсионное_бюро.Транспорт);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(58, 285);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(126, 35);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(310, 285);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(126, 35);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // РедактированиеТранспорта
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 377);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(номерАвтобусаLabel);
            this.Controls.Add(this.номерАвтобусаTextBox);
            this.Name = "РедактированиеТранспорта";
            this.Text = "РедактированиеТранспорта";
            this.Load += new System.EventHandler(this.РедактированиеТранспорта_Load);
            ((System.ComponentModel.ISupportInitialize)(this.транспортBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource транспортBindingSource;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox номерАвтобусаTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}