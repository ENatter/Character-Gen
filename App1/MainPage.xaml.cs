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
//using Windows.Data.Xml;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// Character Generator 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int BoostCount = 0;
        int Dex;
        int Str;
        int Con;
        int Int;
        int Wis;
        int Cha;
        string Race;
        bool Plus1 = false;
        string CharName;

        //XElement Barbarian = XElement.Load(@"class.xml");

        public MainPage()
        {
            this.InitializeComponent();
            Generate_button.Click += Generate_button_click;
            Generate_Stats.Click += Generate_Stats_click;
            Str_plus.Click += Add_Str_click;
            Dex_plus.Click += Add_Dex_click;
            Con_plus.Click += Add_Con_click;
            Int_plus.Click += Add_Int_click;
            Wis_plus.Click += Add_Wis_click;
            Cha_plus.Click += Add_Cha_click;
            Race_Select.Items.Add("Aarakocra");
            Race_Select.Items.Add("Aasimar");
            Race_Select.Items.Add("Dragonborn");
            Race_Select.Items.Add("Dwarf, Hill");
            Race_Select.Items.Add("Dwarf, Mountain");
            Race_Select.Items.Add("Elf, High");
            Race_Select.Items.Add("Elf, Wood");
            Race_Select.Items.Add("Genasi, Air");
            Race_Select.Items.Add("Genasi, Earth");
            Race_Select.Items.Add("Genasi, Fire");
            Race_Select.Items.Add("Genasi, Water");
            Race_Select.Items.Add("Gnome, Rock");
            Race_Select.Items.Add("Gnome, Deep");
            Race_Select.Items.Add("Goliath");
            Race_Select.Items.Add("Half-Elf");
            Race_Select.Items.Add("Halfling, lightfoot");
            Race_Select.Items.Add("Halfling, Stout");
            Race_Select.Items.Add("Half-Orc");
            Race_Select.Items.Add("Human");
            Race_Select.Items.Add("Orc");
            Race_Select.Items.Add("Tiefling");
            Race_Select.Items.Add("Tiefling, Feral");
            Race_Select.Items.Add("Triton");
            //Add the Classes to the drop down
            Class_Select.Items.Add("Barbarian");
            Class_Select.Items.Add("Bard");
            Class_Select.Items.Add("Cleric");
            Class_Select.Items.Add("Druid");
            Class_Select.Items.Add("Fighter");
            Class_Select.Items.Add("Monk");
            Class_Select.Items.Add("Paladin");
            Class_Select.Items.Add("Ranger");
            Class_Select.Items.Add("Rogue");
            Class_Select.Items.Add("Sorcerer");
            Class_Select.Items.Add("Warlock");
            Class_Select.Items.Add("Wizard");
        }

      
        


        private void Generate_button_click(object sender, RoutedEventArgs e)
        {
            CharName = textbox1.Text;
            Race = this.Race_Select.SelectedItem.ToString();
            Str = Convert.ToInt16(Str_in.Text);
            Dex = Convert.ToInt16(Dex_in.Text);
            Con = Convert.ToInt16(Con_in.Text);
            Int = Convert.ToInt16(Int_in.Text);
            Wis = Convert.ToInt16(Wis_in.Text);
            Cha = Convert.ToInt16(Cha_in.Text);
            Stat_Shift(Race);
            Str_in.Text = Convert.ToString(Str);
            Dex_in.Text = Convert.ToString(Dex);
            Con_in.Text = Convert.ToString(Con);
            Int_in.Text = Convert.ToString(Int);
            Wis_in.Text = Convert.ToString(Wis);
            Cha_in.Text = Convert.ToString(Cha);
            Str_mod.Text = Get_Mod(Str);
            Dex_mod.Text = Get_Mod(Dex);
            Con_mod.Text = Get_Mod(Con);
            Int_mod.Text = Get_Mod(Int);
            Wis_mod.Text = Get_Mod(Wis);
            Cha_mod.Text = Get_Mod(Cha);

        }
        private void Generate_Stats_click(object sender, RoutedEventArgs evt)
        {
            int min = 7;
            int place = 3;
            int Sum = 0;
            int[] Stats = new int[4];
            Stats[0] = getRandom();
            Stats[1] = getRandom();
            Stats[2] = getRandom();
            Stats[3] = getRandom();
            for (int i = 0; i < 4; i++)
            {
                if (Stats[i] < min)
                {
                    min = Stats[i];
                    place = i;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (i != place)
                {
                    Sum = Stats[i] + Sum;
                }

            }

            Rand_Stat.Text = Convert.ToString(Sum);
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
                case 21:
                    Mod = "+6";
                    break;
                case 22:
                    Mod = "+6";
                    break;
                default:
                    Mod = "invalid input";
                    break;
            }
            return Mod;
        }

        private void Stat_Shift(string Race)
        {
            switch (Race)
            {
                case "Aarakocra":
                    Dex += 2;
                    Wis += 1;
                    break;
                case "Aasimar":
                    Cha += 2;
                    break;
                case "Dragonborn":
                    Str += 2;
                    Cha += 1;
                    break;
                case "Dwarf, Hill":
                    Con += 2;
                    Wis += 1;
                    break;
                case "Dwarf, Mountain":
                    Con += 2;
                    Str += 2;
                    break;
                case "Elf, High":
                    Dex += 2;
                    Int += 1;
                    break;
                case "Elf, Wood":
                    Dex += 2;
                    Int += 1;
                    break;
                case "Genasi, Air":
                    Con += 2;
                    Dex += 1;
                    break;
                case "Genasi, Earth":
                    Con += 2;
                    Str += 1;
                    break;
                case "Genasi, Fire":
                    Con += 2;
                    Int += 1;
                    break;
                case "Genasi, Water":
                    Con += 2;
                    Dex += 1;
                    break;
                case "Gnome, Rock":
                    Int += 2;
                    Con += 1;
                    break;
                case "Gnome, Deep":
                    Int += 2;
                    Dex += 1;
                    break;
                case "Goliath":
                    Str += 2;
                    Con += 1;
                    break;
                case "Half-Elf":
                    Cha += 2;
                    //add +1 buttons and pop-ups for instructions
                    break;
                case "Halfling, lightfoot":
                    Dex += 2;
                    Cha += 1;
                    break;
                case "Halfling, Stout":
                    Dex += 2;
                    Con += 1;
                    break;
                case "Half-Orc":
                    Str += 2;
                    Con += 1;
                    break;
                case "Human":
                    Str += 1;
                    Dex += 1;
                    Con += 1;
                    Int += 1;
                    Wis += 1;
                    Cha += 1;
                    break;
                case "Orc":
                    Str += 2;
                    Con += 1;
                    Int -= 2;
                    break;
                case "Tiefling":
                    Cha += 2;
                    Int += 1;
                    break;
                case "Tiefling, Feral":
                    Dex += 2;
                    Int += 1;
                    break;
                case "Triton":
                    Str += 1;
                    Con += 1;
                    Cha += 1;
                    break;
            }
            if(Race == "Half-Elf" )
            {
                Str_plus.Visibility = Visibility.Visible;
                Dex_plus.Visibility = Visibility.Visible;
                Con_plus.Visibility = Visibility.Visible;
                Int_plus.Visibility = Visibility.Visible;
                Wis_plus.Visibility = Visibility.Visible;
                Cha_plus.Visibility = Visibility.Visible;
                BoostInst.Visibility = Visibility.Visible;
            }
            else
            {
                Str_plus.Visibility = Visibility.Collapsed;

            }
            //When the plus buttons are clicked, run the generate function click as well
        }

        private int getRandom()
        {
            int Stat;
            
            Random r = new Random();
            
            Stat = r.Next(1, 7);
            return Stat;
        }

        private void Add_Str_click(object sender, RoutedEventArgs e)
        {
            Str = Str + 1;
            Recalc_Stats();
        }
        private void Add_Dex_click(object sender, RoutedEventArgs e)
        {
            Dex = Dex + 1;
            Recalc_Stats();
        }
        private void Add_Con_click(object sender, RoutedEventArgs e)
        {
            Con = Con + 1;
            Recalc_Stats();
        }
        private void Add_Int_click(object sender, RoutedEventArgs e)
        {
            Int = Int + 1;
            Recalc_Stats();
        }
        private void Add_Wis_click(object sender, RoutedEventArgs e)
        {
            Wis = Wis + 1;
            Recalc_Stats();
        }
        private void Add_Cha_click(object sender, RoutedEventArgs e)
        {
            Cha = Cha + 1;
            Recalc_Stats();
        }
        private void Recalc_Stats()
        {

            Str_in.Text = Convert.ToString(Str);
            Dex_in.Text = Convert.ToString(Dex);
            Con_in.Text = Convert.ToString(Con);
            Int_in.Text = Convert.ToString(Int);
            Wis_in.Text = Convert.ToString(Wis);
            Cha_in.Text = Convert.ToString(Cha);
            Str_mod.Text = Get_Mod(Str);
            Dex_mod.Text = Get_Mod(Dex);
            Con_mod.Text = Get_Mod(Con);
            Int_mod.Text = Get_Mod(Int);
            Wis_mod.Text = Get_Mod(Wis);
            Cha_mod.Text = Get_Mod(Cha);
            BoostCount = BoostCount + 1;
            if (BoostCount == 2)
            {
                Str_plus.Visibility = Visibility.Collapsed;
                Dex_plus.Visibility = Visibility.Collapsed;
                Con_plus.Visibility = Visibility.Collapsed;
                Int_plus.Visibility = Visibility.Collapsed;
                Wis_plus.Visibility = Visibility.Collapsed;
                Cha_plus.Visibility = Visibility.Collapsed;
                BoostInst.Visibility = Visibility.Collapsed;
            }

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
        private void TextBlock_SelectionChanged_2(object sender, RoutedEventArgs e)
        {

        }
        private void int_in_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Class_Select_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void TextBlock_SelectionChanged_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
