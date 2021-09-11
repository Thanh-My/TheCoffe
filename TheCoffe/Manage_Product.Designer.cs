namespace TheCoffe
{
    partial class Manage_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Product));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvProType = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.txtPSize = new System.Windows.Forms.Label();
            this.cbPsize = new System.Windows.Forms.ComboBox();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.lblPirce = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPRepeat = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPUpdate = new System.Windows.Forms.Button();
            this.btnPInsert = new System.Windows.Forms.Button();
            this.cbPSpecies = new System.Windows.Forms.ComboBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProType)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(154, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 453);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dgvProType);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.TxtName);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loại Sản Phẩm";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvProType
            // 
            this.dgvProType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProType.Location = new System.Drawing.Point(99, 232);
            this.dgvProType.Name = "dgvProType";
            this.dgvProType.Size = new System.Drawing.Size(313, 150);
            this.dgvProType.TabIndex = 7;
            this.dgvProType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProType_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Location = new System.Drawing.Point(127, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 34);
            this.panel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(202, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(125, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Làm mới";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(64, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(3, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(55, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(190, 99);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(185, 20);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(190, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(124, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.dgvProduct);
            this.tabPage2.Controls.Add(this.txtPSize);
            this.tabPage2.Controls.Add(this.cbPsize);
            this.tabPage2.Controls.Add(this.txtPPrice);
            this.tabPage2.Controls.Add(this.lblPirce);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.cbPSpecies);
            this.tabPage2.Controls.Add(this.txtPname);
            this.tabPage2.Controls.Add(this.txtPID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sản Phẩm";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(24, 267);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(491, 150);
            this.dgvProduct.TabIndex = 18;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // txtPSize
            // 
            this.txtPSize.AutoSize = true;
            this.txtPSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSize.ForeColor = System.Drawing.Color.Red;
            this.txtPSize.Location = new System.Drawing.Point(102, 190);
            this.txtPSize.Name = "txtPSize";
            this.txtPSize.Size = new System.Drawing.Size(63, 17);
            this.txtPSize.TabIndex = 17;
            this.txtPSize.Text = "Kích Cỡ";
            // 
            // cbPsize
            // 
            this.cbPsize.FormattingEnabled = true;
            this.cbPsize.IntegralHeight = false;
            this.cbPsize.Location = new System.Drawing.Point(234, 186);
            this.cbPsize.MaxDropDownItems = 3;
            this.cbPsize.Name = "cbPsize";
            this.cbPsize.Size = new System.Drawing.Size(185, 21);
            this.cbPsize.TabIndex = 4;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(234, 148);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(185, 20);
            this.txtPPrice.TabIndex = 3;
            // 
            // lblPirce
            // 
            this.lblPirce.AutoSize = true;
            this.lblPirce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPirce.ForeColor = System.Drawing.Color.Red;
            this.lblPirce.Location = new System.Drawing.Point(102, 151);
            this.lblPirce.Name = "lblPirce";
            this.lblPirce.Size = new System.Drawing.Size(45, 17);
            this.lblPirce.TabIndex = 14;
            this.lblPirce.Text = "Price";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BtnPRepeat);
            this.panel2.Controls.Add(this.btnPDelete);
            this.panel2.Controls.Add(this.btnPUpdate);
            this.panel2.Controls.Add(this.btnPInsert);
            this.panel2.Location = new System.Drawing.Point(154, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 34);
            this.panel2.TabIndex = 13;
            // 
            // BtnPRepeat
            // 
            this.BtnPRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnPRepeat.Image = ((System.Drawing.Image)(resources.GetObject("BtnPRepeat.Image")));
            this.BtnPRepeat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPRepeat.Location = new System.Drawing.Point(186, 3);
            this.BtnPRepeat.Name = "BtnPRepeat";
            this.BtnPRepeat.Size = new System.Drawing.Size(72, 23);
            this.BtnPRepeat.TabIndex = 3;
            this.BtnPRepeat.Text = "Làm mới";
            this.BtnPRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPRepeat.UseVisualStyleBackColor = true;
            this.BtnPRepeat.Click += new System.EventHandler(this.BtnPRepeat_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnPDelete.Image")));
            this.btnPDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDelete.Location = new System.Drawing.Point(125, 3);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(55, 23);
            this.btnPDelete.TabIndex = 2;
            this.btnPDelete.Text = "Xóa";
            this.btnPDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDelete.UseVisualStyleBackColor = true;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnPUpdate.Image")));
            this.btnPUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPUpdate.Location = new System.Drawing.Point(64, 3);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnPUpdate.TabIndex = 1;
            this.btnPUpdate.Text = "Sửa";
            this.btnPUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPUpdate.UseVisualStyleBackColor = true;
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPInsert
            // 
            this.btnPInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnPInsert.Image")));
            this.btnPInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPInsert.Location = new System.Drawing.Point(3, 3);
            this.btnPInsert.Name = "btnPInsert";
            this.btnPInsert.Size = new System.Drawing.Size(55, 23);
            this.btnPInsert.TabIndex = 0;
            this.btnPInsert.Text = "Thêm";
            this.btnPInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPInsert.UseVisualStyleBackColor = true;
            this.btnPInsert.Click += new System.EventHandler(this.btnPInsert_Click);
            // 
            // cbPSpecies
            // 
            this.cbPSpecies.FormattingEnabled = true;
            this.cbPSpecies.Location = new System.Drawing.Point(234, 105);
            this.cbPSpecies.Name = "cbPSpecies";
            this.cbPSpecies.Size = new System.Drawing.Size(185, 21);
            this.cbPSpecies.TabIndex = 2;
            this.cbPSpecies.SelectedIndexChanged += new System.EventHandler(this.cbPSpecies_SelectedIndexChanged);
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(234, 69);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(185, 20);
            this.txtPname.TabIndex = 1;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(234, 30);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(185, 20);
            this.txtPID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(102, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(102, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(102, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID";
            // 
            // Manage_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Manage_Product";
            this.Text = "Quản Lý Sản Phẩm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvProType;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label txtPSize;
        private System.Windows.Forms.ComboBox cbPsize;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.Label lblPirce;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPRepeat;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPUpdate;
        private System.Windows.Forms.Button btnPInsert;
        private System.Windows.Forms.ComboBox cbPSpecies;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
    }
}