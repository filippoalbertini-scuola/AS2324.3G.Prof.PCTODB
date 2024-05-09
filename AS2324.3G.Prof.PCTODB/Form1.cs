using System.Data;

namespace AS2324._3G.Prof.PCTODB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElencoPiloti_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/

            // imposta la connessione

            // sqlite Data Source=c:\mydb.db;Version=3;
            strConnessione = "Data Source=" + @"C:\Appl\Scuola\AS_2023_2024\3G\AS2324.3G.Prof.PCTODB\AS2324.3G.Prof.PCTODB\DB\MotoGP.db" + ";Version=3;";
        }
    }
}
