﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBase.Cheats;
using ZBase.Classes;
using ZBase.Utilities;

namespace ZBase
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Main.RunStartup())
            {
                OffsetUpdater.UpdateOffsets();
                SettingsUpdater.GetSettingsFromFileLegit();
                ChoosenSettingsComboBox.SelectedIndex = 0;
                Menu_Load();
                ucesp1.UCESP_Load();
                ucAimbot1.UCAimbot_Load();
                ucMisc1.UCMisc_Load();
                ucSkinChanger1.UCSkinChanger_Load();
                ///////////////////////////////////////
                LeftSidePanel.Height = ESPButton.Height;
                ucesp1.BringToFront();
                ucesp1.Show();
                //////////////////////////////////////
                ucAimbot1.Hide();
                ucMisc1.Hide();
                ucSkinChanger1.Hide();
                #region Start Threads
                // found the process and everything, lets start our cheats in a new thread

                Tools.InitializeG();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Glow.Run();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Misc.Run();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Aimbot.Run();
                }).Start();

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Visuals v = new Visuals();
                    v.Initialize();
                    v.Run();
                }).Start();
                #endregion
            }
        }

        private void Menu_Load()
        {
            TopMost = true; // make this hover over the game, can remove if you want
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            if (Main.I.ChoosenSettings == "Legit")
                SettingsUpdater.SaveSettingsLegit(Main.S);
            if (Main.I.ChoosenSettings == "Rage")
                SettingsUpdater.SaveSettingsRage(Main.S);
        }

        private void LoadSettingsButton_Click(object sender, EventArgs e)
        {
            if (Main.I.ChoosenSettings == "Legit")
                SettingsUpdater.GetSettingsFromFileLegit();
            if (Main.I.ChoosenSettings == "Rage")
                SettingsUpdater.GetSettingsFromFileRage();
            Menu_Load();
            ucesp1.UCESP_Load();
            ucAimbot1.UCAimbot_Load();
            ucMisc1.UCMisc_Load();
            ucSkinChanger1.UCSkinChanger_Load();
        }

        private void ESPButton_Click(object sender, EventArgs e)
        {
            panel2.Height = ESPButton.Height;
            panel2.Top = ESPButton.Top;
            ucesp1.BringToFront();
            ucesp1.Show();
            //////////////////////////////////////
            ucAimbot1.Hide();
            ucMisc1.Hide();
            ucSkinChanger1.Hide();
        }

        private void AimbotButton_Click(object sender, EventArgs e)
        {
            panel2.Height = AimbotButton.Height;
            panel2.Top = AimbotButton.Top;
            ucAimbot1.BringToFront();
            ucAimbot1.Show();
            //////////////////////////////////////
            ucesp1.Hide();
            ucMisc1.Hide();
            ucSkinChanger1.Hide();
        }

        private void MiscButton_Click(object sender, EventArgs e)
        {
            panel2.Height = MiscButton.Height;
            panel2.Top = MiscButton.Top;
            ucMisc1.BringToFront();
            ucMisc1.Show();
            //////////////////////////////////////
            ucesp1.Hide();
            ucAimbot1.Hide();
            ucSkinChanger1.Hide();
        }

        private void SkinChangerButton_Click(object sender, EventArgs e)
        {
            panel2.Height = SkinChangerButton.Height;
            panel2.Top = SkinChangerButton.Top;
            ucSkinChanger1.BringToFront();
            ucSkinChanger1.Show();
            //////////////////////////////////////
            ucesp1.Hide();
            ucAimbot1.Hide();
            ucMisc1.Hide();
        }

        private void ChoosenSettingsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChoosenSettingsComboBox.SelectedItem.ToString())
            {
                case "Legit":
                    Main.I.ChoosenSettings = "Legit";
                    break;
                case "Rage":
                    Main.I.ChoosenSettings = "Rage";
                    break;
                default:
                    break;
            }
        }
    }
}