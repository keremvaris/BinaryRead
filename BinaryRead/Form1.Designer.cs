namespace BinaryRead
{
    partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dokumannoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.revizyonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.docdokumandoczipBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.isoft9000DataSet = new BinaryRead.isoft9000DataSet();
			this.doc_dokuman_doczipTableAdapter = new BinaryRead.isoft9000DataSetTableAdapters.doc_dokuman_doczipTableAdapter();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.docdokumandoczipBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.isoft9000DataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dokumannoDataGridViewTextBoxColumn,
            this.revizyonnoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.docdokumandoczipBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(59, 100);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(438, 150);
			this.dataGridView1.TabIndex = 1;
			// 
			// dokumannoDataGridViewTextBoxColumn
			// 
			this.dokumannoDataGridViewTextBoxColumn.DataPropertyName = "dokuman_no";
			this.dokumannoDataGridViewTextBoxColumn.HeaderText = "dokuman_no";
			this.dokumannoDataGridViewTextBoxColumn.Name = "dokumannoDataGridViewTextBoxColumn";
			// 
			// revizyonnoDataGridViewTextBoxColumn
			// 
			this.revizyonnoDataGridViewTextBoxColumn.DataPropertyName = "revizyon_no";
			this.revizyonnoDataGridViewTextBoxColumn.HeaderText = "revizyon_no";
			this.revizyonnoDataGridViewTextBoxColumn.Name = "revizyonnoDataGridViewTextBoxColumn";
			// 
			// docdokumandoczipBindingSource
			// 
			this.docdokumandoczipBindingSource.DataMember = "doc_dokuman_doczip";
			this.docdokumandoczipBindingSource.DataSource = this.isoft9000DataSet;
			// 
			// isoft9000DataSet
			// 
			this.isoft9000DataSet.DataSetName = "isoft9000DataSet";
			this.isoft9000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// doc_dokuman_doczipTableAdapter
			// 
			this.doc_dokuman_doczipTableAdapter.ClearBeforeFill = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(90, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 337);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.docdokumandoczipBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.isoft9000DataSet)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private isoft9000DataSet isoft9000DataSet;
        private System.Windows.Forms.BindingSource docdokumandoczipBindingSource;
        private isoft9000DataSetTableAdapters.doc_dokuman_doczipTableAdapter doc_dokuman_doczipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumannoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revizyonnoDataGridViewTextBoxColumn;
				private System.Windows.Forms.Button button2;
    }
}

