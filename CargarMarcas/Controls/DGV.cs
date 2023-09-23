using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarMarcas.Controls
{

    public class DGV : DataGridView
    {

        private bool moveLeftToRight = false;

        public bool MoveLeftToRight
        {
            get { return moveLeftToRight; }
            set { moveLeftToRight = value; }
        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (moveLeftToRight)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    MoveToNextCell();
                }
                else
                {
                    base.OnKeyDown(e);
                }
            }
            else
            {
                base.OnKeyDown(e);
            }
        }


        protected void MoveToNextCell()
        {
            int CurrentColumn, CurrentRow;

            //get the current indicies of the cell
            CurrentColumn = this.CurrentCell.ColumnIndex;
            CurrentRow = this.CurrentCell.RowIndex;

            int colCount = 0;

            for (int i = 0; i < this.Columns.Count; i++)
            {
                if (this.Columns[i].Visible == true)
                {
                    colCount = i; //Get the last visible column.
                }
            }

            if (CurrentColumn == colCount &&
                CurrentRow != this.Rows.Count - 1)
            //cell is at the end move it to the first cell of the next row
            {
                base.ProcessDataGridViewKey(new KeyEventArgs(Keys.Home));
                base.ProcessDataGridViewKey(new KeyEventArgs(Keys.Down));
            }
            else // move it to the next cell
            {
                base.ProcessDataGridViewKey(new KeyEventArgs(Keys.Right));
            }
        }
    }

}
