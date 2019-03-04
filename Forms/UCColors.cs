﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ZBase.Forms
{
    public partial class UCColors : UserControl
    {
        public UCColors()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                switch (listBox2.SelectedItem.ToString())
                {
                    case "Players":
                        Main.S.GlowPlayers = false;
                        break;
                    case "CZ75":
                        Main.S.GlowCZ75 = false;
                        break;
                    case "AK47":
                        Main.S.GlowAK47 = false;
                        break;
                    case "Deagle":
                        Main.S.GlowDeagle = false;
                        break;
                    case "AUG":
                        Main.S.GlowAUG = false;
                        break;
                    case "AWP":
                        Main.S.GlowAWP = false;
                        break;
                    case "Berettas":
                        Main.S.GlowBerettas = false;
                        break;
                    case "Bizon":
                        Main.S.GlowBizon = false;
                        break;
                    case "C4":
                        Main.S.GlowC4 = false;
                        break;
                    case "Chicken":
                        Main.S.GlowChicken = false;
                        break;
                    case "Famas":
                        Main.S.GlowFamas = false;
                        break;
                    case "Five-Seven":
                        Main.S.GlowFiveSeven = false;
                        break;
                    case "G3SG1":
                        Main.S.GlowG3SG1 = false;
                        break;
                    case "Galil":
                        Main.S.GlowGalil = false;
                        break;
                    case "Glock-18":
                        Main.S.GlowGlock18 = false;
                        break;
                    case "M249":
                        Main.S.GlowM249 = false;
                        break;
                    case "M4":
                        Main.S.GlowM4 = false;
                        break;
                    case "Mac-10":
                        Main.S.GlowMac10 = false;
                        break;
                    case "Mag-7":
                        Main.S.GlowMag7 = false;
                        break;
                    case "MP5":
                        Main.S.GlowMP5 = false;
                        break;
                    case "MP7":
                        Main.S.GlowMP7 = false;
                        break;
                    case "MP9":
                        Main.S.GlowMP9 = false;
                        break;
                    case "Negev":
                        Main.S.GlowNegev = false;
                        break;
                    case "Nova":
                        Main.S.GlowNova = false;
                        break;
                    case "P2000":
                        Main.S.GlowP2000 = false;
                        break;
                    case "P250":
                        Main.S.GlowP250 = false;
                        break;
                    case "P90":
                        Main.S.GlowP90 = false;
                        break;
                    case "Sawed-Off":
                        Main.S.GlowSawedOff = false;
                        break;
                    case "SCAR-20":
                        Main.S.GlowSCAR20 = false;
                        break;
                    case "SSG08":
                        Main.S.GlowSSG08 = false;
                        break;
                    case "Tec-9":
                        Main.S.GlowTec9 = false;
                        break;
                    case "UMP-45":
                        Main.S.GlowUMP45 = false;
                        break;
                    case "XM1014":
                        Main.S.GlowXM1014 = false;
                        break;
                    case "Taser":
                        Main.S.GlowTaser = false;
                        break;
                    case "HE Grenade":
                        Main.S.GlowHEGrenade = false;
                        break;
                    case "Molo":
                        Main.S.GlowMolo = false;
                        break;
                    case "Decoy":
                        Main.S.GlowDecoy = false;
                        break;
                    case "Smoke":
                        Main.S.GlowSmoke = false;
                        break;
                    case "Flash":
                        Main.S.GlowFlash = false;
                        break;
                    default:
                        break;
                }
                if (!Main.S.GlowPlayers)
                {
                    listBox2.Items.Remove("Players");
                    if (!listBox1.Items.Contains("Players"))
                        listBox1.Items.Add("Players");
                }
                if (!Main.S.GlowCZ75)
                {
                    listBox2.Items.Remove("CZ75");
                    if (!listBox1.Items.Contains("CZ75"))
                        listBox1.Items.Add("CZ75");
                }
                if (!Main.S.GlowAK47)
                {
                    listBox2.Items.Remove("AK47");
                    if (!listBox1.Items.Contains("AK47"))
                        listBox1.Items.Add("AK47");
                }
                if (!Main.S.GlowDeagle)
                {
                    listBox2.Items.Remove("Deagle");
                    if (!listBox1.Items.Contains("Deagle"))
                        listBox1.Items.Add("Deagle");
                }
                if (!Main.S.GlowAUG)
                {
                    listBox2.Items.Remove("AUG");
                    if (!listBox1.Items.Contains("AUG"))
                        listBox1.Items.Add("AUG");
                }
                if (!Main.S.GlowAWP)
                {
                    listBox2.Items.Remove("AWP");
                    if (!listBox1.Items.Contains("AWP"))
                        listBox1.Items.Add("AWP");
                }
                if (!Main.S.GlowBerettas)
                {
                    listBox2.Items.Remove("Berettas");
                    if (!listBox1.Items.Contains("Berettas"))
                        listBox1.Items.Add("Berettas");
                }
                if (!Main.S.GlowBizon)
                {
                    listBox2.Items.Remove("Bizon");
                    if (!listBox1.Items.Contains("Bizon"))
                        listBox1.Items.Add("Bizon");
                }
                if (!Main.S.GlowC4)
                {
                    listBox2.Items.Remove("C4");
                    if (!listBox1.Items.Contains("C4"))
                        listBox1.Items.Add("C4");
                }
                if (!Main.S.GlowChicken)
                {
                    listBox2.Items.Remove("Chicken");
                    if (!listBox1.Items.Contains("Chicken"))
                        listBox1.Items.Add("Chicken");
                }
                if (!Main.S.GlowFamas)
                {
                    listBox2.Items.Remove("Famas");
                    if (!listBox1.Items.Contains("Famas"))
                        listBox1.Items.Add("Famas");
                }
                if (!Main.S.GlowFiveSeven)
                {
                    listBox2.Items.Remove("Five-Seven");
                    if (!listBox1.Items.Contains("Five-Seven"))
                        listBox1.Items.Add("Five-Seven");
                }
                if (!Main.S.GlowG3SG1)
                {
                    listBox2.Items.Remove("G3SG1");
                    if (!listBox1.Items.Contains("G3SG1"))
                        listBox1.Items.Add("G3SG1");
                }
                if (!Main.S.GlowGalil)
                {
                    listBox2.Items.Remove("Galil");
                    if (!listBox1.Items.Contains("Galil"))
                        listBox1.Items.Add("Galil");
                }
                if (!Main.S.GlowGlock18)
                {
                    listBox2.Items.Remove("Glock-18");
                    if (!listBox1.Items.Contains("Glock-18"))
                        listBox1.Items.Add("Glock-18");
                }
                if (!Main.S.GlowM249)
                {
                    listBox2.Items.Remove("M249");
                    if (!listBox1.Items.Contains("M249"))
                        listBox1.Items.Add("M249");
                }
                if (!Main.S.GlowM4)
                {
                    listBox2.Items.Remove("M4");
                    if (!listBox1.Items.Contains("M4"))
                        listBox1.Items.Add("M4");
                }
                if (!Main.S.GlowMac10)
                {
                    listBox2.Items.Remove("Mac-10");
                    if (!listBox1.Items.Contains("Mac-10"))
                        listBox1.Items.Add("Mac-10");
                }
                if (!Main.S.GlowMag7)
                {
                    listBox2.Items.Remove("Mag-7");
                    if (!listBox1.Items.Contains("Mag-7"))
                        listBox1.Items.Add("Mag-7");
                }
                if (!Main.S.GlowMP5)
                {
                    listBox2.Items.Remove("MP5");
                    if (!listBox1.Items.Contains("MP5"))
                        listBox1.Items.Add("MP5");
                }
                if (!Main.S.GlowMP7)
                {
                    listBox2.Items.Remove("MP7");
                    if (!listBox1.Items.Contains("MP7"))
                        listBox1.Items.Add("MP7");
                }
                if (!Main.S.GlowMP9)
                {
                    listBox2.Items.Remove("MP9");
                    if (!listBox1.Items.Contains("MP9"))
                        listBox1.Items.Add("MP9");
                }
                if (!Main.S.GlowNegev)
                {
                    listBox2.Items.Remove("Negev");
                    if (!listBox1.Items.Contains("Negev"))
                        listBox1.Items.Add("Negev");
                }
                if (!Main.S.GlowNova)
                {
                    listBox2.Items.Remove("Nova");
                    if (!listBox1.Items.Contains("Nova"))
                        listBox1.Items.Add("Nova");
                }
                if (!Main.S.GlowP2000)
                {
                    listBox2.Items.Remove("P2000");
                    if (!listBox1.Items.Contains("P2000"))
                        listBox1.Items.Add("P2000");
                }
                if (!Main.S.GlowP250)
                {
                    listBox2.Items.Remove("P250");
                    if (!listBox1.Items.Contains("P250"))
                        listBox1.Items.Add("P250");
                }
                if (!Main.S.GlowP90)
                {
                    listBox2.Items.Remove("P90");
                    if (!listBox1.Items.Contains("P90"))
                        listBox1.Items.Add("P90");
                }
                if (!Main.S.GlowSawedOff)
                {
                    listBox2.Items.Remove("Sawed-Off");
                    if (!listBox1.Items.Contains("Sawed-Off"))
                        listBox1.Items.Add("Sawed-Off");
                }
                if (!Main.S.GlowSCAR20)
                {
                    listBox2.Items.Remove("SCAR-20");
                    if (!listBox1.Items.Contains("SCAR-20"))
                        listBox1.Items.Add("SCAR-20");
                }
                if (!Main.S.GlowSSG08)
                {
                    listBox2.Items.Remove("SSG08");
                    if (!listBox1.Items.Contains("SSG08"))
                        listBox1.Items.Add("SSG08");
                }
                if (!Main.S.GlowTec9)
                {
                    listBox2.Items.Remove("Tec-9");
                    if (!listBox1.Items.Contains("Tec-9"))
                        listBox1.Items.Add("Tec-9");
                }
                if (!Main.S.GlowUMP45)
                {
                    listBox2.Items.Remove("UMP-45");
                    if (!listBox1.Items.Contains("UMP-45"))
                        listBox1.Items.Add("UMP-45");
                }
                if (!Main.S.GlowXM1014)
                {
                    listBox2.Items.Remove("XM1014");
                    if (!listBox1.Items.Contains("XM1014"))
                        listBox1.Items.Add("XM1014");
                }
                if (!Main.S.GlowTaser)
                {
                    listBox2.Items.Remove("Taser");
                    if (!listBox1.Items.Contains("Taser"))
                        listBox1.Items.Add("Taser");
                }
                if (!Main.S.GlowHEGrenade)
                {
                    listBox2.Items.Remove("HE Grenade");
                    if (!listBox1.Items.Contains("HE Grenade"))
                        listBox1.Items.Add("HE Grenade");
                }
                if (!Main.S.GlowMolo)
                {
                    listBox2.Items.Remove("Molo");
                    if (!listBox1.Items.Contains("Molo"))
                        listBox1.Items.Add("Molo");
                }
                if (!Main.S.GlowDecoy)
                {
                    listBox2.Items.Remove("Decoy");
                    if (!listBox1.Items.Contains("Decoy"))
                        listBox1.Items.Add("Decoy");
                }
                if (!Main.S.GlowSmoke)
                {
                    listBox2.Items.Remove("Smoke");
                    if (!listBox1.Items.Contains("Smoke"))
                        listBox1.Items.Add("Smoke");
                }
                if (!Main.S.GlowFlash)
                {
                    listBox2.Items.Remove("Flash");
                    if (!listBox1.Items.Contains("Flash"))
                        listBox1.Items.Add("Flash");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                switch (listBox1.SelectedItem.ToString())
                {
                    case "Players":
                        Main.S.GlowPlayers = true;
                        break;
                    case "CZ75":
                        Main.S.GlowCZ75 = true;
                        break;
                    case "AK47":
                        Main.S.GlowAK47 = true;
                        break;
                    case "Deagle":
                        Main.S.GlowDeagle = true;
                        break;
                    case "AUG":
                        Main.S.GlowAUG = true;
                        break;
                    case "AWP":
                        Main.S.GlowAWP = true;
                        break;
                    case "Berettas":
                        Main.S.GlowBerettas = true;
                        break;
                    case "Bizon":
                        Main.S.GlowBizon = true;
                        break;
                    case "C4":
                        Main.S.GlowC4 = true;
                        break;
                    case "Chicken":
                        Main.S.GlowChicken = true;
                        break;
                    case "Famas":
                        Main.S.GlowFamas = true;
                        break;
                    case "Five-Seven":
                        Main.S.GlowFiveSeven = true;
                        break;
                    case "G3SG1":
                        Main.S.GlowG3SG1 = true;
                        break;
                    case "Galil":
                        Main.S.GlowGalil = true;
                        break;
                    case "Glock-18":
                        Main.S.GlowGlock18 = true;
                        break;
                    case "M249":
                        Main.S.GlowM249 = true;
                        break;
                    case "M4":
                        Main.S.GlowM4 = true;
                        break;
                    case "Mac-10":
                        Main.S.GlowMac10 = true;
                        break;
                    case "Mag-7":
                        Main.S.GlowMag7 = true;
                        break;
                    case "MP5":
                        Main.S.GlowMP5 = true;
                        break;
                    case "MP7":
                        Main.S.GlowMP7 = true;
                        break;
                    case "MP9":
                        Main.S.GlowMP9 = true;
                        break;
                    case "Negev":
                        Main.S.GlowNegev = true;
                        break;
                    case "Nova":
                        Main.S.GlowNova = true;
                        break;
                    case "P2000":
                        Main.S.GlowP2000 = true;
                        break;
                    case "P250":
                        Main.S.GlowP250 = true;
                        break;
                    case "P90":
                        Main.S.GlowP90 = true;
                        break;
                    case "Sawed-Off":
                        Main.S.GlowSawedOff = true;
                        break;
                    case "SCAR-20":
                        Main.S.GlowSCAR20 = true;
                        break;
                    case "SSG08":
                        Main.S.GlowSSG08 = true;
                        break;
                    case "Tec-9":
                        Main.S.GlowTec9 = true;
                        break;
                    case "UMP-45":
                        Main.S.GlowUMP45 = true;
                        break;
                    case "XM1014":
                        Main.S.GlowXM1014 = true;
                        break;
                    case "Taser":
                        Main.S.GlowTaser = true;
                        break;
                    case "HE Grenade":
                        Main.S.GlowHEGrenade = true;
                        break;
                    case "Molo":
                        Main.S.GlowMolo = true;
                        break;
                    case "Decoy":
                        Main.S.GlowDecoy = true;
                        break;
                    case "Smoke":
                        Main.S.GlowSmoke = true;
                        break;
                    case "Flash":
                        Main.S.GlowFlash = true;
                        break;
                    default:
                        break;
                }
                if (Main.S.GlowPlayers)
                {
                    listBox1.Items.Remove("Players");
                    if (!listBox2.Items.Contains("Players"))
                        listBox2.Items.Add("Players");
                }
                if (Main.S.GlowCZ75)
                {
                    listBox1.Items.Remove("CZ75");
                    if (!listBox2.Items.Contains("CZ75"))
                        listBox2.Items.Add("CZ75");
                }
                if (Main.S.GlowAK47)
                {
                    listBox1.Items.Remove("AK47");
                    if (!listBox2.Items.Contains("AK47"))
                        listBox2.Items.Add("AK47");
                }
                if (Main.S.GlowDeagle)
                {
                    listBox1.Items.Remove("Deagle");
                    if (!listBox2.Items.Contains("Deagle"))
                        listBox2.Items.Add("Deagle");
                }
                if (Main.S.GlowAUG)
                {
                    listBox1.Items.Remove("AUG");
                    if (!listBox2.Items.Contains("AUG"))
                        listBox2.Items.Add("AUG");
                }
                if (Main.S.GlowAWP)
                {
                    listBox1.Items.Remove("AWP");
                    if (!listBox2.Items.Contains("AWP"))
                        listBox2.Items.Add("AWP");
                }
                if (Main.S.GlowBerettas)
                {
                    listBox1.Items.Remove("Berettas");
                    if (!listBox2.Items.Contains("Berettas"))
                        listBox2.Items.Add("Berettas");
                }
                if (Main.S.GlowBizon)
                {
                    listBox1.Items.Remove("Bizon");
                    if (!listBox2.Items.Contains("Bizon"))
                        listBox2.Items.Add("Bizon");
                }
                if (Main.S.GlowC4)
                {
                    listBox1.Items.Remove("C4");
                    if (!listBox2.Items.Contains("C4"))
                        listBox2.Items.Add("C4");
                }
                if (Main.S.GlowChicken)
                {
                    listBox1.Items.Remove("Chicken");
                    if (!listBox2.Items.Contains("Chicken"))
                        listBox2.Items.Add("Chicken");
                }
                if (Main.S.GlowFamas)
                {
                    listBox1.Items.Remove("Famas");
                    if (!listBox2.Items.Contains("Famas"))
                        listBox2.Items.Add("Famas");
                }
                if (Main.S.GlowFiveSeven)
                {
                    listBox1.Items.Remove("Five-Seven");
                    if (!listBox2.Items.Contains("Five-Seven"))
                        listBox2.Items.Add("Five-Seven");
                }
                if (Main.S.GlowG3SG1)
                {
                    listBox1.Items.Remove("G3SG1");
                    if (!listBox2.Items.Contains("G3SG1"))
                        listBox2.Items.Add("G3SG1");
                }
                if (Main.S.GlowGalil)
                {
                    listBox1.Items.Remove("Galil");
                    if (!listBox2.Items.Contains("Galil"))
                        listBox2.Items.Add("Galil");
                }
                if (Main.S.GlowGlock18)
                {
                    listBox1.Items.Remove("Glock-18");
                    if (!listBox2.Items.Contains("Glock-18"))
                        listBox2.Items.Add("Glock-18");
                }
                if (Main.S.GlowM249)
                {
                    listBox1.Items.Remove("M249");
                    if (!listBox2.Items.Contains("M249"))
                        listBox2.Items.Add("M249");
                }
                if (Main.S.GlowM4)
                {
                    listBox1.Items.Remove("M4");
                    if (!listBox2.Items.Contains("M4"))
                        listBox2.Items.Add("M4");
                }
                if (Main.S.GlowMac10)
                {
                    listBox1.Items.Remove("Mac-10");
                    if (!listBox2.Items.Contains("Mac-10"))
                        listBox2.Items.Add("Mac-10");
                }
                if (Main.S.GlowMag7)
                {
                    listBox1.Items.Remove("Mag-7");
                    if (!listBox2.Items.Contains("Mag-7"))
                        listBox2.Items.Add("Mag-7");
                }
                if (Main.S.GlowMP5)
                {
                    listBox1.Items.Remove("MP5");
                    if (!listBox2.Items.Contains("MP5"))
                        listBox2.Items.Add("MP5");
                }
                if (Main.S.GlowMP7)
                {
                    listBox1.Items.Remove("MP7");
                    if (!listBox2.Items.Contains("MP7"))
                        listBox2.Items.Add("MP7");
                }
                if (Main.S.GlowMP9)
                {
                    listBox1.Items.Remove("MP9");
                    if (!listBox2.Items.Contains("MP9"))
                        listBox2.Items.Add("MP9");
                }
                if (Main.S.GlowNegev)
                {
                    listBox1.Items.Remove("Negev");
                    if (!listBox2.Items.Contains("Negev"))
                        listBox2.Items.Add("Negev");
                }
                if (Main.S.GlowNova)
                {
                    listBox1.Items.Remove("Nova");
                    if (!listBox2.Items.Contains("Nova"))
                        listBox2.Items.Add("Nova");
                }
                if (Main.S.GlowP2000)
                {
                    listBox1.Items.Remove("P2000");
                    if (!listBox2.Items.Contains("P2000"))
                        listBox2.Items.Add("P2000");
                }
                if (Main.S.GlowP250)
                {
                    listBox1.Items.Remove("P250");
                    if (!listBox2.Items.Contains("P250"))
                        listBox2.Items.Add("P250");
                }
                if (Main.S.GlowP90)
                {
                    listBox1.Items.Remove("P90");
                    if (!listBox2.Items.Contains("P90"))
                        listBox2.Items.Add("P90");
                }
                if (Main.S.GlowSawedOff)
                {
                    listBox1.Items.Remove("Sawed-Off");
                    if (!listBox2.Items.Contains("Sawed-Off"))
                        listBox2.Items.Add("Sawed-Off");
                }
                if (Main.S.GlowSCAR20)
                {
                    listBox1.Items.Remove("SCAR-20");
                    if (!listBox2.Items.Contains("SCAR-20"))
                        listBox2.Items.Add("SCAR-20");
                }
                if (Main.S.GlowSSG08)
                {
                    listBox1.Items.Remove("SSG08");
                    if (!listBox2.Items.Contains("SSG08"))
                        listBox2.Items.Add("SSG08");
                }
                if (Main.S.GlowTec9)
                {
                    listBox1.Items.Remove("Tec-9");
                    if (!listBox2.Items.Contains("Tec-9"))
                        listBox2.Items.Add("Tec-9");
                }
                if (Main.S.GlowUMP45)
                {
                    listBox1.Items.Remove("UMP-45");
                    if (!listBox2.Items.Contains("UMP-45"))
                        listBox2.Items.Add("UMP-45");
                }
                if (Main.S.GlowXM1014)
                {
                    listBox1.Items.Remove("XM1014");
                    if (!listBox2.Items.Contains("XM1014"))
                        listBox2.Items.Add("XM1014");
                }
                if (Main.S.GlowTaser)
                {
                    listBox1.Items.Remove("Taser");
                    if (!listBox2.Items.Contains("Taser"))
                        listBox2.Items.Add("Taser");
                }
                if (Main.S.GlowHEGrenade)
                {
                    listBox1.Items.Remove("HE Grenade");
                    if (!listBox2.Items.Contains("HE Grenade"))
                        listBox2.Items.Add("HE Grenade");
                }
                if (Main.S.GlowMolo)
                {
                    listBox1.Items.Remove("Molo");
                    if (!listBox2.Items.Contains("Molo"))
                        listBox2.Items.Add("Molo");
                }
                if (Main.S.GlowDecoy)
                {
                    listBox1.Items.Remove("Decoy");
                    if (!listBox2.Items.Contains("Decoy"))
                        listBox2.Items.Add("Decoy");
                }
                if (Main.S.GlowSmoke)
                {
                    listBox1.Items.Remove("Smoke");
                    if (!listBox2.Items.Contains("Smoke"))
                        listBox2.Items.Add("Smoke");
                }
                if (Main.S.GlowFlash)
                {
                    listBox1.Items.Remove("Flash");
                    if (!listBox2.Items.Contains("Flash"))
                        listBox2.Items.Add("Flash");
                }
            }
        }

        public void UCColors_Load()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox1.Items.Clear();
            if (!Main.S.GlowPlayers)
            listBox1.Items.Add("Players");
            if (!Main.S.GlowCZ75)
                listBox1.Items.Add("CZ75");
            if (!Main.S.GlowAK47)
                listBox1.Items.Add("AK47");
            if (!Main.S.GlowDeagle)
                listBox1.Items.Add("Deagle");
            if (!Main.S.GlowAUG)
                listBox1.Items.Add("AUG");
            if (!Main.S.GlowAWP)
                listBox1.Items.Add("AWP");
            if (!Main.S.GlowM4)
                listBox1.Items.Add("M4");
            if (!Main.S.GlowBizon)
                listBox1.Items.Add("Bizon");
            if (!Main.S.GlowBerettas)
                listBox1.Items.Add("Berettas");
            if (!Main.S.GlowFamas)
                listBox1.Items.Add("Famas");
            if (!Main.S.GlowFiveSeven)
                listBox1.Items.Add("Five-Seven");
            if (!Main.S.GlowG3SG1)
                listBox1.Items.Add("G3SG1");
            if (!Main.S.GlowGalil)
                listBox1.Items.Add("Galil");
            if (!Main.S.GlowGlock18)
                listBox1.Items.Add("Glock-18");
            if (!Main.S.GlowP2000)
                listBox1.Items.Add("P2000");
            if (!Main.S.GlowM249)
                listBox1.Items.Add("M249");
            if (!Main.S.GlowMac10)
                listBox1.Items.Add("Mac-10");
            if (!Main.S.GlowMag7)
                listBox1.Items.Add("Mag-7");
            if (!Main.S.GlowMP5)
                listBox1.Items.Add("MP5");
            if (!Main.S.GlowMP7)
                listBox1.Items.Add("MP7");
            if (!Main.S.GlowMP9)
                listBox1.Items.Add("MP9");
            if (!Main.S.GlowNegev)
                listBox1.Items.Add("Negev");
            if (!Main.S.GlowNova)
                listBox1.Items.Add("Nova");
            if (!Main.S.GlowP250)
                listBox1.Items.Add("P250");
            if (!Main.S.GlowP90)
                listBox1.Items.Add("P90");
            if (!Main.S.GlowSawedOff)
                listBox1.Items.Add("Sawed-Off");
            if (!Main.S.GlowSCAR20)
                listBox1.Items.Add("SCAR-20");
            if (!Main.S.GlowSSG08)
                listBox1.Items.Add("SSG08");
            if (!Main.S.GlowTec9)
                listBox1.Items.Add("Tec-9");
            if (!Main.S.GlowUMP45)
                listBox1.Items.Add("UMP-45");
            if (!Main.S.GlowXM1014)
                listBox1.Items.Add("XM1014");
            if (!Main.S.GlowTaser)
                listBox1.Items.Add("Taser");
            if (!Main.S.GlowFlash)
                listBox1.Items.Add("Flash");
            if (!Main.S.GlowSmoke)
                listBox1.Items.Add("Smoke");
            if (!Main.S.GlowMolo)
                listBox1.Items.Add("Molo");
            if (!Main.S.GlowHEGrenade)
                listBox1.Items.Add("HE Grenade");
            if (!Main.S.GlowDecoy)
                listBox1.Items.Add("Decoy");
            if (!Main.S.GlowC4)
                listBox1.Items.Add("C4");
            if (!Main.S.GlowChicken)
                listBox1.Items.Add("Chicken");

            /////////////////////////////////////////////////////////////
            listBox2.SelectionMode = SelectionMode.One;
            listBox2.Items.Clear();
            if (Main.S.GlowPlayers)
                listBox2.Items.Add("Players");
            if (Main.S.GlowCZ75)
                listBox2.Items.Add("CZ75");
            if (Main.S.GlowAK47)
                listBox2.Items.Add("AK47");
            if (Main.S.GlowDeagle)
                listBox2.Items.Add("Deagle");
            if (Main.S.GlowAUG)
                listBox2.Items.Add("AUG");
            if (Main.S.GlowAWP)
                listBox2.Items.Add("AWP");
            if (Main.S.GlowM4)
                listBox2.Items.Add("M4");
            if (Main.S.GlowBizon)
                listBox2.Items.Add("Bizon");
            if (Main.S.GlowBerettas)
                listBox2.Items.Add("Berettas");
            if (Main.S.GlowFamas)
                listBox2.Items.Add("Famas");
            if (Main.S.GlowFiveSeven)
                listBox2.Items.Add("Five-Seven");
            if (Main.S.GlowG3SG1)
                listBox2.Items.Add("G3SG1");
            if (Main.S.GlowGalil)
                listBox2.Items.Add("Galil");
            if (Main.S.GlowGlock18)
                listBox2.Items.Add("Glock-18");
            if (Main.S.GlowP2000)
                listBox2.Items.Add("P2000");
            if (Main.S.GlowM249)
                listBox2.Items.Add("M249");
            if (Main.S.GlowMac10)
                listBox2.Items.Add("Mac-10");
            if (Main.S.GlowMag7)
                listBox2.Items.Add("Mag-7");
            if (Main.S.GlowMP5)
                listBox2.Items.Add("MP5");
            if (Main.S.GlowMP7)
                listBox2.Items.Add("MP7");
            if (Main.S.GlowMP9)
                listBox2.Items.Add("MP9");
            if (Main.S.GlowNegev)
                listBox2.Items.Add("Negev");
            if (Main.S.GlowNova)
                listBox2.Items.Add("Nova");
            if (Main.S.GlowP250)
                listBox2.Items.Add("P250");
            if (Main.S.GlowP90)
                listBox2.Items.Add("P90");
            if (Main.S.GlowSawedOff)
                listBox2.Items.Add("Sawed-Off");
            if (Main.S.GlowSCAR20)
                listBox2.Items.Add("SCAR-20");
            if (Main.S.GlowSSG08)
                listBox2.Items.Add("SSG08");
            if (Main.S.GlowTec9)
                listBox2.Items.Add("Tec-9");
            if (Main.S.GlowUMP45)
                listBox2.Items.Add("UMP-45");
            if (Main.S.GlowXM1014)
                listBox2.Items.Add("XM1014");
            if (Main.S.GlowTaser)
                listBox2.Items.Add("Taser");
            if (Main.S.GlowFlash)
                listBox2.Items.Add("Flash");
            if (Main.S.GlowSmoke)
                listBox2.Items.Add("Smoke");
            if (Main.S.GlowMolo)
                listBox2.Items.Add("Molo");
            if (Main.S.GlowHEGrenade)
                listBox2.Items.Add("HE Grenade");
            if (Main.S.GlowDecoy)
                listBox2.Items.Add("Decoy");
            if (Main.S.GlowC4)
                listBox2.Items.Add("C4");
            if (Main.S.GlowChicken)
                listBox2.Items.Add("Chicken");
        }
    }
}
