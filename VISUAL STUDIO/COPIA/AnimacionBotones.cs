using System.Drawing;
using System.Windows.Forms;

namespace COPIA
{
    public static class AnimacionBotones
    {
        private static Size btnPreviousSize { get; set; }
        private static bool IsMouseDown { get; set; }

        public static void Btn_MouseDown(Button boton)
        {
            if (!IsMouseDown)
            {
                btnPreviousSize = new Size(boton.Width, boton.Height);
                boton.Size = new Size(boton.Width - 3, boton.Height - 3);
                IsMouseDown = true;
            }
        }

        public static void Btn_MouseLeave(Button boton)
        {
            if (!IsMouseDown)
            {
                btnPreviousSize = new Size(boton.Width, boton.Height);
            }
            boton.Size = btnPreviousSize;
            IsMouseDown = false;
        }
    }
}
