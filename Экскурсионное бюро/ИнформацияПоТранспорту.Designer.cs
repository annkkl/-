
namespace Экскурсионное_бюро
{
    partial class ИнформацияПоТранспорту
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditT = new System.Windows.Forms.Button();
            this.DeleteT = new System.Windows.Forms.Button();
            this.ExitT = new System.Windows.Forms.Button();
            this.номерАвтобусаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.транспортBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерАвтобусаDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.транспортBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // EditT
            // 
            this.EditT.Location = new System.Drawing.Point(328, 55);
            this.EditT.Name = "EditT";
            this.EditT.Size = new System.Drawing.Size(117, 51);
            this.EditT.TabIndex = 1;
            this.EditT.Text = "Редактировать";
            this.EditT.UseVisualStyleBackColor = true;
            this.EditT.Click += new System.EventHandler(this.EditT_Click);
            // 
            // DeleteT
            // 
            this.DeleteT.Location = new System.Drawing.Point(339, 142);
            this.DeleteT.Name = "DeleteT";
            this.DeleteT.Size = new System.Drawing.Size(88, 38);
            this.DeleteT.TabIndex = 2;
            this.DeleteT.Text = "Удалить";
            this.DeleteT.UseVisualStyleBackColor = true;
            this.DeleteT.Click += new System.EventHandler(this.DeleteT_Click);
            // 
            // ExitT
            // 
            this.ExitT.Location = new System.Drawing.Point(339, 408);
            this.ExitT.Name = "ExitT";
            this.ExitT.Size = new System.Drawing.Size(75, 23);
            this.ExitT.TabIndex = 3;
            this.ExitT.Text = "Назад";
            this.ExitT.UseVisualStyleBackColor = true;
            this.ExitT.Click += new System.EventHandler(this.ExitT_Click);
            // 
            // номерАвтобусаDataGridViewTextBoxColumn
            // 
            this.номерАвтобусаDataGridViewTextBoxColumn.DataPropertyName = "НомерАвтобуса";
            this.номерАвтобусаDataGridViewTextBoxColumn.HeaderText = "НомерАвтобуса";
            this.номерАвтобусаDataGridViewTextBoxColumn.Name = "номерАвтобусаDataGridViewTextBoxColumn";
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            // 
            // транспортBindingSource
            // 
            this.транспортBindingSource.DataSource = typeof(Экскурсионное_бюро.Транспорт);
            // 
            // ИнформацияПоТранспорту
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 485);
            this.Controls.Add(this.ExitT);
            this.Controls.Add(this.DeleteT);
            this.Controls.Add(this.EditT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ИнформацияПоТранспорту";
            this.Text = "ИнформацияПоТранспорту";
            this.Load += new System.EventHandler(this.ИнформацияПоТранспорту_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.транспортBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерАвтобусаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource транспортBindingSource;
        private System.Windows.Forms.Button EditT;
        private System.Windows.Forms.Button DeleteT;
        private System.Windows.Forms.Button ExitT;
    }
}