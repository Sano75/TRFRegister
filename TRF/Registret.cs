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
    public partial class Registret : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TeknikFix\Documents\Visual Studio 2015\Projects\progTvForms\TRFRegister\TRF\TRFDB.mdf;Integrated Security=True");
        SqlDataReader sqldr;

        public Registret()
        {
            InitializeComponent();
        }

        private void Registret_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medlemDS.Medlemmar' table. You can move, or remove it, as needed.
            this.medlemmarTableAdapter.Fill(this.medlemDS.Medlemmar);

        }
        private void btnavsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnregnymedlem_Click(object sender, EventArgs e)
        {
            RegistNy regny = new RegistNy();
            regny.Show();
        }

        private void btnregsökMedlem_Click(object sender, EventArgs e)
        {
            Medlemmar m = new Medlemmar();
            try
            {
                con.Open();

                {
                    string query = "Select * From Medlemmar Where Förnamn like '%" + txtnamnMedlem.Text.ToString() + "%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue(m.Namn, txtnamnMedlem.Text.ToString());
                    sqldr = cmd.ExecuteReader();
                }

                if (sqldr.HasRows)
                {
                    dgvMedlem.Visible = true;
                    DataTable dt = new DataTable();
                    dt.Load(sqldr);
                    dgvMedlem.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vänligen kontrollera informationen du söker efter");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
