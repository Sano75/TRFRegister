using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace TRF
{
  
    public partial class Inloggning : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TeknikFix\Documents\Visual Studio 2015\Projects\progTvForms\TRFRegister\TRF\TRFDB.mdf;Integrated Security=True");
        public Inloggning()
        {
            InitializeComponent();
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
           
           
            Registret reg = new Registret();
            AdminInlogg adlog = new AdminInlogg();

            //adlog.Show();
            try
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select Count (*) From Medlemmar Where Förnamn='" + txtinlognamn.Text + "' and LOrd='" + txtinloglord.Text + "'and Type='" + cbxInloggTyp.Text + "'", con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter sqlDa1 = new SqlDataAdapter("Select Type From Medlemmar Where Förnamn='" + txtinlognamn.Text + "' and LOrd='" + txtinloglord.Text + "'and Type='" + cbxInloggTyp.Text + "'", con);
                    DataTable dt1 = new DataTable();
                    sqlDa1.Fill(dt1);

                    if (dt1.Rows[0][0].ToString() == "Admin")
                    {
                        this.Hide();
                        AdminInlogg adm = new AdminInlogg();
                        adm.Show();
                    }


                    else if (dt1.Rows[0][0].ToString() == "Medlem")
                    {
                        this.Hide();
                        Registret mt = new Registret();
                        mt.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Vänligen kontrollera Namn och Lösenord");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
            finally
            {
               // this.Hide();
                con.Close();
            }
        }

        private void btnNyReg_Click(object sender, EventArgs e)
        { 
            this.Hide();
            RegistNy nyreg = new RegistNy();
            nyreg.Show();
        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTRF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sv.wikipedia.org/wiki/Tiger");
        }

        private void lblSSG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/sano-gharzani-9192bbb7");
        }
    }
}

