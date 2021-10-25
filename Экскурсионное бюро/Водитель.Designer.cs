namespace Экскурсионное_бюро
{
    partial class Водитель
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Водитель));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditDr = new System.Windows.Forms.Button();
            this.DeleteDr = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.iDВодителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.водителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDВодителяDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.возрастDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.водителиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // EditDr
            // 
            this.EditDr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditDr.BackgroundImage")));
            this.EditDr.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDr.Location = new System.Drawing.Point(495, 48);
            this.EditDr.Name = "EditDr";
            this.EditDr.Size = new System.Drawing.Size(142, 49);
            this.EditDr.TabIndex = 1;
            this.EditDr.Text = "Редактировать";
            this.EditDr.UseVisualStyleBackColor = true;
            this.EditDr.Click += new System.EventHandler(this.EditDr_Click);
            // 
            // DeleteDr
            // 
            this.DeleteDr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteDr.BackgroundImage")));
            this.DeleteDr.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDr.Location = new System.Drawing.Point(495, 147);
            this.DeleteDr.Name = "DeleteDr";
            this.DeleteDr.Size = new System.Drawing.Size(142, 49);
            this.DeleteDr.TabIndex = 2;
            this.DeleteDr.Text = "Удалить";
            this.DeleteDr.UseVisualStyleBackColor = true;
            this.DeleteDr.Click += new System.EventHandler(this.DeleteDr_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(495, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iDВодителяDataGridViewTextBoxColumn
            // 
            this.iDВодителяDataGridViewTextBoxColumn.DataPropertyName = "IDВодителя";
            this.iDВодителяDataGridViewTextBoxColumn.HeaderText = "IDВодителя";
            this.iDВодителяDataGridViewTextBoxColumn.Name = "iDВодителяDataGridViewTextBoxColumn";
            this.iDВодителяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            // 
            // водителиBindingSource
            // 
            this.водителиBindingSource.DataSource = typeof(Экскурсионное_бюро.Водители);
            // 
            // Водитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 479);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeleteDr);
            this.Controls.Add(this.EditDr);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Водитель";
            this.Text = "Водитель";
            this.Load += new System.EventHandler(this.Водитель_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDВодителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource водителиBindingSource;
        private System.Windows.Forms.Button EditDr;
        private System.Windows.Forms.Button DeleteDr;
        private System.Windows.Forms.Button button3;
    }
}