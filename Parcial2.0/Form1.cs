using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2._0
{
    public partial class frmPrincipal : Form
    {
       // private Users user { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabStart.ItemSize = new Size(0, 1);
        }

        //Cambio de pestana del TabControl segun donde el usuario de clic en el MenuStrip
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabStart.SelectedIndex = 0;
        }

        private void reservarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabStart.SelectedIndex = 1;
        }

        private void visualizarCitasExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabStart.SelectedIndex = 2;

        }

        private void actualizacionYCancelacionDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabStart.SelectedIndex = 3;

        }



        //Funcion para realizar reserva

        /*private void btnReserve_Click(object sender, EventArgs e)
        {
            bool check = txtCarnetUsername.Text.Length > 8;

            if(check)
            {
              Reservation Newreservation = new Reservation(
              txtCanetUsername.Text, dtpDate.Text, dtpHour.Text, (Speciality)cmbSpeciality.SelectedItem);

             //Anadiendo a la Base de datos
             
            var db = new ClinicContext();
            db.Add(NewReservation);
            db.SaveChanges();

            MessageBox.Show("Reserva realizada exitosamente", "Clinica UCA", 
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
               MessageBox.Show("Asegurece de llenar todos los campos", "Clinica UCA", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);


        }*/
        // Funcion para limpiar los datos al dar en el boton cancelar en la creacion de reservas
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCarnetUsername.Clear();
            dtpDate.Value = DateTime.Now;
            dtpHour.Value = DateTime.Now;
        }

        //Funcion para mostrar las Reservas del usuario
         /*private void LoadQuotes()
        {
            //Obteniendo las reservas de la BDD con todo y las referencias de User y Reservation
            var bd ClinicContext();
            var ListReservations = db.Reservations
                .include(i => i.Users)
                .include(i => i.Reservations)
                .OrderBy(i => i.id)
                .ToList();

            //Filtrando solo las reservas de mi usuario
            var filtering = ListReservations
                .Where(i => i.Users.id.Equals(user.id))
                .ToList();

            //Obtener las reservas del paso anterior
            List<Reservations> MyReservations = new List<Reservations>();
            foreach (Reservations reservation in filtering)
            {
                MyReservations.Add(reservation.Reservations);
            }

            //Mostrar las reservas en el Data Grid View
            dvgQuotes.DataSource = null;
            dvgQuotes.DataSource = MyReservations;

        }*/
    }
}
