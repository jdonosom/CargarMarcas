using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFarmacia.Controls
{
    //
    // Resumen:
    //     Muestra una ventana de mensaje, también conocida como cuadro de diálogo, que
    //     presenta un mensaje al usuario. Es una ventana modal que bloquea otras acciones
    //     en la aplicación hasta que el usuario la cierra. Un System.Windows.Forms.MessageBox
    //     puede contener texto, botones y símbolos que informan e dan instrucciones al
    //     usuario.
    public abstract class RJMessageBox
    {
        public static DialogResult Show(string text)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons, icon))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog();
            return result;
        }

        /*-> IWin32Window Owner:
            *      Displays a message box in front of the specified object and with the other specified parameters.
            *      An implementation of IWin32Window that will own the modal dialog box.*/
        public static DialogResult Show(IWin32Window owner, string text)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons, icon))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog(owner);
            return result;
        }
    }
}
