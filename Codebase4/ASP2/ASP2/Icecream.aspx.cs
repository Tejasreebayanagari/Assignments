using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP2
{
    public partial class Icecream : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "BoxIce", "chocobarIce", "ConeIce", "CupIce", "DBCIce","Rolledice" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }



        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            BoxIce.ImageUrl = "~/Images/" + str + ".jpg";



        }




        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {



        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "BoxIce")
            {
                TextBox1.Text = "Rs 40/-";
            }
            else if (DropDownList1.Text == "chocobarIce")
            {
                TextBox1.Text = "Rs 70/-";
            }
            else if (DropDownList1.Text == "ConeIce")
            {
                TextBox1.Text = "Rs 80/-";
            }
            else if (DropDownList1.Text == "CupIce")
            {
                TextBox1.Text = "Rs 120/-";
            }
             else if (DropDownList1.Text == "DBCIce")
            {
                TextBox1.Text = "Rs 150/-";
            }
            else if (DropDownList1.Text == "Rolledice")
            {
                TextBox1.Text = "Rs 170/-";
            }

            else
            {
                TextBox1.Text = "Rs 40/-";
            }

        }
    }
}