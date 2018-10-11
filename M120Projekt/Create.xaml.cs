﻿using M120Projekt.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für Create.xaml
    /// </summary>
    public partial class Create : UserControl
    {
        private 
        private Regex regexInt = new Regex("^[0-9]+$");
        private Regex regexString = new Regex("^[a-zA-Z]+$");

        public Create()
        {
            InitializeComponent();
            InitDropDownGeneration();
            InitDropDownsTyp();
        }

        private void ChangeViewListener(object sender)
        {
            Button btn = (Button)sender;
            Popup popup = new Popup(this, btn);
            IsEnabled = false;
            popup.Show();
        }

        public UserControl ChangeView(String view)
        {
            switch (view)
            {
                case "Create":
                    return this;

                case "Search":
                    return new Search();

                case "Home":
                    return new Home();

            }
            return this;
        }

        public void validateTextBox(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            Label lbl = (Label)this.FindName("lbl_" + txt.Name.Split('_')[1]);
            String datatype = txt.Name.Split('_')[2];
            if (datatype.Equals("String"))
            {
                if (regexString.IsMatch(txt.Text) || txt.Text.Equals(""))
                {
                    btn_Create.IsEnabled = true;
                    lbl.Foreground = Brushes.Black;
                }
                else
                {
                    btn_Create.IsEnabled = false;
                    lbl.Foreground = Brushes.Red;
                }
            }
        }

        public void InitDropDownsTyp()
        {
            dd_Typen1.Items.Add("Normal");
            dd_Typen1.Items.Add("Kampf");
            dd_Typen1.Items.Add("Flug");
            dd_Typen1.Items.Add("Gift");
            dd_Typen1.Items.Add("Boden");
            dd_Typen1.Items.Add("Gestein");
            dd_Typen1.Items.Add("Käfer");
            dd_Typen1.Items.Add("Geist");
            dd_Typen1.Items.Add("Stahl");
            dd_Typen1.Items.Add("Feuer");
            dd_Typen1.Items.Add("Wasser");
            dd_Typen1.Items.Add("Pflanze");
            dd_Typen1.Items.Add("Elektro");
            dd_Typen1.Items.Add("Psycho");
            dd_Typen1.Items.Add("Eis");
            dd_Typen1.Items.Add("Drache");
            dd_Typen1.Items.Add("Unlicht");
            dd_Typen1.Items.Add("Fee");
            dd_Typen1.SelectedIndex = 0;

            dd_Typen2.Items.Add("Keinen");
            dd_Typen2.Items.Add("Normal");
            dd_Typen2.Items.Add("Kampf");
            dd_Typen2.Items.Add("Flug");
            dd_Typen2.Items.Add("Gift");
            dd_Typen2.Items.Add("Boden");
            dd_Typen2.Items.Add("Gestein");
            dd_Typen2.Items.Add("Käfer");
            dd_Typen2.Items.Add("Geist");
            dd_Typen2.Items.Add("Stahl");
            dd_Typen2.Items.Add("Feuer");
            dd_Typen2.Items.Add("Wasser");
            dd_Typen2.Items.Add("Pflanze");
            dd_Typen2.Items.Add("Elektro");
            dd_Typen2.Items.Add("Psycho");
            dd_Typen2.Items.Add("Eis");
            dd_Typen2.Items.Add("Drache");
            dd_Typen2.Items.Add("Unlicht");
            dd_Typen2.Items.Add("Fee");
            dd_Typen2.SelectedIndex = 0;
        }

        public void InitDropDownGeneration()
        {
            dd_Generation.Items.Add("Alle");
            dd_Generation.Items.Add("1");
            dd_Generation.Items.Add("2");
            dd_Generation.Items.Add("3");
            dd_Generation.Items.Add("4");
            dd_Generation.Items.Add("5");
            dd_Generation.Items.Add("6");
            dd_Generation.Items.Add("7");
            dd_Generation.SelectedIndex = 0;
        }

    }
}
