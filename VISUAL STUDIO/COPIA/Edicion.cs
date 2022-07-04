using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COPIA
{
    public partial class Edicion : Form
    {
        private bool formLoad;
        private List<Label> listaLabels;

        public Edicion()
        {
            InitializeComponent();
            listaLabels = new List<Label>() { lblIngresarNombre, lblTipoPlanta, lblHumedadMinima, lblHumedadMaxima, lblLuzMinima, lblLuzMaxima, lblValorHumedadMinima, lblValorHumedadMaxima, lblValorLuzMinima, lblValorLuzMaxima };
            Fuente.CambiarFuente(listaLabels);

        }

        #region BOTONES
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (trackBar_HumedadMinima.Value > trackBar_HumedadMaxima.Value || trackBar_LuzMinima.Value > trackBar_LuzMaxima.Value || txtNombre.Texts == "")
            {
                MessageBox.Show("Error en el nombre de la planta o en los parámetros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Planta.Update(txtNombre.Texts, trackBar_HumedadMinima.Value * 10, trackBar_HumedadMaxima.Value * 10, trackBar_LuzMinima.Value * 10, trackBar_LuzMaxima.Value * 10, Planta.IDFamilia[ListaPlantas.numeroPlanta], (ListaPlantas.numeroPlanta + 1));
            Planta.ActualizarVariables();
            EnviarNotificaciones();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TipoPlanta tipoPlanta = new TipoPlanta();
            tipoPlanta.Show();
            this.Close();
        }
        #endregion

        #region FORM LOAD & CLOSED
        private void Edicion_Load(object sender, EventArgs e)
        {
            formLoad = true;

            if (TipoPlanta.formTipoPlanta)
                Planta.GetRangosFamilia(Planta.IDFamilia[ListaPlantas.numeroPlanta], ListaPlantas.numeroPlanta);
            else
                btnBack.Visible = false;

            Actualizar_Objetos();
            formLoad = false;
        }

        private void Edicion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Planta.ActualizarVariables();
            ListaPlantas.ActualizarObjetos();
            TipoPlanta.formTipoPlanta = false;
        }
        #endregion

        #region TRACKBARS
        private void trackBar_LuzMaxima_ValueChanged(object sender, EventArgs e)
        {
            lblValorLuzMaxima.Text = $"({trackBar_LuzMaxima.Value * 10}%)";
        }

        private void trackBar_LuzMinima_ValueChanged(object sender, EventArgs e)
        {
            lblValorLuzMinima.Text = $"({trackBar_LuzMinima.Value * 10}%)";
        }

        private void trackBar_HumedadMaxima_ValueChanged(object sender, EventArgs e)
        {
            lblValorHumedadMaxima.Text = $"({trackBar_HumedadMaxima.Value * 10}%)";
        }

        private void trackBar_HumedadMinima_ValueChanged(object sender, EventArgs e)
        {
            lblValorHumedadMinima.Text = $"({trackBar_HumedadMinima.Value * 10}%)";
        }
        #endregion

        #region FUNCIONES
        private void Actualizar_Objetos()
        {
            txtNombre.Texts = Planta.nombre[ListaPlantas.numeroPlanta];

            comboBox_TipoPlanta.SelectedIndex = Planta.IDFamilia[ListaPlantas.numeroPlanta] - 1;

            trackBar_HumedadMinima.Value = Planta.rango_HumedadRecomendada[(ListaPlantas.numeroPlanta), 0] / 10;
            trackBar_HumedadMaxima.Value = Planta.rango_HumedadRecomendada[(ListaPlantas.numeroPlanta), 1] / 10;
            trackBar_LuzMinima.Value = Planta.rango_LuzRecomendada[(ListaPlantas.numeroPlanta), 0] / 10;
            trackBar_LuzMaxima.Value = Planta.rango_LuzRecomendada[(ListaPlantas.numeroPlanta), 1] / 10;

            switch (Planta.IDFamilia[ListaPlantas.numeroPlanta])
            {
                case 1:
                    pictureBox_Familia.BackgroundImage = Properties.Resources.BotonBonsai;
                    break;
                case 2:
                    pictureBox_Familia.BackgroundImage = Properties.Resources.BotonCactus;
                    break;
                case 3:
                    pictureBox_Familia.BackgroundImage = Properties.Resources.BotonFlor;
                    break;
                case 4:
                    pictureBox_Familia.BackgroundImage = Properties.Resources.BotonPasto;
                    break;
                case 5:
                    pictureBox_Familia.BackgroundImage = Properties.Resources.BotonSuculenta;
                    break;
                case 6:
                    pictureBox_Familia.BackgroundImage = null;
                    break;
            }
        }

        private void EnviarNotificaciones()
        {
            Maceta.ActualizarEstadosActuales(ListaPlantas.numeroPlanta, "Humedad");
            _ = Notificaciones.SendSMS(ListaPlantas.numeroPlanta, Notificaciones.SetMensaje("Humedad", Maceta.estadoHumedad[ListaPlantas.numeroPlanta]));

            Maceta.ActualizarEstadosActuales(ListaPlantas.numeroPlanta, "Luz");
            _ = Notificaciones.SendSMS(ListaPlantas.numeroPlanta, Notificaciones.SetMensaje("Luz", Maceta.estadoLuz[ListaPlantas.numeroPlanta]));
        }
        #endregion

        #region MOUSE DOWN & LEAVE
        private void btnConfirmar_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnConfirmar);
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnConfirmar);
        }

        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnBack);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnBack);
        }
        #endregion

        #region KEY PRESS
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnConfirmar_Click(this, e);
            }
        }

        private void comboBox_TipoPlanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnConfirmar_Click(this, e);
            }
        }

        private void trackBar_HumedadMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnConfirmar_Click(this, e);
            }
        }

        private void trackBar_HumedadMaxima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnConfirmar_Click(this, e);
            }
        }

        private void trackBar_LuzMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnConfirmar_Click(this, e);
            }
        }

        private void trackBar_LuzMaxima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnConfirmar_Click(this, e);
            }
        }
        #endregion

        private void comboBox_TipoPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Planta.IDFamilia[ListaPlantas.numeroPlanta] = comboBox_TipoPlanta.SelectedIndex + 1;

            if (!formLoad)
            {
                Planta.GetRangosFamilia(Planta.IDFamilia[ListaPlantas.numeroPlanta], ListaPlantas.numeroPlanta);
                Actualizar_Objetos();
            }
        }

    }
}
