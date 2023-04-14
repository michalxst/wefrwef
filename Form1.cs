using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;

namespace Qreency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           // var json = File.ReadAllText(@"test1.json");
            string json = await downloadData();
            textBox1.Text = json;
            var test1 = JsonConvert.DeserializeObject<Xchange>(json);
            
            listBox1.Items.Clear();  
            listBox1.Items.Add("AED: " + test1.rates.AED);
            listBox1.Items.Add("CAD: " + test1.rates.GBP);
            listBox1.Items.Add("EUR: " + test1.rates.GBP);
            listBox1.Items.Add("GBP: " + test1.rates.GBP);
            listBox1.Items.Add("PLN: " + test1.rates.PLN);

        
            
            
        }
        private static string Key = "a0163ce3f85646ec8f8601744522bc9a";



        private async Task<string> downloadData()
        { 
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            HttpClient client = new HttpClient();
            string call = "https://openexchangerates.org/api/historical/"+ date +".json?app_id=" +Key+"&symbols=GBP,EUR,AED,CAD,PLN";
            string json = await client.GetStringAsync(call);
            return json;
            

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
 

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
