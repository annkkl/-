namespace Экскурсионное_бюро
{
    partial class РедактированиеЗаказов
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
            System.Windows.Forms.Label iDМенеджераLabel;
            System.Windows.Forms.Label датаПоездкиLabel;
            System.Windows.Forms.Label кодМаршрутаLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РедактированиеЗаказов));
            this.iDМенеджераComboBox = new System.Windows.Forms.ComboBox();
            this.датаПоездкиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кодМаршрутаComboBox = new System.Windows.Forms.ComboBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            iDМенеджераLabel = new System.Windows.Forms.Label();
            датаПоездкиLabel = new System.Windows.Forms.Label();
            кодМаршрутаLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDМенеджераLabel
            // 
            iDМенеджераLabel.AutoSize = true;
            iDМенеджераLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            iDМенеджераLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDМенеджераLabel.Location = new System.Drawing.Point(49, 50);
            iDМенеджераLabel.Name = "iDМенеджераLabel";
            iDМенеджераLabel.Size = new System.Drawing.Size(83, 19);
            iDМенеджераLabel.TabIndex = 1;
            iDМенеджераLabel.Text = "Менеджер:";
            // 
            // iDМенеджераComboBox
            // 
            this.iDМенеджераComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "IDМенеджера", true));
            this.iDМенеджераComboBox.DataSource = this.менеджерыBindingSource;
            this.iDМенеджераComboBox.DisplayMember = "ФИО";
            this.iDМенеджераComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDМенеджераComboBox.FormattingEnabled = true;
            this.iDМенеджераComboBox.Location = new System.Drawing.Point(216, 42);
            this.iDМенеджераComboBox.Name = "iDМенеджераComboBox";
            this.iDМенеджераComboBox.Size = new System.Drawing.Size(200, 27);
            this.iDМенеджераComboBox.TabIndex = 2;
            this.iDМенеджераComboBox.ValueMember = "IDМенеджера";
            // 
            // датаПоездкиLabel
            // 
            датаПоездкиLabel.AutoSize = true;
            датаПоездкиLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            датаПоездкиLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаПоездкиLabel.Location = new System.Drawing.Point(49, 121);
            датаПоездкиLabel.Name = "датаПоездкиLabel";
            датаПоездкиLabel.Size = new System.Drawing.Size(104, 19);
            датаПоездкиLabel.TabIndex = 3;
            датаПоездкиLabel.Text = "Дата Поездки:";
            // 
            // датаПоездкиDateTimePicker
            // 
            this.датаПоездкиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "ДатаПоездки", true));
            this.датаПоездкиDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаПоездкиDateTimePicker.Location = new System.Drawing.Point(216, 114);
            this.датаПоездкиDateTimePicker.Name = "датаПоездкиDateTimePicker";
            this.датаПоездкиDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.датаПоездкиDateTimePicker.TabIndex = 4;
            // 
            // кодМаршрутаLabel
            // 
            кодМаршрутаLabel.AutoSize = true;
            кодМаршрутаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            кодМаршрутаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодМаршрутаLabel.Location = new System.Drawing.Point(49, 193);
            кодМаршрутаLabel.Name = "кодМаршрутаLabel";
            кодМаршрутаLabel.Size = new System.Drawing.Size(74, 19);
            кодМаршрутаLabel.TabIndex = 5;
            кодМаршрутаLabel.Text = "Маршрут:";
            // 
            // кодМаршрутаComboBox
            // 
            this.кодМаршрутаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодМаршрута", true));
            this.кодМаршрутаComboBox.DataSource = this.маршрутыBindingSource;
            this.кодМаршрутаComboBox.DisplayMember = "НазваниеМаршрута";
            this.кодМаршрутаComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодМаршрутаComboBox.FormattingEnabled = true;
            this.кодМаршрутаComboBox.Location = new System.Drawing.Point(216, 185);
            this.кодМаршрутаComboBox.Name = "кодМаршрутаComboBox";
            this.кодМаршрутаComboBox.Size = new System.Drawing.Size(200, 27);
            this.кодМаршрутаComboBox.TabIndex = 6;
            this.кодМаршрутаComboBox.ValueMember = "IDМаршрута";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            стоимостьLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            стоимостьLabel.Location = new System.Drawing.Point(49, 262);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(86, 19);
            стоимостьLabel.TabIndex = 7;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стоимостьTextBox.Location = new System.Drawing.Point(216, 255);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 26);
            this.стоимостьTextBox.TabIndex = 8;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataSource = typeof(Экскурсионное_бюро.Заказы);
            // 
            // менеджерыBindingSource
            // 
            this.менеджерыBindingSource.DataSource = typeof(Экскурсионное_бюро.Менеджеры);
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataSource = typeof(Экскурсионное_бюро.Маршруты);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(53, 418);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 38);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(384, 418);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(110, 38);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // РедактированиеЗаказов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 504);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(iDМенеджераLabel);
            this.Controls.Add(this.iDМенеджераComboBox);
            this.Controls.Add(датаПоездкиLabel);
            this.Controls.Add(this.датаПоездкиDateTimePicker);
            this.Controls.Add(кодМаршрутаLabel);
            this.Controls.Add(this.кодМаршрутаComboBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Name = "РедактированиеЗаказов";
            this.Text = "РедактированиеЗаказов";
            this.Load += new System.EventHandler(this.РедактированиеЗаказов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource заказыBindingSource;
        private System.Windows.Forms.ComboBox iDМенеджераComboBox;
        private System.Windows.Forms.DateTimePicker датаПоездкиDateTimePicker;
        private System.Windows.Forms.ComboBox кодМаршрутаComboBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}