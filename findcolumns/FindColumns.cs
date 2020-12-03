using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace findcolumns
{
    public class FindColumns
    {
        public static int CountColumns(DataGridView dgw)
        {
            bool swichCounter = false;
            int counter = 0;
            int currentNumber = 0;
            int i, j = 0;
            for(i = 0; i < dgw.ColumnCount; i++)
            {
                currentNumber = (int)dgw[j, i].Value;
                for(j = 0; j < dgw.RowCount; i++)
                {
                    if(currentNumber < (int)dgw[i, j].Value)
                    {
                        currentNumber--;
                        swichCounter = true;
                    }
                    else
                    {
                        swichCounter = true;
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
