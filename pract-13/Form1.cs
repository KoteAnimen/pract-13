using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libmass;
using findcolumns;

namespace pract_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenTable_Click(object sender, EventArgs e)
        {
            LibMass.OpenDialogToOpen(tableNumbers, openFileDialog1);
        }

        private void SaveTable_Click(object sender, EventArgs e)
        {
            LibMass.OpenDialogToSave(tableNumbers, saveFileDialog1);
        }

        private void ClearTable_Click(object sender, EventArgs e)
        {
            LibMass.ClearTable(tableNumbers);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateRandomTable_Click(object sender, EventArgs e)
        {
            LibMass.InstantRandomTable(tableNumbers);
        }

        private void CreateRandomTableContext_Click(object sender, EventArgs e)
        {
            LibMass.InstantRandomTable(tableNumbers);
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {            
            
        }

        private void FillMainTable_Click(object sender, EventArgs e)
        {
            LibMass.SizeTable(tableNumbers, (int)countColumns.Value, (int)countRows.Value);
            LibMass.FillTable(tableNumbers, (int)minNumber.Value, (int)maxNumber.Value);
        }

        private void ChangeSizeByRows(object sender, EventArgs e)
        {
            LibMass.SizeTable(tableNumbers, (int)countColumns.Value, (int)countRows.Value);
        }

        private void ChangeSiseByColumns(object sender, EventArgs e)
        {
            LibMass.SizeTable(tableNumbers, (int)countColumns.Value, (int)countRows.Value);
        }
    }
}
