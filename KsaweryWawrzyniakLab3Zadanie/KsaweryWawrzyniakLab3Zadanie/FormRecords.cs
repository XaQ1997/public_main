using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsaweryWawrzyniakLab3Zadanie
{
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();
        }

        private void FormRecords_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'masterDataSet.ChessRecords' . Możesz go przenieść lub usunąć.
            this.chessRecordsTableAdapter.Fill(this.masterDataSet.ChessRecords);

        }
    }
}
