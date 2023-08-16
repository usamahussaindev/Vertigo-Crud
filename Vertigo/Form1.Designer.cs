namespace Vertigo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblVertigoId = new Label();
            pictureBoxLogo = new PictureBox();
            txtBoxId = new TextBox();
            txtBoxFirstName = new TextBox();
            lblFirstName = new Label();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            txtBoxContactNumber = new TextBox();
            lblContactNumber = new Label();
            textBox4 = new TextBox();
            lblAddress = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblSearch = new Label();
            txtBoxSearch = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVertigoId
            // 
            lblVertigoId.AutoSize = true;
            lblVertigoId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVertigoId.Location = new Point(71, 141);
            lblVertigoId.Name = "lblVertigoId";
            lblVertigoId.Size = new Size(84, 21);
            lblVertigoId.TabIndex = 0;
            lblVertigoId.Text = "Vertigo ID";
            lblVertigoId.Click += label1_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(387, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(173, 72);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // txtBoxId
            // 
            txtBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxId.Location = new Point(199, 138);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(284, 29);
            txtBoxId.TabIndex = 2;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(199, 184);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(284, 29);
            txtBoxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(71, 187);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 21);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            lblFirstName.Click += label1_Click_1;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(199, 230);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(284, 29);
            txtBoxLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(71, 233);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 21);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtBoxContactNumber
            // 
            txtBoxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxContactNumber.Location = new Point(199, 283);
            txtBoxContactNumber.Name = "txtBoxContactNumber";
            txtBoxContactNumber.Size = new Size(284, 29);
            txtBoxContactNumber.TabIndex = 8;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactNumber.Location = new Point(71, 286);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(97, 21);
            lblContactNumber.TabIndex = 7;
            lblContactNumber.Text = "Contact No.";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(199, 337);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(284, 112);
            textBox4.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(71, 340);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(71, 494);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 21);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender";
            lblGender.Click += label1_Click_2;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(199, 496);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(284, 29);
            cmbGender.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(199, 573);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 44);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(336, 573);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 44);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(475, 573);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 44);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(612, 573);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 44);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(535, 141);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 21);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(612, 138);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(327, 29);
            txtBoxSearch.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(535, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(404, 265);
            dataGridView1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(935, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 679);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(txtBoxSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(textBox4);
            Controls.Add(lblAddress);
            Controls.Add(txtBoxContactNumber);
            Controls.Add(lblContactNumber);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtBoxId);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblVertigoId);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Vertigo";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVertigoId;
        private PictureBox pictureBoxLogo;
        private TextBox txtBoxId;
        private TextBox txtBoxFirstName;
        private Label lblFirstName;
        private TextBox txtBoxLastName;
        private Label lblLastName;
        private TextBox txtBoxContactNumber;
        private Label lblContactNumber;
        private TextBox textBox4;
        private Label lblAddress;
        private Label lblGender;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblSearch;
        private TextBox txtBoxSearch;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}