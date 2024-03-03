namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Book book_one = new Book(Convert.ToString(txtName.Text), Convert.ToString(txtAuthor.Text), Convert.ToDouble(txtCopies.Text), Convert.ToDouble(txtCost.Text));
     
            //lblTotal.Text = "Total cost: " + (book_one.PrintResult());
            txtTOTAL.Text = book_one.PrintResult();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCopies_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtAuthor.Clear();
            txtCopies.Clear();
            txtCost.Clear();
            txtName.Clear();
            txtTOTAL.Clear();
        }
    }
}
