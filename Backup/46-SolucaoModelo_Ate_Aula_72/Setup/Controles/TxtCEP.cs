﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class TxtCEP :Txt
    {
        protected override void OnCreateControl()
        {

            this.TextAlign = HorizontalAlignment.Center;
            base.OnCreateControl();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b")
                this.Text = "";

            if (e.KeyChar.ToString() == "\b")
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                int t = this.Text.Length;

                if (t == 9)
                    e.Handled = true;

                //if (t == 2)
                  //  this.Text = this.Text + ".";

                if (t == 5)
                    this.Text = this.Text + "-";

                this.SelectionStart = this.Text.Length;

            }
            else
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}