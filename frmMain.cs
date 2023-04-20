using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMascotas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void listMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (listMascotas.Text == "Perro Golden")
            { 
                
                fotoMascota.Image = Image.FromFile("perro-golden.jpg");
                lblTipo.Visible = true;
                lblEdad.Visible = true;

            }
            else
            {
                if (listMascotas.Text == "Gato Persa")
                {
                    fotoMascota.Image = Image.FromFile("gato-persa.jpg");
                    lblTipo.Visible = true;
                    lblEdad.Visible = true;
                }
                else
                {
                    if (listMascotas.Text == "Gato Siames")
                    {
                        fotoMascota.Image = Image.FromFile("gato-siames1.jpg");
                        lblTipo.Visible = true;
                        lblEdad.Visible = true;
                    }
                    else
                    {
                        if (listMascotas.Text == "Perro Pastor Aleman")
                        {
                            fotoMascota.Image = Image.FromFile("pastor-aleman1.jpg");
                            lblTipo.Visible = true;
                            lblEdad.Visible = true;
                        }
                        else
                        {
                            if (listMascotas.Text == "Tortuga")
                            {
                                fotoMascota.Image = Image.FromFile("tortuga.jpg");
                                lblTipo.Visible = true;
                                lblEdad.Visible = true;

                            }
                            else
                            {   
                                if (listMascotas.Text == "Loro")
                                {
                                    fotoMascota.Image = Image.FromFile("loro.jpg");
                                    lblTipo.Visible = true;
                                    lblEdad.Visible = true;

                                }
                                else
                                {
                                    if (listMascotas.Text == "Conejo")
                                    {
                                        fotoMascota.Image = Image.FromFile("conejo.jpg");
                                        lblTipo.Visible = true;
                                        lblEdad.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            ClsMascota Alimentar = new ClsMascota();
            Alimentar.nombre = listMascotas.SelectedItem.ToString();
            MessageBox.Show(Alimentar.AlimentarMascota());

        }
        

        public void btnAgregar_Click(object sender, EventArgs e)
        {
             

            ClsMascota NuevaMascota = new ClsMascota();

            NuevaMascota.nombre = txtNombre.Text;
            NuevaMascota.edad = txtEdad.Text;
            NuevaMascota.tipoAnimal = cmbTipo.Text;

            List<ClsMascota> ListarMascotas = new List<ClsMascota>();
            ListarMascotas.Add(NuevaMascota);

            
                foreach (var item in ListarMascotas)
                {
                    
                    listMascotas.Items.Add(item.tipoAnimal);
                    lblTipo.Text = item.tipoAnimal;
                    lblEdad.Text = item.edad + " " + "años";
                    
                }
            

        
            txtNombre.Clear();
            txtEdad.Clear();
            cmbTipo.SelectedIndex = -1;
            
            




        }

        private void btnCuidar_Click(object sender, EventArgs e)
        {
            ClsMascota Cuidar = new ClsMascota();
            Cuidar.nombre = listMascotas.SelectedItem.ToString();
            MessageBox.Show(Cuidar.CuidarMascota());
            
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            ClsMascota Jugar = new ClsMascota();
            Jugar.nombre = listMascotas.SelectedItem.ToString();
            MessageBox.Show(Jugar.JugarMascota());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

