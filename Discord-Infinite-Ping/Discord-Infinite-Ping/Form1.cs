using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace DiscordInfinitePing
{
    public partial class discordInfinitePingWindow : Form
    {
        public discordInfinitePingWindow()
        {
            InitializeComponent();
        }

        private void DiscordInfinitePingWindow_Load(object sender, EventArgs e)
        {
            minDelayBetweenPingsInput.Text = Program.CurrentSettings.MinDelayBetweenPings.ToString();
            maxDelayBetweenPingsInput.Text = Program.CurrentSettings.MaxDelayBetweenPings.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Program.StopPing();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckSettings())
            {
                return;
            }

            Save();
        }

        private void Save()
        {
            Program.CurrentSettings = new Settings(int.Parse(minDelayBetweenPingsInput.Text), int.Parse(maxDelayBetweenPingsInput.Text), Program.CurrentSettings.IsRunning);
            File.WriteAllText(Program.settingsPath, JsonConvert.SerializeObject(Program.CurrentSettings));
        }

        private bool CheckSettings()
        {
            if (!int.TryParse(minDelayBetweenPingsInput.Text, out int n))
            {
                MessageBox.Show("Please make sure \"Min Delay Between Pings\" is an integer.");
                return false;
            }
            else if (!int.TryParse(maxDelayBetweenPingsInput.Text, out int m))
            {
                MessageBox.Show("Please make sure \"Max Delay Between Pings\" is an integer.");
                return false;
            }
            else if (int.Parse(minDelayBetweenPingsInput.Text) > int.Parse(maxDelayBetweenPingsInput.Text))
            {
                MessageBox.Show("Please make sure \"Max Delay Between Pings\" is lower than \"Max Delay Between Pings\"");
                return false;
            }

            return true;
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            if (!CheckSettings())
            {
                return;
            }

            Save();

            await Program.StartPing();
        }

        private void minDelayBetweenPingsInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxDelayBetweenPingsInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
