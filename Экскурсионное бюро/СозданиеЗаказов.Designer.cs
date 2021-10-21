namespace Экскурсионное_бюро
{
    partial class СозданиеЗаказов
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label номерТелефонаLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label кодМаршрутаLabel;
            System.Windows.Forms.Label датаПоездкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СозданиеЗаказов));
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.номерТелефонаTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.кодМаршрутаComboBox = new System.Windows.Forms.ComboBox();
            this.датаПоездкиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            фИОLabel = new System.Windows.Forms.Label();
            номерТелефонаLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            кодМаршрутаLabel = new System.Windows.Forms.Label();
            датаПоездкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            фИОLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.Location = new System.Drawing.Point(59, 45);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(48, 19);
            фИОLabel.TabIndex = 0;
            фИОLabel.Text = "ФИО:";
            // 
            // номерТелефонаLabel
            // 
            номерТелефонаLabel.AutoSize = true;
            номерТелефонаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            номерТелефонаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерТелефонаLabel.Location = new System.Drawing.Point(59, 104);
            номерТелефонаLabel.Name = "номерТелефонаLabel";
            номерТелефонаLabel.Size = new System.Drawing.Size(123, 19);
            номерТелефонаLabel.TabIndex = 2;
            номерТелефонаLabel.Text = "Номер Телефона:";
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            возрастLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастLabel.Location = new System.Drawing.Point(59, 161);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(65, 19);
            возрастLabel.TabIndex = 4;
            возрастLabel.Text = "Возраст:";
            // 
            // кодМаршрутаLabel
            // 
            кодМаршрутаLabel.AutoSize = true;
            кодМаршрутаLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            кодМаршрутаLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодМаршрутаLabel.Location = new System.Drawing.Point(59, 216);
            кодМаршрутаLabel.Name = "кодМаршрутаLabel";
            кодМаршрутаLabel.Size = new System.Drawing.Size(111, 19);
            кодМаршрутаLabel.TabIndex = 6;
            кодМаршрутаLabel.Text = "Код Маршрута:";
            кодМаршрутаLabel.Click += new System.EventHandler(this.кодМаршрутаLabel_Click);
            // 
            // датаПоездкиLabel
            // 
            датаПоездкиLabel.AutoSize = true;
            датаПоездкиLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            датаПоездкиLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаПоездкиLabel.Location = new System.Drawing.Point(59, 274);
            датаПоездкиLabel.Name = "датаПоездкиLabel";
            датаПоездкиLabel.Size = new System.Drawing.Size(104, 19);
            датаПоездкиLabel.TabIndex = 8;
            датаПоездкиLabel.Text = "Дата Поездки:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "ФИО", true));
            this.фИОTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОTextBox.Location = new System.Drawing.Point(236, 38);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(317, 26);
            this.фИОTextBox.TabIndex = 1;
            // 
            // номерТелефонаTextBox
            // 
            this.номерТелефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "НомерТелефона", true));
            this.номерТелефонаTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерТелефонаTextBox.Location = new System.Drawing.Point(236, 97);
            this.номерТелефонаTextBox.Name = "номерТелефонаTextBox";
            this.номерТелефонаTextBox.Size = new System.Drawing.Size(256, 26);
            this.номерТелефонаTextBox.TabIndex = 3;
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Возраст", true));
            this.возрастTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.возрастTextBox.Location = new System.Drawing.Point(236, 154);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(100, 26);
            this.возрастTextBox.TabIndex = 5;
            // 
            // кодМаршрутаComboBox
            // 
            this.кодМаршрутаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "КодМаршрута", true));
            this.кодМаршрутаComboBox.DataSource = this.маршрутыBindingSource;
            this.кодМаршрутаComboBox.DisplayMember = "НазваниеМаршрута";
            this.кодМаршрутаComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодМаршрутаComboBox.FormattingEnabled = true;
            this.кодМаршрутаComboBox.Location = new System.Drawing.Point(236, 208);
            this.кодМаршрутаComboBox.Name = "кодМаршрутаComboBox";
            this.кодМаршрутаComboBox.Size = new System.Drawing.Size(137, 27);
            this.кодМаршрутаComboBox.TabIndex = 7;
            this.кодМаршрутаComboBox.ValueMember = "IDМаршрута";
            this.кодМаршрутаComboBox.SelectedIndexChanged += new System.EventHandler(this.кодМаршрутаComboBox_SelectedIndexChanged);
            // 
            // датаПоездкиDateTimePicker
            // 
            this.датаПоездкиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "ДатаПоездки", true));
            this.датаПоездкиDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаПоездкиDateTimePicker.Location = new System.Drawing.Point(236, 267);
            this.датаПоездкиDateTimePicker.Name = "датаПоездкиDateTimePicker";
            this.датаПоездкиDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.датаПоездкиDateTimePicker.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(63, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(385, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataSource = typeof(Экскурсионное_бюро.Заказы);
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataSource = typeof(Экскурсионное_бюро.Клиенты);
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataSource = typeof(Экскурсионное_бюро.Маршруты);
            // 
            // СозданиеЗаказов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(658, 478);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(датаПоездкиLabel);
            this.Controls.Add(this.датаПоездкиDateTimePicker);
            this.Controls.Add(кодМаршрутаLabel);
            this.Controls.Add(this.кодМаршрутаComboBox);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(номерТелефонаLabel);
            this.Controls.Add(this.номерТелефонаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Name = "СозданиеЗаказов";
            this.Text = "Создание заказов";
            this.Load += new System.EventHandler(this.СозданиеЗаказов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox номерТелефонаTextBox;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private System.Windows.Forms.ComboBox кодМаршрутаComboBox;
        private System.Windows.Forms.DateTimePicker датаПоездкиDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private System.Windows.Forms.Button button2;
    }
}