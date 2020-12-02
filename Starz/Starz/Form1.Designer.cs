namespace Starz
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
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShoppingCartGridView = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.BasketLabel = new System.Windows.Forms.Label();
            this.BasketTextBox = new System.Windows.Forms.TextBox();
            this.PromotionTextBox = new System.Windows.Forms.TextBox();
            this.PromotionLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Starz.Properties.Resources.Starz;
            this.LogoPictureBox.Location = new System.Drawing.Point(749, 536);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(96, 36);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Items.AddRange(new object[] {
            "Apple",
            "Orange"});
            this.ProductComboBox.Location = new System.Drawing.Point(89, 12);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(90, 21);
            this.ProductComboBox.TabIndex = 1;
            this.ProductComboBox.Text = "Apple";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(12, 13);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(71, 20);
            this.ProductLabel.TabIndex = 2;
            this.ProductLabel.Text = "Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Starz.Properties.Resources.Basket;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ShoppingCartGridView
            // 
            this.ShoppingCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShoppingCartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Price,
            this.Basket,
            this.Promotion});
            this.ShoppingCartGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ShoppingCartGridView.Location = new System.Drawing.Point(191, 264);
            this.ShoppingCartGridView.Name = "ShoppingCartGridView";
            this.ShoppingCartGridView.Size = new System.Drawing.Size(444, 168);
            this.ShoppingCartGridView.TabIndex = 20;
            this.ShoppingCartGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ShoppingCartGridView_UserDeletedRow);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Basket
            // 
            this.Basket.HeaderText = "Basket";
            this.Basket.Name = "Basket";
            // 
            // Promotion
            // 
            this.Promotion.HeaderText = "Promotion";
            this.Promotion.Name = "Promotion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Location = new System.Drawing.Point(248, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 64);
            this.panel1.TabIndex = 5;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(63, 17);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(170, 31);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total: $0.00";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(185, 13);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(76, 20);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price ($)";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(267, 12);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(90, 20);
            this.PriceTextBox.TabIndex = 7;
            // 
            // BasketLabel
            // 
            this.BasketLabel.AutoSize = true;
            this.BasketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketLabel.Location = new System.Drawing.Point(363, 13);
            this.BasketLabel.Name = "BasketLabel";
            this.BasketLabel.Size = new System.Drawing.Size(106, 20);
            this.BasketLabel.TabIndex = 8;
            this.BasketLabel.Text = "Basket (qty)";
            // 
            // BasketTextBox
            // 
            this.BasketTextBox.Location = new System.Drawing.Point(475, 12);
            this.BasketTextBox.Name = "BasketTextBox";
            this.BasketTextBox.Size = new System.Drawing.Size(90, 20);
            this.BasketTextBox.TabIndex = 9;
            // 
            // PromotionTextBox
            // 
            this.PromotionTextBox.Location = new System.Drawing.Point(667, 12);
            this.PromotionTextBox.Name = "PromotionTextBox";
            this.PromotionTextBox.Size = new System.Drawing.Size(90, 20);
            this.PromotionTextBox.TabIndex = 11;
            // 
            // PromotionLabel
            // 
            this.PromotionLabel.AutoSize = true;
            this.PromotionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromotionLabel.Location = new System.Drawing.Point(571, 13);
            this.PromotionLabel.Name = "PromotionLabel";
            this.PromotionLabel.Size = new System.Drawing.Size(90, 20);
            this.PromotionLabel.TabIndex = 10;
            this.PromotionLabel.Text = "Promotion";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(763, 10);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(73, 23);
            this.AddToCartButton.TabIndex = 12;
            this.AddToCartButton.Text = "Add to Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 569);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.PromotionTextBox);
            this.Controls.Add(this.PromotionLabel);
            this.Controls.Add(this.BasketTextBox);
            this.Controls.Add(this.BasketLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShoppingCartGridView);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fruit Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingCartGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView ShoppingCartGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promotion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label BasketLabel;
        private System.Windows.Forms.TextBox BasketTextBox;
        private System.Windows.Forms.TextBox PromotionTextBox;
        private System.Windows.Forms.Label PromotionLabel;
        private System.Windows.Forms.Button AddToCartButton;
    }
}

