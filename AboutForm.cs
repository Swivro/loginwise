﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lain
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            t1.Interval = 50;
            t2.Interval = 50;

            t1.Start();
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            string s0 = "";
            string s1 = "d";
            string s2 = "de";
            string s3 = "dea";
            string s4 = "dead";
            string s5 = "deadm";
            string s6 = "deadmo";
            string s7 = "deadmoo";
            string s8 = "deadmoon";
            string s9 = "deadmoon © ";
            string s10 = "deadmoon © ∞";

            switch (l2.Text)
            {
                case "":
                    l2.Text = s1;
                    break;
                case "d":
                    l2.Text = s2;
                    break;
                case "de":
                    l2.Text = s3;
                    break;
                case "dea":
                    l2.Text = s4;
                    break;
                case "dead":
                    l2.Text = s5;
                    break;
                case "deadm":
                    l2.Text = s6;
                    break;
                case "deadmo":
                    l2.Text = s7;
                    break;
                case "deadmoo":
                    l2.Text = s8;
                    break;
                case "deadmoon":
                    l2.Text = s9;
                    break;
                case "deadmoon © ":
                    l2.Text = s10;
                    t2.Stop();
                    break;
                case "deadmoon © ∞":
                    l2.Text = s0;
                    break;
            }
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/hellzerg/lain");
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            const string s0 = "";
            const string s1 = "L";
            const string s2 = "La";
            const string s3 = "Lai";
            const string s4 = "Lain";

            switch (l1.Text)
            {
                case s0:
                    l1.Text = s1;
                    break;
                case s1:
                    l1.Text = s2;
                    break;
                case s2:
                    l1.Text = s3;
                    break;
                case s3:
                    l1.Text = s4;
                    t1.Stop();
                    t2.Start();
                    break;
                case s4:
                    l1.Text = s0;
                    break;
            }
        }
    }
}
