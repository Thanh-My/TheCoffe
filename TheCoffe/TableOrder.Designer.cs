namespace TheCoffe
{
    partial class TableOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.nUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnChanceTable = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cbNullTable = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.cBProduct = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbEmp = new System.Windows.Forms.ComboBox();
            this.btnchangeEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 543);
            this.panel1.TabIndex = 0;
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(381, 222);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(188, 21);
            this.cbCat.TabIndex = 1;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Location = new System.Drawing.Point(716, 223);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(109, 67);
            this.btnAddPro.TabIndex = 3;
            this.btnAddPro.Text = "Thêm Món";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // nUDQuantity
            // 
            this.nUDQuantity.Location = new System.Drawing.Point(604, 223);
            this.nUDQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDQuantity.Name = "nUDQuantity";
            this.nUDQuantity.Size = new System.Drawing.Size(72, 20);
            this.nUDQuantity.TabIndex = 4;
            this.nUDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(381, 307);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.Size = new System.Drawing.Size(444, 141);
            this.dgvOrderDetail.TabIndex = 5;
            // 
            // btnChanceTable
            // 
            this.btnChanceTable.Location = new System.Drawing.Point(381, 462);
            this.btnChanceTable.Name = "btnChanceTable";
            this.btnChanceTable.Size = new System.Drawing.Size(100, 23);
            this.btnChanceTable.TabIndex = 6;
            this.btnChanceTable.Text = "Chuyển Bàn";
            this.btnChanceTable.UseVisualStyleBackColor = true;
            this.btnChanceTable.Click += new System.EventHandler(this.btnChanceTable_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(663, 460);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(162, 64);
            this.btnBill.TabIndex = 9;
            this.btnBill.Text = "Thanh Toán";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(381, 56);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(444, 141);
            this.dgvOrder.TabIndex = 10;
            // 
            // cbNullTable
            // 
            this.cbNullTable.FormattingEnabled = true;
            this.cbNullTable.Location = new System.Drawing.Point(384, 503);
            this.cbNullTable.Name = "cbNullTable";
            this.cbNullTable.Size = new System.Drawing.Size(97, 21);
            this.cbNullTable.TabIndex = 11;
            this.cbNullTable.SelectedIndexChanged += new System.EventHandler(this.cbNullTable_SelectedIndexChanged);
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.IntegralHeight = false;
            this.cbSize.ItemHeight = 13;
            this.cbSize.Location = new System.Drawing.Point(604, 269);
            this.cbSize.MaxDropDownItems = 3;
            this.cbSize.MaxLength = 30;
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(72, 21);
            this.cbSize.TabIndex = 12;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(520, 499);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(100, 27);
            this.btnChangeStatus.TabIndex = 13;
            this.btnChangeStatus.Text = "Đổi Trạng Thái";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // cBProduct
            // 
            this.cBProduct.FormattingEnabled = true;
            this.cBProduct.Location = new System.Drawing.Point(384, 269);
            this.cBProduct.Name = "cBProduct";
            this.cBProduct.Size = new System.Drawing.Size(188, 21);
            this.cBProduct.TabIndex = 14;
            this.cBProduct.SelectedIndexChanged += new System.EventHandler(this.cBProduct_SelectedIndexChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(713, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 17);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "lblTime";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(520, 462);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // cbEmp
            // 
            this.cbEmp.FormattingEnabled = true;
            this.cbEmp.Location = new System.Drawing.Point(381, 12);
            this.cbEmp.Name = "cbEmp";
            this.cbEmp.Size = new System.Drawing.Size(188, 21);
            this.cbEmp.TabIndex = 17;
            // 
            // btnchangeEmp
            // 
            this.btnchangeEmp.Location = new System.Drawing.Point(589, 10);
            this.btnchangeEmp.Name = "btnchangeEmp";
            this.btnchangeEmp.Size = new System.Drawing.Size(100, 23);
            this.btnchangeEmp.TabIndex = 18;
            this.btnchangeEmp.Text = "Đổi Nhân Viên";
            this.btnchangeEmp.UseVisualStyleBackColor = true;
            this.btnchangeEmp.Click += new System.EventHandler(this.btnchangeEmp_Click);
            // 
            // TableOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.btnchangeEmp);
            this.Controls.Add(this.cbEmp);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cBProduct);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbNullTable);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnChanceTable);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.nUDQuantity);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TableOrder";
            this.Text = "TableOrder";
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.NumericUpDown nUDQuantity;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Button btnChanceTable;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox cbNullTable;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.ComboBox cBProduct;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbEmp;
        private System.Windows.Forms.Button btnchangeEmp;
    }
}