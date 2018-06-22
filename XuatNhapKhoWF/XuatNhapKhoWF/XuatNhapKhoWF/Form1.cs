using Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuatNhapKhoWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            APIHost = ConfigurationManager.AppSettings["APIHost"].ToString();
        }
        private string APIHost = string.Empty;
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var userModel = SetUserModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(APIHost + "/User/InsertUser");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var content = new StringContent(JsonConvert.SerializeObject(userModel), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(APIHost, content);
                MessageBox.Show("Success");
            }
        }
        private UserModel SetUserModel()
        {
            var userModel = new UserModel()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            return userModel;
        }
    }
}
