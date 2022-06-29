using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParrentCntrol
{
    public partial class Form1 : Form
    {
        bool whiteStop;
        bool blackStop;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            if(textBoxBlack.Text != "")
            {
                listBoxBlack.Items.Add(textBoxBlack.Text);
                textBoxBlack.Text = "";
            }
            
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            if (textBoxWhite.Text != "")
            {
                listBoxWhite.Items.Add(textBoxWhite.Text);
                textBoxWhite.Text = "";
            }
        }

        private void buttonStartBlack_Click(object sender, EventArgs e)
        {
            blackStop = false;
            ProcessKill();
        }

        private void buttonStartWhite_Click(object sender, EventArgs e)
        {
            whiteStop = false;
            ProcessStart();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            blackStop = true;
            whiteStop = true;
        }
        async void ProcessKill()
        {
            if (listBoxBlack.Items != null)
            {
                while (!blackStop)
                {
                    foreach (var listItem in listBoxBlack.Items)
                    {
                        foreach (var item in Process.GetProcessesByName(listItem.ToString()))
                        {
                            try
                            {
                                item.Kill();
                            }
                            catch (Exception)
                            {


                            }
                        }
                    }
                    await Task.Delay(1000);
                }
            }
        }

        async void ProcessStart()
        {
            if(listBoxWhite.Items != null)
            {
                while (!whiteStop)
                {
                    foreach(var listItem in listBoxWhite.Items)
                    {
                        int processCount = 0;
                        foreach (var item in Process.GetProcessesByName(listItem.ToString()))
                        {
                            processCount++;
                        }
                        if(processCount == 0)
                        {
                            try
                            {
                                Process.Start(listItem.ToString());
                            }
                            catch (Exception)
                            {

                               
                            }
                        }
                    }
                    await Task.Delay(1000);
                }
            }
        }

        private void buttonDellBlack_Click(object sender, EventArgs e)
        {
            if (listBoxBlack.SelectedIndex >= 0) { listBoxBlack.Items.RemoveAt(listBoxBlack.SelectedIndex); }
        }

        private void buttonDellWhite_Click(object sender, EventArgs e)
        {
            if (listBoxWhite.SelectedIndex >= 0) { listBoxWhite.Items.RemoveAt(listBoxWhite.SelectedIndex); }
        }

        private void buttonStopBlack_Click(object sender, EventArgs e)
        {
            blackStop=true;
        }

        private void buttonStopWhite_Click(object sender, EventArgs e)
        {
            whiteStop=true;
        }
    }
}
