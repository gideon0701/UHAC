using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
namespace textBeltTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static readonly HttpClient client = new HttpClient();


        private async void button1_Click(object sender, EventArgs e)
        {

            var values = new Dictionary<string, string>
        { //639569366560
            {"message_type","SEND"},
                {"mobile_number","639569366560" },
                {"shortcode","29290398" },
                {"message_id","0192oeks12d2iske9difuthwne2E34ee" },  // message id needs to be unique in every message
                {"message","Hello world! ang pogi mo!" },
                {"client_id","028f8b978f4a1de2e0973146d3c6b222d76909cf0e4b2e0ccf322ba14a65b7e7" },
                {"secret_key","828623c3b0d29d8ca7eb75a48cd484fc3f7cd9c7d9b658d2e7ea8cff0291d69b" },

        };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://post.chikka.com/smsapi/request", content);
            var responseString = await response.Content.ReadAsStringAsync();


            var getResponse = await client.GetStringAsync("https://post.chikka.com/smsapi/request");

            richTextBox1.Text = getResponse.ToString();
        }
    }


}

