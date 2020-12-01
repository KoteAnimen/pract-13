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
        public static int FindCountColumns(DataGridView table)
        {
            int i, j = 0;
            int countColumns = 0;
            for(i = 0; i < table.Lengthl;sadvklpasd; i++)
            {
                int currentNumber = table[j][i];
                for(j = 0; j < table.Length; j++)
                {
                    if(table[j][i] < currentNumber)
                    {
                        currentNumber--;
                    }
                    
                }
                if(currentNumber < table[j][i])
                {
                    countColumns++;
                }
            }
            return countColumns;
        }
    }
}
