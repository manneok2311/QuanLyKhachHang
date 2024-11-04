namespace quản_lý_khách_hàng
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
            customersDataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            addressTextBox = new TextBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            createInvoiceButton = new Button();
            label4 = new Label();
            servicesDataGridView = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customersDataGridView
            // 
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGridView.Location = new Point(11, 28);
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.RowHeadersWidth = 51;
            customersDataGridView.Size = new Size(559, 219);
            customersDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 288);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 323);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 356);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(140, 285);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(242, 27);
            nameTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(140, 318);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(243, 27);
            phoneTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(140, 353);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(242, 27);
            addressTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(423, 314);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 7;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editButton.Location = new Point(591, 314);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 8;
            editButton.Text = "Sửa";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(771, 314);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // createInvoiceButton
            // 
            createInvoiceButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createInvoiceButton.Location = new Point(929, 316);
            createInvoiceButton.Name = "createInvoiceButton";
            createInvoiceButton.Size = new Size(105, 29);
            createInvoiceButton.TabIndex = 10;
            createInvoiceButton.Text = "Tạo hóa đơn";
            createInvoiceButton.UseVisualStyleBackColor = true;
            createInvoiceButton.Click += createInvoiceButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(106, 5);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 12;
            label4.Text = "Danh sách khách hàng";
            // 
            // servicesDataGridView
            // 
            servicesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesDataGridView.Location = new Point(612, 28);
            servicesDataGridView.Name = "servicesDataGridView";
            servicesDataGridView.RowHeadersWidth = 51;
            servicesDataGridView.Size = new Size(431, 219);
            servicesDataGridView.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(796, 5);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 14;
            label5.Text = "Danh sách dịch vụ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 506);
            Controls.Add(label5);
            Controls.Add(servicesDataGridView);
            Controls.Add(label4);
            Controls.Add(createInvoiceButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(addressTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customersDataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView customersDataGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private TextBox phoneTextBox;
        private TextBox addressTextBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button createInvoiceButton;
        private Label label4;
        private DataGridView servicesDataGridView;
        private Label label5;
    }
}
