using System;
using System.Linq;
using System.Windows.Forms;
using MXM_Porter.MODEL;
using MXM_Porter.DBC;
using System.Configuration;
using MXM_Porter;



namespace MXM_Porter
{
    public partial class Form1 : Form
    {
        private Query_Insert TransferData; 
 

        public Form1()
        {
            InitializeComponent();
            TransferData = new Query_Insert();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var server1Data = TransferData.GetServer1Data();
                TransferData.TransferDataToServer2(server1Data);
                MessageBox.Show("Data transferred successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}