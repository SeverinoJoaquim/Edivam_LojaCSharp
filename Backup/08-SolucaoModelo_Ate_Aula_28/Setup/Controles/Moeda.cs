using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class Moeda : Txt
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }
        
        protected override void OnLostFocus(EventArgs e)
        {

            if (this.Text != "")
            {
                string valor = this.Text;
                valor = valor.Replace("R$", "");
                valor = valor.Replace(".", "");
                valor = valor.Trim();

                this.Text = Convert.ToDouble(valor).ToString("c");

                this.Text = this.Text.Replace("R$", "R$ ");
            }
            
            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b")
                this.Text = "";

            if (e.KeyChar.ToString() == "\b")
            {
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if(e.KeyChar == ',' && this.Text.Contains(","))
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}

