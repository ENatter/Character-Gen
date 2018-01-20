using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int Dex;
        int Str;
        int Con;
        string CharName;

        public MainPage()
        {
            this.InitializeComponent();
            Generate_button.Click += Generate_button_click;
            
        }

      
        


        private void Generate_button_click(object sender, RoutedEventArgs e)
        {
            CharName = textbox1.Text;
            Str = Convert.ToInt32(Str_in.Text);
            Str_mod.Text = Get_Mod(Str);
            Dex = Convert.ToInt32(Dex_in.Text);
            Dex_mod.Text = Get_Mod(Dex);
            Con = Convert.ToInt32(Con_in.Text);
            Con_mod.Text = Get_Mod(Con);
        }

        private string Get_Mod(int Score)
        {
            string Mod = "+0";
            switch (Score)
            {
                case 1:
                    Mod = "-5";
                    break;
                case 2:
                    Mod = "-4";
                    break;
                case 3:
                    Mod = "-4";
                    break;
                case 4:
                    Mod = "-3";
                    break;
                case 5:
                    Mod = "-3";
                    break;
                case 6:
                    Mod = "-2";
                    break;
                case 7:
                    Mod = "-2";
                    break;
                case 8:
                    Mod = "-1";
                    break;
                case 9:
                    Mod = "-1";
                    break;
                case 10:
                    Mod = "0";
                    break;
                case 11:
                    Mod = "0";
                    break;
                case 12:
                    Mod = "+1";
                    break;
                case 13:
                    Mod = "+1";
                    break;
                case 14:
                    Mod = "+2";
                    break;
                case 15:
                    Mod = "+2";
                    break;
                case 16:
                    Mod = "+3";
                    break;
                case 17:
                    Mod = "+3";
                    break;
                case 18:
                    Mod = "+4";
                    break;
                case 19:
                    Mod = "+4";
                    break;
                case 20:
                    Mod = "+5";
                    break;
                default:
                    Mod = "invalid input";
                    break;
            }
            return Mod;
        }

        //aperantly empty functions it wants 
        private void Dex_mod_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void Con_mod_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void Str_mod_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }
        private void Str_in_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Dex_in_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Con_in_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
