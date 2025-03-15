using NotSoCoolShop.BusniessLogic;
using NotSoCoolShop.Domain;


namespace NotSoCoolShop.UserInterface
{
    public partial class Form1 : Form
    {
        private ProductController _productController = new ProductController();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                decimal price = -1;
                if (decimal.TryParse(txtPrice.Text, out price))
                {
                    Product newProduct = new Product { Price = price, Title = txtTitle.Text };
                    _productController.Create(newProduct);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateProductListBox();

        }

        public void UpdateProductListBox()
        {
            listOfProducts.Items.Clear();
            var allProducts = _productController.GetAll();
            foreach (var product in allProducts)
            {
                listOfProducts.Items.Add(product.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
