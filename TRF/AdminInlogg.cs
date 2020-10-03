using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* 
 *uppdatera befintlig medlem,,, ej fullbordat 
 */

namespace TRF
{
    public partial class AdminInlogg : Form
    {
        kommunikation kom = new kommunikation();
        SqlConnection con = new SqlConnection
            (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TeknikFix\Documents\Visual Studio 2015\Projects\progTvForms\TRFRegister\TRF\TRFDB.mdf;Integrated Security=True");
        Inloggning inlog = new Inloggning();
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataTable dt;
        Medlemmar m = new Medlemmar();
        int Count = 0;

        public AdminInlogg()
        {
            InitializeComponent();
        }
        private void AdminInlogg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRFDBDataSet.Medlemmar' table. You can move, or remove it, as needed.
            this.medlemmarTableAdapter2.Fill(this.tRFDBDataSet.Medlemmar);
            // TODO: This line of code loads data into the 'tRFAdminDS.Medlemmar' table. You can move, or remove it, as needed.
            this.medlemmarTableAdapter.Fill(this.tRFAdminDS.Medlemmar);
            Räknare.Start();
        }
        private void btnSpara_Click(object sender, EventArgs e)
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
                m.Typ = cbxtyp.SelectedItem.ToString();
                m.LOrd = txtLOrd.Text;

                kom.Registrera(m);

                this.dgvAdmin.Update();
                VisaMedlemmar();
                Rensa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel uppstod");
            }
            finally
            {
                VisaMedlemmar();
                con.Close();
            }


        }
        private void btnLeta_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * From Medlemmar Where Förnamn like '%" + txtLeta.Text.ToString() + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue(m.Namn, txtLeta.Text.ToString());
                sqldr = cmd.ExecuteReader();


                if (sqldr.HasRows)
                {
                    dgvAdmin.Visible = true;
                    DataTable dt = new DataTable();
                    dt.Load(sqldr);
                    dgvAdmin.DataSource = dt;
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
        private void btnAvslutAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Refresh(Medlemmar m)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TeknikFix\Documents\Visual Studio 2015\Projects\progTvForms\TRFRegister\TRF\TRFDB.mdf;Integrated Security=True");
                sqlda = new SqlDataAdapter("select * from Medlemmar", con);
                sqlda.Fill(dt);
                dgvAdmin.DataSource = dt;


            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Rensa()
        {
            txtnamn.Text = txtefternamn.Text = txtepost.Text = txtadress.Text = txtmobil.Text = txttelefon.Text = txttigerNamn.Text = txttigerÅlder.Text = " ";
            //btnRadera.Enabled = false;
        }
        public void VisaMedlemmar()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Medlemmar", con);
                sda.SelectCommand.CommandType = CommandType.Text;
                sda.SelectCommand.Parameters.AddWithValue("@Namn", txtLeta.Text.Trim());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvAdmin.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnbytinfo_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            try
            {
                Medlemmar m = new Medlemmar();
                m.Namn = txtnamn.Text.ToString();
                m.Efternamn = txtefternamn.Text.ToString();
                m.Adress = txtadress.Text.ToString();
                m.Epost = txtepost.Text.ToString();
                m.Mobilnr = Convert.ToInt32(txtmobil.Text.ToString());
                m.Telnr = Convert.ToInt32(txttelefon.Text.ToString());
                m.Tigernamn = txttigerNamn.Text.ToString();
                m.Tigeralder = Convert.ToInt32(txttigerÅlder.Text.ToString());
                m.Typ = cbxtyp.SelectedItem.ToString();
                m.LOrd = txtLOrd.Text.ToString();


                kom.UpdateraMedlem(m);

                this.dgvAdmin.Update();
                VisaMedlemmar();
                Rensa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel uppstod");
            }
            finally
            {
                VisaMedlemmar();
                con.Close();
            }
        }
        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdmin.CurrentRow.Index != -1)
            {

                txtnamn.Text = dgvAdmin.CurrentRow.Cells[1].Value.ToString();
                txtefternamn.Text = dgvAdmin.CurrentRow.Cells[2].Value.ToString();
                txtepost.Text = dgvAdmin.CurrentRow.Cells[3].Value.ToString();
                txtadress.Text = dgvAdmin.CurrentRow.Cells[4].Value.ToString();
                txtmobil.Text = dgvAdmin.CurrentRow.Cells[5].Value.ToString();
                txttelefon.Text = dgvAdmin.CurrentRow.Cells[6].Value.ToString();
                txttigerNamn.Text = dgvAdmin.CurrentRow.Cells[7].Value.ToString();
                txttigerÅlder.Text = dgvAdmin.CurrentRow.Cells[8].Value.ToString();
                cbxtyp.Text = dgvAdmin.CurrentRow.Cells[9].Value.ToString();
            }
        }
        private void btnRadera_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand Cmd = con.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "delete from Medlemmar where Förnamn='" + txtnamn.Text + "'";
                Cmd.ExecuteNonQuery();
                MessageBox.Show("EN medlem är Raderad!");

                this.dgvAdmin.Update();
                VisaMedlemmar();
                Rensa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ej Raderad, Försök igen!");
            }
            finally
            {

                con.Close();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            
            AdminInlogg n = new AdminInlogg();
            n.Refresh();
            VisaMedlemmar();
           

        }

        private void Räknare_Tick(object sender, EventArgs e)
        {
            try
            {
                Count = medlemmarBindingSource3.Count;
                lblräkna.Text = "Antal registrerade medlemmar i databasen: " + Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
          }

        private void btnTillMedlemS_Click(object sender, EventArgs e)
        {
            Registret reg = new Registret();
            reg.Show();
        }
    }
}



