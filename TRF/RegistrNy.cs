using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TRF
{
    public partial class RegistNy : Form
    {
        SqlConnection con = new SqlConnection();
        kommunikation kom = new kommunikation();
        Inloggning inlog = new Inloggning();
       

        public RegistNy()
        {
            InitializeComponent();
        }

        private void btnavsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistreraNy_Load(object sender, EventArgs e)
        {

        }

        private void btntillinlogg_Click(object sender, EventArgs e)
        {
            this.Hide();
            inlog.Show();
        }

        private void btnstäng_Click(object sender, EventArgs e)
        {
            this.Close();
            inlog.Show();
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
           
            try
            {
                Medlemmar m = new Medlemmar();

                m.Namn = txtnamn.Text;
                m.Efternamn = txtefternamn.Text;
                m.Adress = txtadress.Text;
                m.Epost = txtepost.Text;
                m.Mobilnr = Convert.ToInt32(txtmobil.Text);
                m.Telnr = Convert.ToInt32(txttelefon.Text);
                m.Tigernamn = txttigerNamn.Text;
                m.Tigeralder = Convert.ToInt32(txttigerÅlder.Text);
                m.Typ = cmbType.SelectedItem.ToString();
                m.LOrd = txtLord.Text;

                kom.Registrera(m);


                Rensa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel uppstod");
            }
            finally
            {

                con.Close();
            }
        }
        public void Rensa()
        {
            txtnamn.Text = txtefternamn.Text = txtepost.Text = txtadress.Text = txtmobil.Text = txttelefon.Text = txttigerNamn.Text=txttigerÅlder.Text= "";
            //btnRadera.Enabled = false;
        }
    }
}
