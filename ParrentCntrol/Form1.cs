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
        bool close;
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
            ProcessKill();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
        }
        async void ProcessKill()
        {
            if (listBoxBlack.Items != null)
            {
                while (!close)
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
                while (!close)
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

        private void buttonStartWhite_Click(object sender, EventArgs e)
        {
            ProcessStart();
        }
    }
}
