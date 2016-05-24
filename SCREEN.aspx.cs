using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer; 
namespace PresentationLayer
{
    public partial class SCREEN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            int SNO = Convert.ToInt32(TextBox1.Text);
            string NAME = TextBox2.Text;
            int MODEL = Convert.ToInt32(TextBox3.Text);
            int PRICE = Convert.ToInt32( TextBox4.Text);
            int b = Operations.Createcar(SNO,NAME, MODEL, PRICE);
            Label1.Text = b + "CAR CREATED SUCCESSFULLY";
            Label1.ForeColor = System.Drawing.Color.Green;
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            int SNO = Convert.ToInt32(TextBox1.Text);
            string NAME = TextBox2.Text;
            int MODEL = Convert.ToInt32(TextBox3.Text);
            int PRICE = Convert.ToInt32(TextBox4.Text);
            int b = Operations.Updatecar(SNO, NAME, MODEL, PRICE);
            Label1.Text = b + "CAR UPDATED SUCCESSFULLY";
            Label1.ForeColor = System.Drawing.Color.Green;
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int SNO = Convert.ToInt32(TextBox1.Text);
            int b = Operations.Deletecar(SNO);
            Label1.Text = b + "CAR DELETED SUCCESSFULLY";
            Label1.ForeColor = System.Drawing.Color.Green;
        }
    }
}