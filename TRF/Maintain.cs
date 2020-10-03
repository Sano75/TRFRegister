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

namespace TRF
{
    public class Maintain
    {
        kommunikation kom = new kommunikation();
        Inloggning inlog = new Inloggning();
        Medlemmar m = new Medlemmar();


        private void DisplayData()
        {
         /*   try
            {
                kom.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Regmedlsp", kom);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@FNamn", txbLeta.Text.Trim());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvMedl.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        public void ClearData()
        {
            
        }

             /*
             Id = 0;
            m..Text = "";
            m.txbEnamn.Text = "";
            m.txbMbl.Text = "";
            m.txbTelefon.Text = "";
            m.txbEpost.Text = "";
            txbAdress.Text = "";
            txbTigerN.Text = "";
            txbAge.Text = "";
        }     */
         /*
         public void Rensa()
         {
             txbEpost.Text = txbEnamn.Text = txbEpost.Text = txbFnamn.Text = txbMbl.Text = txbTelefon.Text = "";
             btnRadera.Enabled = false;
         }*/
        }
    }

