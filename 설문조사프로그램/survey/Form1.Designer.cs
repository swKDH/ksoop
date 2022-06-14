namespace survey
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
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new survey.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.가죽자켓DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모헤어가디건DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.반팔셔츠DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.셔츠DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.니트DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미니멀자켓DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미니멀가디건DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.바시티자켓DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.쉘파카DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(-11, 27);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(413, 318);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.가죽자켓DataGridViewTextBoxColumn,
            this.모헤어가디건DataGridViewTextBoxColumn,
            this.반팔셔츠DataGridViewTextBoxColumn,
            this.셔츠DataGridViewTextBoxColumn,
            this.니트DataGridViewTextBoxColumn,
            this.미니멀자켓DataGridViewTextBoxColumn,
            this.미니멀가디건DataGridViewTextBoxColumn,
            this.바시티자켓DataGridViewTextBoxColumn,
            this.쉘파카DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.valueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(431, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(665, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // valueBindingSource
            // 
            this.valueBindingSource.DataMember = "value";
            this.valueBindingSource.DataSource = this.dataSet1;
            // 
            // 가죽자켓DataGridViewTextBoxColumn
            // 
            this.가죽자켓DataGridViewTextBoxColumn.DataPropertyName = "가죽자켓";
            this.가죽자켓DataGridViewTextBoxColumn.HeaderText = "가죽자켓";
            this.가죽자켓DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.가죽자켓DataGridViewTextBoxColumn.Name = "가죽자켓DataGridViewTextBoxColumn";
            this.가죽자켓DataGridViewTextBoxColumn.Width = 125;
            // 
            // 모헤어가디건DataGridViewTextBoxColumn
            // 
            this.모헤어가디건DataGridViewTextBoxColumn.DataPropertyName = "모헤어 가디건";
            this.모헤어가디건DataGridViewTextBoxColumn.HeaderText = "모헤어 가디건";
            this.모헤어가디건DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.모헤어가디건DataGridViewTextBoxColumn.Name = "모헤어가디건DataGridViewTextBoxColumn";
            this.모헤어가디건DataGridViewTextBoxColumn.Width = 125;
            // 
            // 반팔셔츠DataGridViewTextBoxColumn
            // 
            this.반팔셔츠DataGridViewTextBoxColumn.DataPropertyName = "반팔셔츠";
            this.반팔셔츠DataGridViewTextBoxColumn.HeaderText = "반팔셔츠";
            this.반팔셔츠DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.반팔셔츠DataGridViewTextBoxColumn.Name = "반팔셔츠DataGridViewTextBoxColumn";
            this.반팔셔츠DataGridViewTextBoxColumn.Width = 125;
            // 
            // 셔츠DataGridViewTextBoxColumn
            // 
            this.셔츠DataGridViewTextBoxColumn.DataPropertyName = "셔츠";
            this.셔츠DataGridViewTextBoxColumn.HeaderText = "셔츠";
            this.셔츠DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.셔츠DataGridViewTextBoxColumn.Name = "셔츠DataGridViewTextBoxColumn";
            this.셔츠DataGridViewTextBoxColumn.Width = 125;
            // 
            // 니트DataGridViewTextBoxColumn
            // 
            this.니트DataGridViewTextBoxColumn.DataPropertyName = "니트";
            this.니트DataGridViewTextBoxColumn.HeaderText = "니트";
            this.니트DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.니트DataGridViewTextBoxColumn.Name = "니트DataGridViewTextBoxColumn";
            this.니트DataGridViewTextBoxColumn.Width = 125;
            // 
            // 미니멀자켓DataGridViewTextBoxColumn
            // 
            this.미니멀자켓DataGridViewTextBoxColumn.DataPropertyName = "미니멀자켓";
            this.미니멀자켓DataGridViewTextBoxColumn.HeaderText = "미니멀자켓";
            this.미니멀자켓DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.미니멀자켓DataGridViewTextBoxColumn.Name = "미니멀자켓DataGridViewTextBoxColumn";
            this.미니멀자켓DataGridViewTextBoxColumn.Width = 125;
            // 
            // 미니멀가디건DataGridViewTextBoxColumn
            // 
            this.미니멀가디건DataGridViewTextBoxColumn.DataPropertyName = "미니멀가디건";
            this.미니멀가디건DataGridViewTextBoxColumn.HeaderText = "미니멀가디건";
            this.미니멀가디건DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.미니멀가디건DataGridViewTextBoxColumn.Name = "미니멀가디건DataGridViewTextBoxColumn";
            this.미니멀가디건DataGridViewTextBoxColumn.Width = 125;
            // 
            // 바시티자켓DataGridViewTextBoxColumn
            // 
            this.바시티자켓DataGridViewTextBoxColumn.DataPropertyName = "바시티자켓";
            this.바시티자켓DataGridViewTextBoxColumn.HeaderText = "바시티자켓";
            this.바시티자켓DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.바시티자켓DataGridViewTextBoxColumn.Name = "바시티자켓DataGridViewTextBoxColumn";
            this.바시티자켓DataGridViewTextBoxColumn.Width = 125;
            // 
            // 쉘파카DataGridViewTextBoxColumn
            // 
            this.쉘파카DataGridViewTextBoxColumn.DataPropertyName = "쉘파카";
            this.쉘파카DataGridViewTextBoxColumn.HeaderText = "쉘파카";
            this.쉘파카DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.쉘파카DataGridViewTextBoxColumn.Name = "쉘파카DataGridViewTextBoxColumn";
            this.쉘파카DataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "갱신";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pieChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가죽자켓DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모헤어가디건DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 반팔셔츠DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 셔츠DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 니트DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미니멀자켓DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미니멀가디건DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 바시티자켓DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 쉘파카DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource valueBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Button button1;
    }
}