using System;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class TxtNumero2 : TxtNumero
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\b")
            {
                return;
            }

            if (this.Text.Contains(","))
            {
                string[] a = this.Text.Split(',');
                if (a[1].Length == 1)
                {
                    e.Handled = true;
                }
            }

            base.OnKeyPress(e);
        }
    }
}
