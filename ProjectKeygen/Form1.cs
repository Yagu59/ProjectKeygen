using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Wrider;

namespace ProjectKeygen
{
    public partial class WW3Form : Form
    {
        private static Random random = new Random();
        private static WW3Form ww3Form;
        private Configen configen = new Configen();

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        private string aboutContext;

        private float audioVolume = 0.05f;
        private int? settingsDeviceNum;

        public WW3Form()
        {
            InitializeComponent();
            if (ww3Form == null)
            {
                ww3Form = this;
            }
        }

        private void WW3Form_Load(object sender, EventArgs e)
        {
            serialText.Text = string.Empty;
            aboutContext = $"WW3 Runner by {teamLabel.Text}";
            configen = Wrider.File.LoadJson<Configen>(Application.StartupPath + "\\data", "config.json");
            if (configen.softwareName == null) configen = DefaultConfig();
            SetConfigData(configen);
            configen.log.LOAD_NUMBER = GenerateRandomString(12).ToString();
            Wrider.File.SaveJson(configen, Application.StartupPath + "\\data", "config.json");
            MusicPlayer();
        }

        private void MusicPlayer()
        {
            string folderPath = $@"{Application.StartupPath}\data\audio";

            string[] mp3Files = Directory.GetFiles(folderPath, "*.mp3");
#if DEBUG
            MessageBox.Show(mp3Files[0]);
#endif
            if (mp3Files.Length == 0)
            {
                Application.ExitThread();
                return;
            }

            string randomMp3File = mp3Files[random.Next(mp3Files.Length)];

            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
            else
            {
                outputDevice?.Stop();
                audioFile?.Dispose();
            }

            audioFile = new AudioFileReader(randomMp3File);
            audioFile.Volume = audioVolume;

            var devices = Enumerable.Range(0, WaveOut.DeviceCount)
                                        .Select(index => new { Index = index, DeviceInfo = WaveOut.GetCapabilities(index) })
                                        .ToList();

            int selectedDeviceIndex = devices.First().Index;
            outputDevice.DeviceNumber = selectedDeviceIndex;

            outputDevice?.Init(audioFile);
            outputDevice?.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            serialText.Text = $"{GenerateRandomString(4)}-{GenerateRandomString(4)}-{GenerateRandomString(4)}-{GenerateRandomString(4)}";
        }


        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }

            return new string(result);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aboutContext);
        }

        private Configen DefaultConfig()
        {
            var config = new Configen();
            config.softwareName = ww3Form.Text;
            config.labelContext = softwareLabel.Text;
            config.aboutContext = aboutContext;
            config.teamName = teamLabel.Text;
            config.generateButtonContext = generateButton.Text;

            config.audioSettings.volume = audioVolume;
            return config;
        }

        private void SetConfigData(Configen config)
        {
            ww3Form.Text = config.softwareName;
            softwareLabel.Text = config.labelContext;
            aboutContext = config.aboutContext;
            teamLabel.Text = config.teamName;
            generateButton.Text = config.generateButtonContext;

            audioVolume = config.audioSettings.volume;
            settingsDeviceNum = config.audioSettings.deviceNumber;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            outputDevice?.Dispose();
            audioFile?.Dispose();
            base.OnFormClosing(e);
        }

        private void softwareLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (outputDevice.PlaybackState == PlaybackState.Playing) outputDevice?.Stop();
            else MusicPlayer();
        }
    }
}
