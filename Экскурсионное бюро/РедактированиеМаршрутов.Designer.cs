namespace Экскурсионное_бюро
{
    partial class РедактированиеМаршрутов
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
            System.Windows.Forms.Label iDВодителяLabel;
            System.Windows.Forms.Label iDГидаLabel;
            System.Windows.Forms.Label названиеМаршрутаLabel;
            System.Windows.Forms.Label номерАвтобусаLabel;
            System.Windows.Forms.Label планПоездкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РедактированиеМаршрутов));
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDВодителяTextBox = new System.Windows.Forms.TextBox();
            this.iDГидаTextBox = new System.Windows.Forms.TextBox();
            this.названиеМаршрутаTextBox = new System.Windows.Forms.TextBox();
            this.номерАвтобусаTextBox = new System.Windows.Forms.TextBox();
            this.планПоездкиTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            iDВодителяLabel = new System.Windows.Forms.Label();
            iDГидаLabel = new System.Windows.Forms.Label();
            названиеМаршрутаLabel = new System.Windows.Forms.Label();
            номерАвтобусаLabel = new System.Windows.Forms.Label();
            планПоездкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataSource = typeof(Экскурсионное_бюро.Маршруты);
            // 
            // iDВодителяLabel
            // 
            iDВодителяLabel.AutoSize = true;
            iDВодителяLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            iDВодителяLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDВодителяLabel.Location = new System.Drawing.Point(28, 46);
            iDВодителяLabel.Name = "iDВодителяLabel";
            iDВодителяLabel.Size = new System.Drawing.Size(92, 19);
            iDВодителяLabel.TabIndex = 0;
            iDВодителяLabel.Text = "IDВодителя:";
            // 
            // iDВодителяTextBox
            // 
            this.iDВодителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутыBindingSource, "IDВодителя", true));
            this.iDВодителяTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDВодителяTextBox.Location = new System.Drawing.Point(222, 43);
            this.iDВодителяTextBox.Name = "iDВодителяTextBox";
            this.iDВодителяTextBox.Size = new System.Drawing.Size(131, 26);
            this.iDВодителяTextBox.TabIndex = 1;
            // 
            // iDГидаLabel
            // 
            iDГидаLabel.AutoSize = true;
            iDГидаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            iDГидаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDГидаLabel.Location = new System.Drawing.Point(428, 46);
            iDГидаLabel.Name = "iDГидаLabel";
            iDГидаLabel.Size = new System.Drawing.Size(60, 19);
            iDГидаLabel.TabIndex = 2;
            iDГидаLabel.Text = "IDГида:";
            // 
            // iDГидаTextBox
            // 
            this.iDГидаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутыBindingSource, "IDГида", true));
            this.iDГидаTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDГидаTextBox.Location = new System.Drawing.Point(622, 43);
            this.iDГидаTextBox.Name = "iDГидаTextBox";
            this.iDГидаTextBox.Size = new System.Drawing.Size(131, 26);
            this.iDГидаTextBox.TabIndex = 3;
            // 
            // названиеМаршрутаLabel
            // 
            названиеМаршрутаLabel.AutoSize = true;
            названиеМаршрутаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            названиеМаршрутаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеМаршрутаLabel.Location = new System.Drawing.Point(28, 143);
            названиеМаршрутаLabel.Name = "названиеМаршрутаLabel";
            названиеМаршрутаLabel.Size = new System.Drawing.Size(149, 19);
            названиеМаршрутаLabel.TabIndex = 4;
            названиеМаршрутаLabel.Text = "Название Маршрута:";
            // 
            // названиеМаршрутаTextBox
            // 
            this.названиеМаршрутаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутыBindingSource, "НазваниеМаршрута", true));
            this.названиеМаршрутаTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.названиеМаршрутаTextBox.Location = new System.Drawing.Point(222, 136);
            this.названиеМаршрутаTextBox.Name = "названиеМаршрутаTextBox";
            this.названиеМаршрутаTextBox.Size = new System.Drawing.Size(131, 26);
            this.названиеМаршрутаTextBox.TabIndex = 5;
            // 
            // номерАвтобусаLabel
            // 
            номерАвтобусаLabel.AutoSize = true;
            номерАвтобусаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            номерАвтобусаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерАвтобусаLabel.Location = new System.Drawing.Point(428, 139);
            номерАвтобусаLabel.Name = "номерАвтобусаLabel";
            номерАвтобусаLabel.Size = new System.Drawing.Size(122, 19);
            номерАвтобусаLabel.TabIndex = 6;
            номерАвтобусаLabel.Text = "Номер Автобуса:";
            // 
            // номерАвтобусаTextBox
            // 
            this.номерАвтобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутыBindingSource, "НомерАвтобуса", true));
            this.номерАвтобусаTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерАвтобусаTextBox.Location = new System.Drawing.Point(622, 136);
            this.номерАвтобусаTextBox.Name = "номерАвтобусаTextBox";
            this.номерАвтобусаTextBox.Size = new System.Drawing.Size(131, 26);
            this.номерАвтобусаTextBox.TabIndex = 7;
            // 
            // планПоездкиLabel
            // 
            планПоездкиLabel.AutoSize = true;
            планПоездкиLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            планПоездкиLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            планПоездкиLabel.Location = new System.Drawing.Point(28, 242);
            планПоездкиLabel.Name = "планПоездкиLabel";
            планПоездкиLabel.Size = new System.Drawing.Size(107, 19);
            планПоездкиLabel.TabIndex = 8;
            планПоездкиLabel.Text = "План Поездки:";
            // 
            // планПоездкиTextBox
            // 
            this.планПоездкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.маршрутыBindingSource, "ПланПоездки", true));
            this.планПоездкиTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.планПоездкиTextBox.Location = new System.Drawing.Point(222, 239);
            this.планПоездкиTextBox.Name = "планПоездкиTextBox";
            this.планПоездкиTextBox.Size = new System.Drawing.Size(531, 26);
            this.планПоездкиTextBox.TabIndex = 9;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(87, 360);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(143, 42);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(565, 360);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(143, 42);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // РедактированиеМаршрутов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(iDВодителяLabel);
            this.Controls.Add(this.iDВодителяTextBox);
            this.Controls.Add(iDГидаLabel);
            this.Controls.Add(this.iDГидаTextBox);
            this.Controls.Add(названиеМаршрутаLabel);
            this.Controls.Add(this.названиеМаршрутаTextBox);
            this.Controls.Add(номерАвтобусаLabel);
            this.Controls.Add(this.номерАвтобусаTextBox);
            this.Controls.Add(планПоездкиLabel);
            this.Controls.Add(this.планПоездкиTextBox);
            this.Name = "РедактированиеМаршрутов";
            this.Text = "РедактированиеМаршрутов";
            this.Load += new System.EventHandler(this.РедактированиеМаршрутов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private System.Windows.Forms.TextBox iDВодителяTextBox;
        private System.Windows.Forms.TextBox iDГидаTextBox;
        private System.Windows.Forms.TextBox названиеМаршрутаTextBox;
        private System.Windows.Forms.TextBox номерАвтобусаTextBox;
        private System.Windows.Forms.TextBox планПоездкиTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}