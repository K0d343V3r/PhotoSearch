using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoSearch
{
    public partial class MainForm : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly string _basePath =
            $"https://api.unsplash.com/photos/random?client_id={ConfigurationManager.AppSettings["client_id"]}";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void _searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri($"{_basePath}&query={Uri.EscapeDataString(_subjectText.Text)}");
                var response = await _httpClient.GetStringAsync(uri);
                _photoBox.LoadAsync(GetPictureUrl(response));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetPictureUrl(string result)
        {
            var data = JObject.Parse(result);
            return (string)data["urls"]["small"];
        }
    }
}
