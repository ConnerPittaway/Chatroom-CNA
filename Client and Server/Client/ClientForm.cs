using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Packets;

namespace Client
{
    public partial class ClientForm : Form
    {
        private Client mClient;
        public ClientForm(Client client)
        {
            InitializeComponent();
            mClient = client;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        public void UpdateChatWindow(string message)
        {
            if (MessageWindow.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    UpdateChatWindow(message);
                }));
            }
            else
            {
                MessageWindow.Text += message + Environment.NewLine;
                MessageWindow.SelectionStart = MessageWindow.Text.Length;
                MessageWindow.ScrollToCaret();
            }
        }

        public void SendPrivateMessage(string message)
        {
            string pm = "";
            string[] splitString = message.Split(' ');
            foreach (string i in splitString)
            {
                if (i.Contains("/"))
                {
                    continue;
                }
                else
                {
                    pm += (" " + i);
                }
                Console.WriteLine(pm);
            }

            if (MessageWindow.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    UpdateChatWindow(pm);
                }));
            }
            else
            {
                MessageWindow.Text += pm + Environment.NewLine;
                MessageWindow.SelectionStart = MessageWindow.Text.Length;
                MessageWindow.ScrollToCaret();
            }
        }

        public void SendRockMessage(string message)
        {

            if (MessageWindow.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    UpdateChatWindow(message);
                }));
            }
            else
            {
                MessageWindow.Text += message + Environment.NewLine;
                MessageWindow.SelectionStart = MessageWindow.Text.Length;
                MessageWindow.ScrollToCaret();
            }
        }

        public void UpdateClientList(string message)
        {
            clientList.Text += message + Environment.NewLine;
            clientList.SelectionStart = clientList.Text.Length;
            clientList.ScrollToCaret();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            if((InputField.Text.Contains("/") && InputField.Text.Contains("/Rock")) || (InputField.Text.Contains("/") && InputField.Text.Contains("/Paper")) || (InputField.Text.Contains("/") && InputField.Text.Contains("/Scissors")))
            {
                mClient.SendMessage(new RockPacket(InputField.Text));
            }
            else if (InputField.Text.Contains("/"))
            {
                mClient.SendMessage(new PrivatePacket(InputField.Text));
            }
            else
            {
                mClient.SendMessage(new ChatMessagePacket(InputField.Text));
            }
           
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            mClient.SendMessage(new NicknamePacket(nTextBox.Text));
            nTextBox.Enabled = false;
            nButton.Enabled = false;
            UpdateClientList(nTextBox.Text);
        }

        private void nTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientList_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageWindow_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vaporWaveBtn_Click(object sender, EventArgs e)
        {
            ClientForm.ActiveForm.BackgroundImage = Properties.Resources.vapor;
            titleLabel.ForeColor = System.Drawing.Color.White;
            MessageWindow.BackColor = System.Drawing.Color.Violet;
            MessageWindow.ForeColor = System.Drawing.Color.White;
            InputField.BackColor = System.Drawing.Color.Violet;
            SubmitButton.BackColor = System.Drawing.Color.Violet;
            SubmitButton.ForeColor = System.Drawing.Color.White;
            themeBox.BackColor = System.Drawing.Color.Violet;
            themeLabel.ForeColor = System.Drawing.Color.White;
            nTextBox.BackColor = System.Drawing.Color.Violet;
            nButton.BackColor = System.Drawing.Color.Violet;
            nButton.ForeColor = System.Drawing.Color.White;
            clientList.BackColor = System.Drawing.Color.Violet;
            clientLabel.ForeColor = System.Drawing.Color.White;

        }

        private void polygonBtn_Click(object sender, EventArgs e)
        {
            ClientForm.ActiveForm.BackgroundImage = Properties.Resources.polygon;
            titleLabel.ForeColor = System.Drawing.Color.White;
            MessageWindow.BackColor = System.Drawing.Color.RosyBrown;
            MessageWindow.ForeColor = System.Drawing.Color.White;
            InputField.BackColor = System.Drawing.Color.RosyBrown;
            SubmitButton.BackColor = System.Drawing.Color.RosyBrown;
            SubmitButton.ForeColor = System.Drawing.Color.White;
            themeBox.BackColor = System.Drawing.Color.RosyBrown;
            themeLabel.ForeColor = System.Drawing.Color.White;
            nTextBox.BackColor = System.Drawing.Color.RosyBrown;
            nButton.BackColor = System.Drawing.Color.RosyBrown;
            nButton.ForeColor = System.Drawing.Color.White;
            clientList.BackColor = System.Drawing.Color.RosyBrown;
        }

        private void amongBtn_Click(object sender, EventArgs e)
        {
            ClientForm.ActiveForm.BackgroundImage = Properties.Resources.AmongUs;
            titleLabel.ForeColor = System.Drawing.Color.White;
            MessageWindow.BackColor = System.Drawing.Color.White;
            MessageWindow.ForeColor = System.Drawing.Color.Black;
            InputField.BackColor = System.Drawing.Color.White;
            SubmitButton.BackColor = System.Drawing.Color.White;
            SubmitButton.ForeColor = System.Drawing.Color.Black;
            themeBox.BackColor = System.Drawing.Color.Gray;
            themeLabel.ForeColor = System.Drawing.Color.White;
            nTextBox.BackColor = System.Drawing.Color.White;
            nButton.BackColor = System.Drawing.Color.White;
            nButton.ForeColor = System.Drawing.Color.Black;
            clientList.BackColor = System.Drawing.Color.White;
            clientLabel.ForeColor = System.Drawing.Color.White;
        }

        private void duskBtn_Click(object sender, EventArgs e)
        {
            ClientForm.ActiveForm.BackgroundImage = Properties.Resources.dusk;
            titleLabel.ForeColor = System.Drawing.Color.White;
            MessageWindow.BackColor = System.Drawing.Color.Thistle;
            MessageWindow.ForeColor = System.Drawing.Color.White;
            InputField.BackColor = System.Drawing.Color.Thistle;
            SubmitButton.BackColor = System.Drawing.Color.Thistle;
            SubmitButton.ForeColor = System.Drawing.Color.Black;
            themeBox.BackColor = System.Drawing.Color.Thistle;
            themeLabel.ForeColor = System.Drawing.Color.White;
            nTextBox.BackColor = System.Drawing.Color.Thistle;
            nButton.BackColor = System.Drawing.Color.Thistle;
            nButton.ForeColor = System.Drawing.Color.Black;
            clientList.BackColor = System.Drawing.Color.Thistle;
            clientLabel.ForeColor = System.Drawing.Color.White;
        }

        private void alohaBtn_Click(object sender, EventArgs e)
        {
            ClientForm.ActiveForm.BackgroundImage = Properties.Resources.Aloha;
            titleLabel.ForeColor = System.Drawing.Color.Black;
            MessageWindow.BackColor = System.Drawing.Color.Honeydew;
            MessageWindow.ForeColor = System.Drawing.Color.Black;
            InputField.BackColor = System.Drawing.Color.Honeydew;
            SubmitButton.BackColor = System.Drawing.Color.Honeydew;
            SubmitButton.ForeColor = System.Drawing.Color.Black;
            themeBox.BackColor = System.Drawing.Color.Honeydew;
            themeLabel.ForeColor = System.Drawing.Color.Black;
            nTextBox.BackColor = System.Drawing.Color.Honeydew;
            nButton.BackColor = System.Drawing.Color.Honeydew;
            nButton.ForeColor = System.Drawing.Color.Black;
            clientList.BackColor = System.Drawing.Color.Honeydew;
            clientLabel.ForeColor = System.Drawing.Color.Black;
        }
    }
}
