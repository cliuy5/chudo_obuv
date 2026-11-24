namespace WinFormsApp2
{
    partial class CatalogForm
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
            lblUserName = new Label();
            lblCatalogTitle = new Label();
            btnOrderList = new Button();
            btnOrder = new Button();
            btnBack = new Button();
            flpProduct = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCategoryFilter = new Label();
            cboCategory = new ComboBox();
            lblPriceSort = new Label();
            cboPriceSort = new ComboBox();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(576, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(37, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Гость";
            lblUserName.Click += label1_Click;
            // 
            // lblCatalogTitle
            // 
            lblCatalogTitle.AutoSize = true;
            lblCatalogTitle.Location = new Point(12, 9);
            lblCatalogTitle.Name = "lblCatalogTitle";
            lblCatalogTitle.Size = new Size(86, 15);
            lblCatalogTitle.TabIndex = 1;
            lblCatalogTitle.Text = "Каталог обуви";
            lblCatalogTitle.Click += label2_Click;
            // 
            // btnOrderList
            // 
            btnOrderList.Enabled = false;
            btnOrderList.Location = new Point(525, 27);
            btnOrderList.Name = "btnOrderList";
            btnOrderList.Size = new Size(140, 23);
            btnOrderList.TabIndex = 2;
            btnOrderList.Text = "Список заказов";
            btnOrderList.UseVisualStyleBackColor = true;
            btnOrderList.Visible = false;
            btnOrderList.Click += btnOrderList_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(264, 27);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 23);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Заказ (0)";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 27);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button3_Click;
            // 
            // flpProduct
            // 
            flpProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpProduct.AutoScroll = true;
            flpProduct.FlowDirection = FlowDirection.TopDown;
            flpProduct.Location = new Point(-4, 103);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(1229, 513);
            flpProduct.TabIndex = 5;
            flpProduct.WrapContents = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(30, 56);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(200, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Поиск по названию или описанию";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(-2, 74);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(340, 23);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += CatalogOptionsChanged;
            // 
            // lblCategoryFilter
            // 
            lblCategoryFilter.AutoSize = true;
            lblCategoryFilter.Location = new Point(397, 56);
            lblCategoryFilter.Name = "lblCategoryFilter";
            lblCategoryFilter.Size = new Size(63, 15);
            lblCategoryFilter.TabIndex = 7;
            lblCategoryFilter.Text = "Категория";
            lblCategoryFilter.Click += lblCategoryFilter_Click;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(344, 74);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(205, 23);
            cboCategory.TabIndex = 8;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lblPriceSort
            // 
            lblPriceSort.AutoSize = true;
            lblPriceSort.Location = new Point(673, 56);
            lblPriceSort.Name = "lblPriceSort";
            lblPriceSort.Size = new Size(119, 15);
            lblPriceSort.TabIndex = 9;
            lblPriceSort.Text = "Сортировка по цене";
            lblPriceSort.Click += label1_Click_1;
            // 
            // cboPriceSort
            // 
            cboPriceSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriceSort.FormattingEnabled = true;
            cboPriceSort.Items.AddRange(new object[] { "По умолчанию", "Сначала дешевле", "Сначала дороже" });
            cboPriceSort.Location = new Point(618, 77);
            cboPriceSort.Name = "cboPriceSort";
            cboPriceSort.Size = new Size(220, 23);
            cboPriceSort.TabIndex = 10;
            cboPriceSort.SelectedIndexChanged += cboPriceSort_SelectedIndexChanged;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 617);
            Controls.Add(cboPriceSort);
            Controls.Add(lblPriceSort);
            Controls.Add(cboCategory);
            Controls.Add(lblCategoryFilter);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(flpProduct);
            Controls.Add(btnBack);
            Controls.Add(btnOrder);
            Controls.Add(btnOrderList);
            Controls.Add(lblCatalogTitle);
            Controls.Add(lblUserName);
            Name = "CatalogForm";
            Text = "Чудо Обувь - каталог";
            Load += CatalogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblCatalogTitle;
        private Button btnOrderList;
        private Button btnOrder;
        private Button btnBack;
        private FlowLayoutPanel flpProduct;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCategoryFilter;
        private ComboBox cboCategory;
        private Label lblPriceSort;
        private ComboBox cboPriceSort;
    }
}