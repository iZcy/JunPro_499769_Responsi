namespace JunPro_499769_Responsi
{
    partial class HR_Management_System
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_Management_System));
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            deleteData = new Button();
            insertData = new Button();
            panel1 = new Panel();
            editData = new Button();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            inputJabatanList = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            inputNamaKaryawan = new TextBox();
            inputDepartementList = new ComboBox();
            label5 = new Label();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iddeptDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idjabatanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, iddeptDataGridViewTextBoxColumn, idjabatanDataGridViewTextBoxColumn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(18, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(764, 204);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2925167F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.70748F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
            tableLayoutPanel2.Controls.Add(deleteData, 2, 1);
            tableLayoutPanel2.Controls.Add(insertData, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 1, 1);
            tableLayoutPanel2.Controls.Add(panel2, 2, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(18, 18);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 0, 0, 15);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(764, 204);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // deleteData
            // 
            deleteData.Dock = DockStyle.Fill;
            deleteData.Location = new Point(561, 155);
            deleteData.Name = "deleteData";
            deleteData.Size = new Size(200, 31);
            deleteData.TabIndex = 3;
            deleteData.Text = "Delete";
            deleteData.UseVisualStyleBackColor = true;
            // 
            // insertData
            // 
            insertData.Dock = DockStyle.Fill;
            insertData.Location = new Point(3, 155);
            insertData.Name = "insertData";
            insertData.Size = new Size(168, 31);
            insertData.TabIndex = 1;
            insertData.Text = "Insert";
            insertData.UseVisualStyleBackColor = true;
            insertData.Click += insertData_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(editData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(177, 155);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(85, 0, 85, 0);
            panel1.Size = new Size(378, 31);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // editData
            // 
            editData.Dock = DockStyle.Fill;
            editData.Location = new Point(85, 0);
            editData.Name = "editData";
            editData.Size = new Size(208, 31);
            editData.TabIndex = 2;
            editData.Text = "Edit";
            editData.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(richTextBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(558, 0);
            panel2.Margin = new Padding(0, 0, 0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 127);
            panel2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 10F);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(206, 127);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "ID Departement:\nHR: HR\nENG: Engineer\nDEV: Developer\nPM: Product Manager\nFIN: Finance";
            // 
            // panel3
            // 
            tableLayoutPanel2.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 146);
            panel3.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 3, 3, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30.1369858F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 69.8630142F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.Size = new Size(552, 146);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.82609F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.173913F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 430F));
            tableLayoutPanel4.Controls.Add(inputJabatanList, 2, 2);
            tableLayoutPanel4.Controls.Add(label7, 1, 2);
            tableLayoutPanel4.Controls.Add(label6, 0, 2);
            tableLayoutPanel4.Controls.Add(label3, 1, 0);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(label4, 1, 1);
            tableLayoutPanel4.Controls.Add(inputNamaKaryawan, 2, 0);
            tableLayoutPanel4.Controls.Add(inputDepartementList, 2, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 47);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.Size = new Size(546, 96);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // inputJabatanList
            // 
            inputJabatanList.Anchor = AnchorStyles.None;
            inputJabatanList.FormattingEnabled = true;
            inputJabatanList.ItemHeight = 15;
            inputJabatanList.Location = new Point(118, 69);
            inputJabatanList.Name = "inputJabatanList";
            inputJabatanList.Size = new Size(425, 23);
            inputJabatanList.Sorted = true;
            inputJabatanList.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(104, 73);
            label7.Name = "label7";
            label7.Size = new Size(8, 15);
            label7.TabIndex = 7;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 73);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 6;
            label6.Text = "Jab. Karyawan";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(104, 9);
            label3.Name = "label3";
            label3.Size = new Size(8, 15);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(104, 42);
            label4.Name = "label4";
            label4.Size = new Size(8, 15);
            label4.TabIndex = 3;
            label4.Text = ":";
            // 
            // inputNamaKaryawan
            // 
            inputNamaKaryawan.Anchor = AnchorStyles.None;
            inputNamaKaryawan.Location = new Point(118, 5);
            inputNamaKaryawan.Name = "inputNamaKaryawan";
            inputNamaKaryawan.Size = new Size(425, 23);
            inputNamaKaryawan.TabIndex = 4;
            // 
            // inputDepartementList
            // 
            inputDepartementList.Anchor = AnchorStyles.None;
            inputDepartementList.FormattingEnabled = true;
            inputDepartementList.ItemHeight = 15;
            inputDepartementList.Location = new Point(118, 38);
            inputDepartementList.Name = "inputDepartementList";
            inputDepartementList.Size = new Size(425, 23);
            inputDepartementList.Sorted = true;
            inputDepartementList.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label5.Location = new Point(3, 1);
            label5.Name = "label5";
            label5.Size = new Size(364, 41);
            label5.TabIndex = 1;
            label5.Text = "HR Management System";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // iddeptDataGridViewTextBoxColumn
            // 
            iddeptDataGridViewTextBoxColumn.DataPropertyName = "id_dept";
            iddeptDataGridViewTextBoxColumn.HeaderText = "id_dept";
            iddeptDataGridViewTextBoxColumn.Name = "iddeptDataGridViewTextBoxColumn";
            // 
            // idjabatanDataGridViewTextBoxColumn
            // 
            idjabatanDataGridViewTextBoxColumn.DataPropertyName = "id_jabatan";
            idjabatanDataGridViewTextBoxColumn.HeaderText = "id_jabatan";
            idjabatanDataGridViewTextBoxColumn.Name = "idjabatanDataGridViewTextBoxColumn";
            // 
            // HR_Management_System
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HR_Management_System";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Management Sytstem";
            Load += HR_Management_System_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button insertData;
        private Button editData;
        private Button deleteData;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inputNamaKaryawan;
        private Label label5;
        private ComboBox inputDepartementList;
        private Label label6;
        private ComboBox inputJabatanList;
        private Label label7;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iddeptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idjabatanDataGridViewTextBoxColumn;
    }
}
