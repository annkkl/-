namespace Экскурсионное_бюро
{
    partial class ПросмотрЗаказов
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПросмотрЗаказов));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExitPZ = new System.Windows.Forms.Button();
            this.iDЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодМаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоездкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМенеджераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(695, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(695, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаказаDataGridViewTextBoxColumn,
            this.кодМаршрутаDataGridViewTextBoxColumn,
            this.датаПоездкиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.iDМенеджераDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 478);
            this.dataGridView1.TabIndex = 4;
            // 
            // ExitPZ
            // 
            this.ExitPZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitPZ.BackgroundImage")));
            this.ExitPZ.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitPZ.Location = new System.Drawing.Point(723, 454);
            this.ExitPZ.Name = "ExitPZ";
            this.ExitPZ.Size = new System.Drawing.Size(103, 36);
            this.ExitPZ.TabIndex = 5;
            this.ExitPZ.Text = "Назад";
            this.ExitPZ.UseVisualStyleBackColor = true;
            this.ExitPZ.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDЗаказаDataGridViewTextBoxColumn
            // 
            this.iDЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.HeaderText = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.Name = "iDЗаказаDataGridViewTextBoxColumn";
            // 
            // кодМаршрутаDataGridViewTextBoxColumn
            // 
            this.кодМаршрутаDataGridViewTextBoxColumn.DataPropertyName = "КодМаршрута";
            this.кодМаршрутаDataGridViewTextBoxColumn.HeaderText = "КодМаршрута";
            this.кодМаршрутаDataGridViewTextBoxColumn.Name = "кодМаршрутаDataGridViewTextBoxColumn";
            // 
            // датаПоездкиDataGridViewTextBoxColumn
            // 
            this.датаПоездкиDataGridViewTextBoxColumn.DataPropertyName = "ДатаПоездки";
            this.датаПоездкиDataGridViewTextBoxColumn.HeaderText = "ДатаПоездки";
            this.датаПоездкиDataGridViewTextBoxColumn.Name = "датаПоездкиDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // iDМенеджераDataGridViewTextBoxColumn
            // 
            this.iDМенеджераDataGridViewTextBoxColumn.DataPropertyName = "IDМенеджера";
            this.iDМенеджераDataGridViewTextBoxColumn.HeaderText = "IDМенеджера";
            this.iDМенеджераDataGridViewTextBoxColumn.Name = "iDМенеджераDataGridViewTextBoxColumn";
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataSource = typeof(Экскурсионное_бюро.Заказы);
            // 
            // ПросмотрЗаказов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 513);
            this.Controls.Add(this.ExitPZ);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "ПросмотрЗаказов";
            this.Text = "Просмотр заказов";
            this.Load += new System.EventHandler(this.ПросмотрЗаказов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодМаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоездкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМенеджераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private System.Windows.Forms.Button ExitPZ;
    }
}