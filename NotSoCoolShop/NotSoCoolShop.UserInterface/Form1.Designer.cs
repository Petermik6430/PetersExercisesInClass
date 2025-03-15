namespace NotSoCoolShop.UserInterface
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
            button1 = new Button();
            button2 = new Button();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listOfProducts = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(71, 166);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 169);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "GetAll";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(71, 87);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 2;
            txtTitle.TextChanged += textBox1_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(71, 128);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 69);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 113);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 5;
            label2.Text = "Price";
            // 
            // listOfProducts
            // 
            listOfProducts.FormattingEnabled = true;
            listOfProducts.ItemHeight = 15;
            listOfProducts.Location = new Point(191, 69);
            listOfProducts.Name = "listOfProducts";
            listOfProducts.Size = new Size(299, 94);
            listOfProducts.TabIndex = 6;
            listOfProducts.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 51);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "Liste af produkter";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 450);
            Controls.Add(label3);
            Controls.Add(listOfProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private ListBox listOfProducts;
        private Label label3;
    }
}
