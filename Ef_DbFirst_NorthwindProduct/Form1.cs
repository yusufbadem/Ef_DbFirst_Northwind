using Ef_DbFirst_NorthwindProduct.Models;

namespace Ef_DbFirst_NorthwindProduct;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        NorthwindContext db = new NorthwindContext();
        var products = db.Products.ToList(); 
        dgvProducts.DataSource = products;
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        NorthwindContext db= new NorthwindContext();

        decimal MinText=Convert.ToDecimal(txtMin.Text);
        decimal MaxText=Convert.ToDecimal(txtMax.Text);

        var products=db.Products.Where(x=>x.UnitPrice>=MinText &&  x.UnitPrice<=MaxText).OrderBy(x=>x.UnitPrice).ToList();

        dgvProducts.DataSource= products;


    }
}
