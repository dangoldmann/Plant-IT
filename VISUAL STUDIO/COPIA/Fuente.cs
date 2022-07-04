using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace COPIA
{
    public static class Fuente
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        static FontFamily comfortaa;

        public static void CambiarFuente(List<Label> listaLabels, List<Button> listaBotones = null)
        {
            CustomFont(); 

            for (int i = 0; i < listaLabels.Count; i++)
                listaLabels[i].Font = new Font(comfortaa, listaLabels[i].Font.Size);

            if (listaBotones != null)
                for (int i = 0; i < listaBotones.Count; i++)
                {
                    listaBotones[i].Font = new Font(comfortaa, listaBotones[i].Font.Size);
                }
        }
        
        private static void CustomFont()
        {
            PrivateFontCollection new_Font = new PrivateFontCollection();

            int long_font = Properties.Resources.Comfortaa_VariableFont_wght.Length;

            byte[] fontdata = Properties.Resources.Comfortaa_VariableFont_wght;

            IntPtr replace = Marshal.AllocCoTaskMem(long_font);

            Marshal.Copy(fontdata, 0, replace, long_font);

            uint cFonts = 0;

            AddFontMemResourceEx(replace, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);

            new_Font.AddMemoryFont(replace, long_font);

            Marshal.FreeCoTaskMem(replace);

            comfortaa = new_Font.Families[0];
        }

    }
}
