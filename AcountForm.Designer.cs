namespace RentalPoint
{
    partial class AcountForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.TimeRentTb = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalPointDataSet = new RentalPoint.RentalPointDataSet();
            this.dateCloseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOpenTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientCb = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeOrderTb = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientTableAdapter = new RentalPoint.RentalPointDataSetTableAdapters.clientTableAdapter();
            this.orderTableAdapter = new RentalPoint.RentalPointDataSetTableAdapters.orderTableAdapter();
            this.statusTableAdapter = new RentalPoint.RentalPointDataSetTableAdapters.statusTableAdapter();
            this.AddClientForOrder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxUser);
            this.tabPage1.Controls.Add(this.labelRole);
            this.tabPage1.Controls.Add(this.labelUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователь";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::RentalPoint.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(22, 36);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(135, 97);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(196, 93);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(58, 18);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "label8";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(196, 45);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(58, 18);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "label8";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddClientForOrder);
            this.tabPage2.Controls.Add(this.OrderBtn);
            this.tabPage2.Controls.Add(this.TimeRentTb);
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Controls.Add(this.dateCloseTimePicker);
            this.tabPage2.Controls.Add(this.dateOpenTimePicker);
            this.tabPage2.Controls.Add(this.StatusCb);
            this.tabPage2.Controls.Add(this.ClientCb);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.CodeOrderTb);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сформировать заказ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OrderBtn
            // 
            this.OrderBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderBtn.Location = new System.Drawing.Point(325, 230);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(177, 32);
            this.OrderBtn.TabIndex = 8;
            this.OrderBtn.Text = "Сформировать заказ";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // TimeRentTb
            // 
            this.TimeRentTb.Location = new System.Drawing.Point(222, 199);
            this.TimeRentTb.Name = "TimeRentTb";
            this.TimeRentTb.ReadOnly = true;
            this.TimeRentTb.Size = new System.Drawing.Size(100, 20);
            this.TimeRentTb.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "time_order", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "t"));
            this.maskedTextBox1.Location = new System.Drawing.Point(222, 78);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // rentalPointDataSet
            // 
            this.rentalPointDataSet.DataSetName = "RentalPointDataSet";
            this.rentalPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateCloseTimePicker
            // 
            this.dateCloseTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "date_order_close", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateCloseTimePicker.Location = new System.Drawing.Point(222, 168);
            this.dateCloseTimePicker.Name = "dateCloseTimePicker";
            this.dateCloseTimePicker.Size = new System.Drawing.Size(142, 20);
            this.dateCloseTimePicker.TabIndex = 6;
            // 
            // dateOpenTimePicker
            // 
            this.dateOpenTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "date_order_open", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateOpenTimePicker.Location = new System.Drawing.Point(222, 47);
            this.dateOpenTimePicker.Name = "dateOpenTimePicker";
            this.dateOpenTimePicker.Size = new System.Drawing.Size(131, 20);
            this.dateOpenTimePicker.TabIndex = 2;
            // 
            // StatusCb
            // 
            this.StatusCb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "status_id", true));
            this.StatusCb.DataSource = this.statusBindingSource;
            this.StatusCb.DisplayMember = "name_status";
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Location = new System.Drawing.Point(222, 135);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(121, 21);
            this.StatusCb.TabIndex = 5;
            this.StatusCb.ValueMember = "id_status";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "status";
            this.statusBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // ClientCb
            // 
            this.ClientCb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "code_client", true));
            this.ClientCb.DataSource = this.clientBindingSource;
            this.ClientCb.DisplayMember = "fio";
            this.ClientCb.FormattingEnabled = true;
            this.ClientCb.Location = new System.Drawing.Point(222, 105);
            this.ClientCb.Name = "ClientCb";
            this.ClientCb.Size = new System.Drawing.Size(121, 21);
            this.ClientCb.TabIndex = 4;
            this.ClientCb.ValueMember = "code_client";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.rentalPointDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Время аренды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата закрытия заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Статус заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время открытия заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата открытия заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код заказа";
            // 
            // CodeOrderTb
            // 
            this.CodeOrderTb.Location = new System.Drawing.Point(222, 13);
            this.CodeOrderTb.Name = "CodeOrderTb";
            this.CodeOrderTb.Size = new System.Drawing.Size(100, 20);
            this.CodeOrderTb.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AddClientBtn);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(508, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Просмотр клиентов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.Location = new System.Drawing.Point(45, 227);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(138, 23);
            this.AddClientBtn.TabIndex = 1;
            this.AddClientBtn.Text = "Добавить клиента";
            this.AddClientBtn.UseVisualStyleBackColor = true;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // AddClientForOrder
            // 
            this.AddClientForOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClientForOrder.Location = new System.Drawing.Point(375, 109);
            this.AddClientForOrder.Name = "AddClientForOrder";
            this.AddClientForOrder.Size = new System.Drawing.Size(38, 23);
            this.AddClientForOrder.TabIndex = 9;
            this.AddClientForOrder.Text = "+";
            this.AddClientForOrder.UseVisualStyleBackColor = true;
            this.AddClientForOrder.Click += new System.EventHandler(this.AddClientForOrder_Click);
            // 
            // AcountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 313);
            this.Controls.Add(this.tabControl1);
            this.Name = "AcountForm";
            this.Text = "Аккаунт";
            this.Activated += new System.EventHandler(this.AcountForm_Activated);
            this.Load += new System.EventHandler(this.AcountForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPointDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox ClientCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeOrderTb;
        private RentalPointDataSet rentalPointDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RentalPointDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private RentalPointDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private RentalPointDataSetTableAdapters.statusTableAdapter statusTableAdapter;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.TextBox TimeRentTb;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateCloseTimePicker;
        private System.Windows.Forms.DateTimePicker dateOpenTimePicker;
        public System.Windows.Forms.Label labelRole;
        public System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button AddClientBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddClientForOrder;
    }
}