using System;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class Txt : TextBox
    {
        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            base.OnCreateControl();
        }
        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
            this.SelectAll();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b")
                this.Text = "";
                base.OnKeyPress(e);
        }
    }
}
