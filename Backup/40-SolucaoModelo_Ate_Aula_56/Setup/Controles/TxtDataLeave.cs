using System;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class TxtDataLeave : Txt
    {
        protected override void OnCreateControl()
        {

            this.TextAlign = HorizontalAlignment.Center;
            base.OnCreateControl();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;

            if (this.Text.Trim() == "")
            {
                return;
            }

            try
            {
                DateTime data = Convert.ToDateTime(this.Text);
                this.Text = data.ToShortDateString();
            }
            catch
            {
                Geral.Erro("Data incorreta!");
                this.Text = "";
            }
            base.OnLostFocus(e);
        }

    }
}
