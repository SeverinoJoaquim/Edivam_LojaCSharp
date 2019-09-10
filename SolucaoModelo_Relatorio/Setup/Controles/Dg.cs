using System.Drawing;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class dg : DataGridView
    {
        protected override void OnCreateControl()
        {
            this.TabStop = false;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.GridColor = Color.Black;
            this.RowHeadersWidth = 10;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            this.BackgroundColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            base.OnCreateControl();
        }
    }
}
