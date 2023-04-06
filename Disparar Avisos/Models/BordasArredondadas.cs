using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disparar_Avisos.Models
{
    internal class BordasArredondadas
    {
        private const int GWL_STYLE = -16;
        private const int WS_BORDER = 0x00800000;
        private const int WS_THICKFRAME = 0x00040000;
        private const int WS_MINIMIZEBOX = 0x00020000;
        private const int WS_MAXIMIZEBOX = 0x00010000;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static void SetBorderlessStyle(Form form)
        {
            // Define o estilo da janela para remover as bordas e os botões de minimizar e maximizar.
            IntPtr handle = form.Handle;
            IntPtr style = (IntPtr)(WS_BORDER | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);
            SetWindowLongPtr(handle, GWL_STYLE, style);

            // Define o tamanho e a posição da janela com base na resolução da tela.
            RECT rect;
            GetWindowRect(handle, out rect);
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            form.Bounds = new Rectangle((screenWidth - rect.Right + rect.Left) / 2,
                                         (screenHeight - rect.Bottom + rect.Top) / 2,
                                         rect.Right - rect.Left,
                                         rect.Bottom - rect.Top);
        }
    }
}
