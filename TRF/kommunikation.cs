
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace TRF
{
   
    public class kommunikation
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
       

        private void  ConnectTo()
        {
            sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TRFDB.mdf;Integrated Security=True");
            //Changed to |DataDirectory|
            sqlcmd = sqlcon.CreateCommand();
        }

        public kommunikation()
        {
            ConnectTo();
        }

        public void Registrera(Medlemmar m)
        {
                string commandTxt = "INSERT INTO Medlemmar(Förnamn, Efternamn, Adress, Epost, Telefon, Mobil, Tigernamn, TigerAlder, Type, LOrd) VALUES ('" + m.Namn + "','" + m.Efternamn + "', '" + m.Adress + "','" + m.Epost + "','" + m.Telnr + "', '" + m.Mobilnr + "','" + m.Tigernamn + "','" + m.Tigeralder + "','"+m.Typ+ "','" + m.LOrd + "')";
                SqlCommand inCmd = new SqlCommand(commandTxt, sqlcon);

            try
            {
                sqlcon.Open();
                inCmd.ExecuteNonQuery();
                MessageBox.Show("Ny Medlemsuppgifter sparade");
            }
            catch (Exception ex)
            {
                if (Debugger.IsAttached)
                MessageBox.Show(ex.Message, "Fel uppstod");
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
            }
        }
        public void UpdateraMedlem(Medlemmar m )
        {
            try
            {
                sqlcon.Open();
               string commandTxt = "update Medlemmar set Förnamn= '" + m.Namn+ "',Efternamn= '" + m.Efternamn + "',Adress= '" + m.Adress + "',Epost= '" + m.Epost + "',Telefon= '" + m.Telnr + "',Mobil= '" + m.Mobilnr + "',Tigernamn= '" + m.Tigernamn + "',TigerAlder= '" + m.Tigeralder + "',Type= '" + m.Typ + "', LOrd='" + m.LOrd + "' where Id=" + m.Id;
                SqlCommand Cmd = new SqlCommand(commandTxt, sqlcon);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Ny Medlemsuppgifter sparade");

                sqlcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel uppstod! kontrollera info");
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public void Radera (Medlemmar m)
        {
            try
                {
                    string commandTxt = "DELETE from Medlemmar where Id= " + m.Id;
                    SqlCommand inCmd = new SqlCommand(commandTxt, sqlcon);
                    sqlcon.Open();
                    inCmd.ExecuteNonQuery();
                    MessageBox.Show("Raderad");
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ej raderad, Försök igen");
            }
            finally
            {
                sqlcon.Close();
            }
        }
        public void Uppdate(Medlemmar m)
        {
           
            try
            {
                sqlcon.Open();
                sqlcmd.CommandText = "Update Medlemmar set förnamn= " + m.Namn + " Efternamn=" + m.Efternamn + " Adress= " + m.Adress + " Epost=" + m.Epost + " Telefon= " + m.Telnr + " Mobil= " + m.Mobilnr + " TigerNamn= " + m.Tigernamn + " TigerÅlder= " + m.Tigeralder +"Medlemstyp"+ m.Typ+" WHERE ID=" + m.Id;
                sqlcmd.CommandType = CommandType.Text;
                

                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "Fel uppstod!!!");

            }
            finally
            {
                sqlcon.Close();
            }
        }


    }

}

