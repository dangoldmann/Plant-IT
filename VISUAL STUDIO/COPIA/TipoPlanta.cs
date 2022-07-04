using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COPIA
{
    public partial class TipoPlanta : Form
    {
        public static bool formTipoPlanta;
        private List<Label> listaLabels;

        public TipoPlanta()
        {
            InitializeComponent();
            listaLabels = new List<Label>() { lblNombrePlanta };
            Fuente.CambiarFuente(listaLabels);
        }

        #region BOTONES
        private void btnBonsai_Click(object sender, EventArgs e)
        {
            OpenEdicion(1);
        }

        private void btnCactus_Click(object sender, EventArgs e)
        {
            OpenEdicion(2);
        }

        private void btnFlor_Click(object sender, EventArgs e)
        {
            OpenEdicion(3);
        }

        private void btnPasto_Click(object sender, EventArgs e)
        {
            OpenEdicion(4);
        }

        private void btnSuculenta_Click(object sender, EventArgs e)
        {
            OpenEdicion(5);
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            OpenEdicion(6);
        }
        #endregion

        #region MOUSE DOWN & LEAVE
        private void btnBonsai_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnBonsai);
        }

        private void btnBonsai_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnBonsai);
        }

        private void btnCactus_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnCactus);
        }

        private void btnCactus_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnCactus);
        }

        private void btnFlor_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnFlor);
        }

        private void btnFlor_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnFlor);
        }

        private void btnPasto_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnPasto);
        }

        private void btnPasto_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnPasto);
        }

        private void btnSuculenta_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnSuculenta);
        }

        private void btnSuculenta_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnSuculenta);
        }

        private void btnOtro_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnOtro);
        }

        private void btnOtro_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnOtro);
        }
        #endregion
        
        public void OpenEdicion(int IDFamilia)
        {
            Planta.IDFamilia[ListaPlantas.numeroPlanta] = IDFamilia;
            formTipoPlanta = true;
            Edicion edicion = new Edicion();
            edicion.Show();
            this.Close();
        }

    }
}
