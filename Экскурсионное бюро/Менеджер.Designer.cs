namespace Экскурсионное_бюро
{
    partial class Менеджер
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Менеджер));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditM = new System.Windows.Forms.Button();
            this.DeleteM = new System.Windows.Forms.Button();
            this.ExitM = new System.Windows.Forms.Button();
            this.iDМенеджераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDМенеджераDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.менеджерыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // EditM
            // 
            this.EditM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditM.BackgroundImage")));
            this.EditM.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditM.Location = new System.Drawing.Point(561, 42);
            this.EditM.Name = "EditM";
            this.EditM.Size = new System.Drawing.Size(125, 50);
            this.EditM.TabIndex = 1;
            this.EditM.Text = "Редактировать";
            this.EditM.UseVisualStyleBackColor = true;
            this.EditM.Click += new System.EventHandler(this.EditM_Click);
            // 
            // DeleteM
            // 
            this.DeleteM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteM.BackgroundImage")));
            this.DeleteM.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteM.Location = new System.Drawing.Point(561, 143);
            this.DeleteM.Name = "DeleteM";
            this.DeleteM.Size = new System.Drawing.Size(125, 50);
            this.DeleteM.TabIndex = 2;
            this.DeleteM.Text = "Удалить";
            this.DeleteM.UseVisualStyleBackColor = true;
            this.DeleteM.Click += new System.EventHandler(this.DeleteM_Click);
            // 
            // ExitM
            // 
            this.ExitM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitM.BackgroundImage")));
            this.ExitM.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitM.Location = new System.Drawing.Point(561, 418);
            this.ExitM.Name = "ExitM";
            this.ExitM.Size = new System.Drawing.Size(125, 50);
            this.ExitM.TabIndex = 3;
            this.ExitM.Text = "Назад";
            this.ExitM.UseVisualStyleBackColor = true;
            this.ExitM.Click += new System.EventHandler(this.ExitM_Click);
            // 
            // iDМенеджераDataGridViewTextBoxColumn
            // 
            this.iDМенеджераDataGridViewTextBoxColumn.DataPropertyName = "IDМенеджера";
            this.iDМенеджераDataGridViewTextBoxColumn.HeaderText = "IDМенеджера";
            this.iDМенеджераDataGridViewTextBoxColumn.Name = "iDМенеджераDataGridViewTextBoxColumn";
            this.iDМенеджераDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // менеджерыBindingSource
            // 
            this.менеджерыBindingSource.DataSource = typeof(Экскурсионное_бюро.Менеджеры);
            // 
            // Менеджер
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 491);
            this.Controls.Add(this.ExitM);
            this.Controls.Add(this.DeleteM);
            this.Controls.Add(this.EditM);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Менеджер";
            this.Text = "Менеджер";
            this.Load += new System.EventHandler(this.Менеджер_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМенеджераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private System.Windows.Forms.Button EditM;
        private System.Windows.Forms.Button DeleteM;
        private System.Windows.Forms.Button ExitM;
    }
}