using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.data.MySqlClient;

namespace ProyectofinalSAT
{
    public partial class muestra : Form
    {
        public muestra()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
<<<<<<< HEAD
            nombre=user.AccessibleDefaultActionDescription text;
            contraseña = PasswordPropertyTextAttribute.text;
            MySqlconnection con = new MySqlconnection(server = 127.0.0.1; InternalDataCollectionBase = login; user id = root; PasswordPropertyTextAttribute()
                try
            {
                con.open();

            }
            catch (MySqlExeption ex)
            {
                Messagebox.show("error" + ex.tostring());
                throw;
            }

            string sql = "Select user,pass from user where user = ´" + nombre + 'AND pass = ' + contraseña + "' ";
            Mysql.

            {

            }

=======
            nombre=user.AccessibleDefaultActionDescription Text;
            contraseña = PasswordPropertyTextAttribute.Text;
            MySqlconnection con = new MySqlconnection();

            
        }
    }
}
>>>>>>> f84c26ad3300d14fad790c0b0c1bd9e15edf04c7
