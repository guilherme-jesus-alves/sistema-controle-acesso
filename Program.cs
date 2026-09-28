using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Acesso_Portaria
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Global.MontarStringConexao();
            frmLogin login = new frmLogin();
            DialogResult dialog = login.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
        }
    }
}
