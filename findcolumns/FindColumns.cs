using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace findcolumns
{
    public class FindColumns
    {
        public static int CountColumns(DataGridView dgw)
        {
            bool swichCounter;
            int counter = 0;          
            
            for(int i = 0; i < dgw.ColumnCount; i++)
            {
                swichCounter = true;
                for(int j = 0; j < dgw.RowCount - 1; j++)
                {
                    MessageBox.Show(i.ToString() + " " + j.ToString());
                    if((int)dgw.Rows[j].Cells[i].Value < (int)dgw.Rows[j + 1].Cells[i].Value)
                    {
                        swichCounter = false;
                        dgw.Rows[j].Cells[i].Style.BackColor = System.Drawing.Color.Red;
                    }
                    
                }                
                if(swichCounter == true)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
