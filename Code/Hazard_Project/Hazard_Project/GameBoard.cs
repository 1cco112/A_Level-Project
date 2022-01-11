using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Hazard_Project
{
    public partial class GameBoard : Form
    {
        //Creating objects of country class for each region 
        Country Greenland_Region = new Country("Greenland_Region");
        Country Alaska_Region = new Country("Alaska_Region");
        Country North_West_Territory_Region = new Country("North_West_Territory_Region");
        Country Alberta_Region = new Country("Alberta_Region");
        Country Ontario_Region = new Country("Ontario_Region");
        Country Quebec_Region = new Country("Quebec_Region");
        Country Western_United_States_Region = new Country("Western_United_States_Region");
        Country Eastern_United_States_Region = new Country("Eastern_United_States_Region");
        Country Central_America_Region = new Country("Central_America_Region");
        Country Venezuela_Region = new Country("Venezuela_Region");
        Country Brazil_Region = new Country("Brazil_Region");
        Country Peru_Region = new Country("Peru_Region");
        Country Argentina_Region = new Country("Argentina_Region");
        Country Egypt_Region = new Country("Egypt_Region");
        Country North_Africa_Region = new Country("North_Africa_Region");
        Country East_Africa_Region = new Country("East_Africa_Region");
        Country Congo_Region = new Country("Congo_Region");
        Country Madagascar_Region = new Country("Madagascar_Region");
        Country South_Africa_Region = new Country("South_Africa_Region");
        Country Iceland_Region = new Country("Iceland_Region");
        Country Scandinavia_Region = new Country("Scandinavia_Region");
        Country Ukraine_Region = new Country("Ukraine_Region");
        Country Northern_Europe_Region = new Country("Northern_Europe_Region");
        Country Great_Britain_Region = new Country("Great_Britain_Region");
        Country Western_Europe_Region = new Country("Western_Europe_Region");
        Country Southern_Europe_Region = new Country("Southern_Europe_Region");
        Country Indonesia_Region = new Country("Indonesia_Region");
        Country New_Guinea_Region = new Country("New_Guinea_Region");
        Country Western_Australia_Region = new Country("Western_Australia_Region");
        Country Eastern_Australia_Region = new Country("Eastern_Australia_Region");
        Country Kamchatka_Region = new Country("Kamchatka_Region");
        Country Yakutsk_Region = new Country("Yakutsk_Region");
        Country Siberia_Region = new Country("Siberia_Region");
        Country Ural_Region = new Country("Ural_Region");
        Country Irkutsk_Region = new Country("Irkutsk_Region");
        Country Japan_Region = new Country("Japan_Region");
        Country Mongolia_Region = new Country("Mongolia_Region");
        Country Afghanistan_Region = new Country("Afghanistan_Region");
        Country China_Region = new Country("China_Region");
        Country Middle_East_Region = new Country("Middle_East_Region");
        Country India_Region = new Country("India_Region");
        Country Siam_Region = new Country("Siam_Region");

        //Creating linked list for each region
        AdjacencyListRegions Greenland_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Alaska_List = new AdjacencyListRegions(3);
        AdjacencyListRegions North_West_Territory_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Alberta_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Ontario_List = new AdjacencyListRegions(5);
        AdjacencyListRegions Quebec_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Western_United_States_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Eastern_United_States_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Central_America_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Venezuela_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Brazil_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Peru_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Argentina_List = new AdjacencyListRegions(2);
        AdjacencyListRegions Egypt_List = new AdjacencyListRegions(4);
        AdjacencyListRegions North_Africa_List = new AdjacencyListRegions(5);
        AdjacencyListRegions East_Africa_List = new AdjacencyListRegions(5);
        AdjacencyListRegions Congo_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Madagascar_List = new AdjacencyListRegions(2);
        AdjacencyListRegions South_Africa_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Iceland_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Scandinavia_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Ukraine_List = new AdjacencyListRegions(6);
        AdjacencyListRegions Northern_Europe_List = new AdjacencyListRegions(5);
        AdjacencyListRegions Great_Britain_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Western_Europe_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Southern_Europe_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Indonesia_List = new AdjacencyListRegions(3);
        AdjacencyListRegions New_Guinea_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Western_Australia_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Eastern_Australia_List = new AdjacencyListRegions(2);
        AdjacencyListRegions Kamchatka_List = new AdjacencyListRegions(5);
        AdjacencyListRegions Yakutsk_List = new AdjacencyListRegions(3);
        AdjacencyListRegions Siberia_List = new AdjacencyListRegions(5);
        AdjacencyListRegions Ural_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Irkutsk_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Japan_List = new AdjacencyListRegions(2);
        AdjacencyListRegions Mongolia_List = new AdjacencyListRegions(5);
        AdjacencyListRegions Afghanistan_List = new AdjacencyListRegions(5);
        AdjacencyListRegions China_List = new AdjacencyListRegions(6);
        AdjacencyListRegions Middle_East_List = new AdjacencyListRegions(5);
        AdjacencyListRegions India_List = new AdjacencyListRegions(4);
        AdjacencyListRegions Siam_List = new AdjacencyListRegions(3);

        public static int Game_State = (Convert.ToInt32(Game_Period.Place_Troops_Initial));
        public static int Number_Of_Players = 0, Num_Troops_Attacking = 0, Current_Player = 0, First_Player = 0, Remaining_Countries = 42, count = 0, Players_Complete = 0;
        public static List<Player> Players_In_Game = new List<Player>();
        public static List<Country> Africa = new List<Country>();
        public static List<Country> Asia = new List<Country>();
        public static List<Country> Australia = new List<Country>();
        public static List<Country> Europe = new List<Country>();
        public static List<Country> North_America = new List<Country>();
        public static List<Country> South_America = new List<Country>();
        public static List<Country> List_Reachable_Regions = new List<Country>();
        public static Country Country_Selected_Attack, Country_Selected_Defend, Country_Selected_Reinforce, Country_Selected_Reinforce_To;
        public static Button Region_Selected_Defend_Button, Region_Selected_Attack_Button, Region_Selected_Reinforce_Button, Region_Selected_Reinforce_To_Button;
        public static List<int> Attacker_Dice_Rolls = new List<int>();
        public static List<int> Defender_Dice_Rolls = new List<int>();
        public static string Winner = "";
        public static Random Random_Number = new Random();
        public enum Game_Period { Place_Troops_Initial, Place_Troops_Remaining, Fortify, Attack_Initial, Attack_Player, Reinforce, Reinforce_Move }
        public GameBoard()
        {
            //hides all the controls that aren't needed and sets form up for the start of the game
            InitializeComponent();
            Check_Win.Start();
            HelpText.Text = ("Please click play when you are ready to start the game.");
            Player_Selection_List.Hide();
            Player_Name_Enter.Hide();
            Advance_Game.Hide();
            Static_Label.Hide();
            Troops_To_Place.Hide();
            Finish_Game.Hide();
            Hide_Attack_Phase();
            Hide_Buttons();
            //adds all the connecting regions to each indiviual region
            Greenland_List.Add_Edge(Iceland_Region, North_West_Territory_Region, Quebec_Region, Ontario_Region);
            Alaska_List.Add_Edge(North_West_Territory_Region, Alberta_Region, Kamchatka_Region);
            North_West_Territory_List.Add_Edge(Greenland_Region, Ontario_Region, Alberta_Region, Alaska_Region);
            Alberta_List.Add_Edge(Alaska_Region, North_West_Territory_Region, Ontario_Region, Western_United_States_Region);
            Ontario_List.Add_Edge(Quebec_Region, Eastern_United_States_Region, Western_United_States_Region, Alberta_Region, North_West_Territory_Region);
            Quebec_List.Add_Edge(Greenland_Region, Eastern_United_States_Region, Ontario_Region);
            Western_United_States_List.Add_Edge(Alberta_Region, Ontario_Region, Eastern_United_States_Region, Central_America_Region);
            Eastern_United_States_List.Add_Edge(Quebec_Region, Ontario_Region, Western_United_States_Region, Central_America_Region);
            Central_America_List.Add_Edge(Eastern_United_States_Region, Western_United_States_Region, Venezuela_Region);
            Venezuela_List.Add_Edge(Central_America_Region, Brazil_Region, Peru_Region);
            Brazil_List.Add_Edge(Venezuela_Region, Peru_Region, Argentina_Region, North_Africa_Region);
            Peru_List.Add_Edge(Venezuela_Region, Brazil_Region, Argentina_Region);
            Argentina_List.Add_Edge(Peru_Region, Brazil_Region);
            Egypt_List.Add_Edge(Southern_Europe_Region, Middle_East_Region, East_Africa_Region, North_Africa_Region);
            North_Africa_List.Add_Edge(Western_Europe_Region, Egypt_Region, East_Africa_Region, Congo_Region, Brazil_Region);
            East_Africa_List.Add_Edge(Egypt_Region, North_Africa_Region, Congo_Region, South_Africa_Region, Madagascar_Region);
            Congo_List.Add_Edge(North_Africa_Region, East_Africa_Region, South_Africa_Region);
            Madagascar_List.Add_Edge(East_Africa_Region, South_Africa_Region);
            South_Africa_List.Add_Edge(Congo_Region, East_Africa_Region, Madagascar_Region);
            Iceland_List.Add_Edge(Greenland_Region, Scandinavia_Region, Great_Britain_Region);
            Scandinavia_List.Add_Edge(Ukraine_Region, Northern_Europe_Region, Great_Britain_Region, Iceland_Region);
            Ukraine_List.Add_Edge(Scandinavia_Region, Ural_Region, Afghanistan_Region, Southern_Europe_Region, Northern_Europe_Region, Middle_East_Region);
            Northern_Europe_List.Add_Edge(Great_Britain_Region, Scandinavia_Region, Ukraine_Region, Southern_Europe_Region, Western_Europe_Region);
            Great_Britain_List.Add_Edge(Iceland_Region, Scandinavia_Region, Northern_Europe_Region, Western_Europe_Region);
            Western_Europe_List.Add_Edge(Great_Britain_Region, Northern_Europe_Region, Southern_Europe_Region, North_Africa_Region);
            Southern_Europe_List.Add_Edge(Western_Europe_Region, Northern_Europe_Region, Ukraine_Region, Egypt_Region);
            Indonesia_List.Add_Edge(Siam_Region, New_Guinea_Region, Western_Australia_Region);
            New_Guinea_List.Add_Edge(Indonesia_Region, Western_Australia_Region, Eastern_Australia_Region);
            Western_Australia_List.Add_Edge(Indonesia_Region, New_Guinea_Region, Eastern_Australia_Region);
            Eastern_Australia_List.Add_Edge(New_Guinea_Region, Western_Australia_Region);
            Kamchatka_List.Add_Edge(Alaska_Region, Yakutsk_Region, Irkutsk_Region, Mongolia_Region, Japan_Region);
            Yakutsk_List.Add_Edge(Kamchatka_Region, Irkutsk_Region, Siberia_Region);
            Siberia_List.Add_Edge(Yakutsk_Region, Irkutsk_Region, Mongolia_Region, China_Region, Ural_Region);
            Ural_List.Add_Edge(Siberia_Region, China_Region, Afghanistan_Region, Ukraine_Region);
            Irkutsk_List.Add_Edge(Yakutsk_Region, Kamchatka_Region, Mongolia_Region, Siberia_Region);
            Japan_List.Add_Edge(Kamchatka_Region, Mongolia_Region);
            Mongolia_List.Add_Edge(Irkutsk_Region, Kamchatka_Region, Japan_Region, China_Region, Siberia_Region);
            Afghanistan_List.Add_Edge(Ural_Region, China_Region, India_Region, Middle_East_Region, Ukraine_Region);
            China_List.Add_Edge(Siberia_Region, Mongolia_Region, Siam_Region, India_Region, Afghanistan_Region, Ural_Region);
            Middle_East_List.Add_Edge(Afghanistan_Region, India_Region, Egypt_Region, Southern_Europe_Region, Ukraine_Region);
            India_List.Add_Edge(China_Region, Siam_Region, Middle_East_Region, Afghanistan_Region);
            Siam_List.Add_Edge(China_Region, India_Region, Indonesia_Region);
        }
        //functions for Mouse click events for differing game states
        private void Click_AllGameState(Country country, Button region, AdjacencyListRegions regionlist, List<Country> continent)
        {
            Click_GameState0(country, region, continent);
            Click_GameState1(country, region);
            Click_GameState2(country, region);
            Click_GameState3(country, region, regionlist);
            Click_GameState4(country, region, regionlist);
            Click_GameState5(country, region, regionlist);
            Click_GameState6(country, region);
        }
        private void Click_GameState6(Country country, Button region)
        {
            if (Game_State == 6)
            {
                Country_Selected_Reinforce_To = country;
                Region_Selected_Reinforce_To_Button = region;
                bool check = false;
                foreach (Country Regions in List_Reachable_Regions)
                {
                    if (Regions.Output_Name() == country.Output_Name())
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true && country.Output_Player() == Players_In_Game[Current_Player])
                {
                    Select_Total_Troops.Show();
                    Select_Total_Troops.Items.Clear();
                    Select_Total_Troops.DropDownHeight = 200;
                    int count = 1;
                    while (count < Country_Selected_Reinforce.Output_Troops())
                    {
                        Select_Total_Troops.Items.Add(count + " Troops");
                        count++;
                    }
                    Hide_Buttons();
                }
            }
        }
        private void Click_GameState5(Country country, Button region, AdjacencyListRegions regionlist)
        {
            if (Game_State == 5)
            {
                regionlist.Store_Regions(ref List_Reachable_Regions);
                bool check = false;
                foreach (Country Regions in List_Reachable_Regions)
                {
                    if (Regions.Output_Player() == Players_In_Game[Current_Player])
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true && country.Output_Player() == Players_In_Game[Current_Player] && country.Output_Troops() >= 2)
                {
                    Country_Selected_Reinforce = country;
                    Region_Selected_Reinforce_Button = region;
                    HelpText.Text = ("You have chosen to reinforce with " + country.Output_Name() + ". Please choose an adjacent region to reinforce.");
                    Game_State = Convert.ToInt32(Game_Period.Reinforce_Move);
                    Advance_Game.Hide();
                }
            }
        }
        private void Click_GameState4(Country country, Button region, AdjacencyListRegions regionlist)
        {
            if (Game_State == 4)
            {
                bool flag = false;
                foreach (Country Regions in List_Reachable_Regions)
                {
                    if (Regions.Output_Name() == country.Output_Name() && country.Output_Player() != Players_In_Game[Current_Player])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    Defend_Region.ForeColor = Color.FromArgb(country.Output_Player().Output_Colour(0), country.Output_Player().Output_Colour(1), country.Output_Player().Output_Colour(2));
                    Country_Selected_Defend = country;
                    Region_Selected_Defend_Button = region;
                    region.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0);
                    HelpText.Text = ("Attack_Phase - Please refer to the other HelpBox.");
                    Attack_HelpText.Text = ("You have chosen to attack " + Country_Selected_Defend.Output_Name() + " with " + Country_Selected_Attack.Output_Name() + ". Please select the total amount of troops you wish to attack with.");
                    Attack_Region.Text = Country_Selected_Attack.Output_Name();
                    Defend_Region.Text = Country_Selected_Defend.Output_Name();
                    Hide_Buttons();
                    foreach (Control form in this.Controls)
                    {
                        if ((Convert.ToString(form.Tag)) == "Attack_Phase")
                        {
                            form.Visible = true;
                        }
                    }
                    Select_Total_Troops.Items.Clear();
                    Total_Troops_Attacking_Number.Text = (Convert.ToString(Country_Selected_Attack.Output_Troops()));
                    Total_Troops_Defending_Number.Text = (Convert.ToString(Country_Selected_Defend.Output_Troops()));
                    int troops = Country_Selected_Attack.Output_Troops();
                    int count = 2;
                    Select_Total_Troops.Items.Add(1 + " Troop");
                    while (count < troops)
                    {
                        Select_Total_Troops.Items.Add(count + " Troops");
                        count++;
                    }
                    Next_Attack.Enabled = false;
                    End_Attack.Enabled = false;
                    Select_Troops_To_Attack.Hide();
                    Select_Total_Troops.DropDownHeight = 200;
                }
            }
        }
        private void Click_GameState3(Country country, Button region, AdjacencyListRegions regionlist)
        {
            bool check = false;
            foreach (Country Regions in List_Reachable_Regions)
            {
                if (Regions.Output_Player() != Players_In_Game[Current_Player])
                {
                    check = true;
                    break;
                }
            }
            if ((Game_State == 3) && (country.Output_Troops() >= 2) && (country.Output_Player() == Players_In_Game[Current_Player]) && check == true)
            {
                Country_Selected_Attack = country;
                Region_Selected_Attack_Button = region;
                HelpText.Text = ("You have chosen to attack with " + country.Output_Name() + ". Please select the region you would like to attack.");
                Advance_Game.Hide();
                region.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 0);
                Game_State = Convert.ToInt32(Game_Period.Attack_Player);
                regionlist.Store_Regions(ref List_Reachable_Regions);
                Attack_Region.ForeColor = Color.FromArgb((Players_In_Game[Current_Player].Output_Colour(0)), (Players_In_Game[Current_Player].Output_Colour(1)), (Players_In_Game[Current_Player].Output_Colour(2)));
            }
        }
        private void Click_GameState2(Country country, Button region)
        {

            if (Game_State == 2)
            {
                foreach (string Search_region in (Players_In_Game[Current_Player].Occupied_Regions))
                {
                    if (Search_region == (country.Output_Name()))
                    {
                        Update_Region_Fortify(region);
                        country.Add_Troops(1);
                    }
                }
            }
        }
        private void Click_GameState1(Country country, Button region)
        {
            if (Game_State == 1)
            {
                foreach (string Selected_Region in (Players_In_Game[Current_Player].Occupied_Regions))
                {
                    if (Selected_Region == (country.Output_Name()))
                    {
                        Update_Region(region);
                        country.Add_Troops(1);
                    }
                }
            }
        }
        private void Click_GameState0(Country country, Button region, List<Country> Continent)
        {
            if (Game_State == 0 && (region.Text == "0"))
            {
                country.Change_Occupier(Players_In_Game[Current_Player]);
                Players_In_Game[Current_Player].Occupied_Regions.Add(country.Output_Name());
                Claim_Region(region);
                Continent.Add(country);
            }

        }

        //functions for Mouse enter events for differing game states
        private void MouseEnter_AllGameState(Button region, Country country, AdjacencyListRegions regionlist)
        {
            MouseEnter_GameState012(region);
            MouseEnter_GameState3(region, country, regionlist);
            MouseEnter_GameState4(region, country);
            MouseEnter_GameState5(region, country, regionlist);
            MouseEnter_GameState6(region, country);
        }
        private void MouseEnter_GameState6(Button region, Country country)
        {
            if (Game_State == 6)
            {
                bool check = false;
                foreach (Country Regions in List_Reachable_Regions)
                {
                    if (Regions.Output_Name() == country.Output_Name())
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true && country.Output_Player() == Players_In_Game[Current_Player])

                {
                    region.BackColor = Color.FromArgb(1, 0, 255, 0);
                }
                else
                {
                    region.BackColor = Color.FromArgb(1, 255, 0, 0);
                }
            }

        }
        private void MouseEnter_GameState5(Button region, Country country, AdjacencyListRegions regionlist)
        {
            if (Game_State == 5)
            {
                regionlist.Store_Regions(ref List_Reachable_Regions);
                bool check = false;
                foreach (Country Regions in List_Reachable_Regions)
                {
                    if (Regions.Output_Player() == Players_In_Game[Current_Player])
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true && country.Output_Player() == Players_In_Game[Current_Player] && country.Output_Troops() >= 2)
                {
                    region.BackColor = Color.FromArgb(1, 0, 255, 0);
                }
                else
                {
                    region.BackColor = Color.FromArgb(1, 255, 0, 0);
                }
            }
        }
        private void MouseEnter_GameState4(Button region, Country country)
        {
            if (Game_State == 4)
            {
                bool check = false;
                foreach (Country Regions in List_Reachable_Regions)
                {
                    if (Regions.Output_Name() == country.Output_Name() && country.Output_Player() != Players_In_Game[Current_Player])
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true)
                {
                    region.BackColor = Color.FromArgb(1, 0, 255, 0);
                }
                else
                {
                    region.BackColor = Color.FromArgb(1, 255, 0, 0);
                }
            }
        }
        private void MouseEnter_GameState3(Button region, Country country, AdjacencyListRegions regionlist)
        {
            if (Game_State == 3)
            {
                regionlist.Store_Regions(ref List_Reachable_Regions);
                bool check = false;
                foreach (Country Regions in List_Reachable_Regions)
                {
                    if (Regions.Output_Player() != Players_In_Game[Current_Player])
                    {
                        check = true;
                        break;
                    }
                }
                if ((country.Output_Troops() >= 2) && (country.Output_Player() == Players_In_Game[Current_Player]) && check == true)
                {

                    region.BackColor = Color.FromArgb(1, 0, 255, 0);
                }
                else
                {
                    region.BackColor = Color.FromArgb(1, 255, 0, 0);
                }

            }
        }
        private void MouseEnter_GameState012(Button regions)
        {
            if (Game_State == 0)
            {
                regions.BackColor = Color.FromArgb(1, 90, 90, 90);
            }
            if (Game_State == 1 || Game_State == 2)
            {
                Check_Region(regions);
            }
        }

        // general functions for repeated tasks
        private void Hide_Attack_Phase()
        {
            foreach (Control form in this.Controls)
            {
                if ((Convert.ToString(form.Tag)) == "Attack_Phase")
                {
                    form.Visible = false;
                }
            }
        }
        private void Disable_Buttons()
        {
            foreach (Control x in this.Controls)
            {
                if ((Convert.ToString(x.Tag)) == "Country")
                {
                    x.Enabled = false;
                }
            }
        }
        private void Enable_Buttons()
        {
            foreach (Control x in this.Controls)
            {
                if ((Convert.ToString(x.Tag)) == "Country")
                {
                    x.Enabled = true;
                }
            }
        }
        private void Show_Buttons()
        {
            foreach (Control x in this.Controls)
            {
                if ((Convert.ToString(x.Tag)) == "Country")
                {
                    x.Show();
                }
            }
        }
        private void Hide_Buttons()
        {
            foreach (Control x in this.Controls)
            {
                if ((Convert.ToString(x.Tag)) == "Country")
                {
                    x.Hide();
                }
            }
        }
        private void Check_Occupier(List<Country> continent, int troops)
        {
            bool flag = false;
            foreach (Country country in continent)
            {
                if (country.Output_Player() == (Players_In_Game[Current_Player]))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Players_In_Game[Current_Player].Add_Troops(troops);
            }
        }
        private void Check_Troops_Remaining_Fortify()
        {
            Troops_To_Place.Text = (Convert.ToString(Players_In_Game[Current_Player].Output_Troops()));
            if ((Players_In_Game[Current_Player].Output_Troops()) == 0)
            {
                Advance_Game.Show();
                Disable_Buttons();
                Troops_To_Place.Hide();
                HelpText.Text = "You have now fortified your regions. Please click next to begin your attack phase.";
            }
        }
        private void Update_Region_Fortify(Button region)
        {
            region.Text = (Convert.ToString(Convert.ToInt32(region.Text) + 1));
            Players_In_Game[Current_Player].Set_Troops(Players_In_Game[Current_Player].Output_Troops() - 1);
            Check_Troops_Remaining_Fortify();
        }
        private void Update_Region(Button r)
        {
            r.Text = (Convert.ToString(Convert.ToInt32(r.Text) + 1));
            Players_In_Game[Current_Player].Set_Troops(Players_In_Game[Current_Player].Output_Troops() - 1);
            Check_Troops_Remaining();
        }
        private void Set_Troops(int troops, int playernum)
        {
            int count = 0;
            while (count != playernum)
            {
                Players_In_Game[count].Set_Troops(troops);
                count++;
            }
        }
        private void Check_Region(Button regions)
        {
            foreach (string region in (Players_In_Game[Current_Player].Occupied_Regions))
            {
                if (region == ((regions.Name) + "_Region"))
                {
                    regions.BackColor = Color.FromArgb(1, 0, 255, 0);
                    break;
                }
                else
                {
                    regions.BackColor = Color.FromArgb(1, 255, 0, 0);
                }
            }
        }
        private void Claim_Region(Button region)
        {
            region.FlatAppearance.BorderColor = Color.FromArgb((Players_In_Game[Current_Player]).Output_Colour(0), (Players_In_Game[Current_Player]).Output_Colour(1), (Players_In_Game[Current_Player]).Output_Colour(2));
            region.Text = Convert.ToString(Convert.ToInt32(region.Text) + 1);
            Remaining_Countries--;
            Players_In_Game[Current_Player].Set_Troops(Players_In_Game[Current_Player].Output_Troops() - 1);
            Next_Player();
        }
        private void Next_Player()
        {
            if (Current_Player == (Number_Of_Players - 1))
            {
                Current_Player = 0;
            }
            else
            {
                Current_Player++;
            }
            PlayerTurn.Text = (Convert.ToString(Players_In_Game[Current_Player].Output_Player_Name()));
            PlayerTurn.ForeColor = Color.FromArgb((Players_In_Game[Current_Player].Output_Colour(0)), (Players_In_Game[Current_Player].Output_Colour(1)), (Players_In_Game[Current_Player].Output_Colour(2)));
            Troops_To_Place.Text = (Convert.ToString(Players_In_Game[Current_Player].Output_Troops()));
        }
        private void Check_Troops_Remaining()
        {
            Troops_To_Place.Text = (Convert.ToString(Players_In_Game[Current_Player].Output_Troops()));
            if ((Players_In_Game[Current_Player].Output_Troops()) == 0)
            {
                Next_Player();
            }
        }
        private void Comparing_Dice_Rolls(int dice, ref string winner)
        {
            if (Attacker_Dice_Rolls[dice] > Defender_Dice_Rolls[dice])
            {
                winner = "Attacker";
            }
            else if (Attacker_Dice_Rolls[dice] > Defender_Dice_Rolls[dice])
            {
                winner = "Defender";
            }
            else
            {
                winner = "Defender";
            }
        }
        private void Check_Attack_Win()
        {
            if (Troops_Defending_Number.Text == "0")
            {
                Players_In_Game[Current_Player].Occupied_Regions.Add(Country_Selected_Defend.Output_Name());
                Country_Selected_Defend.Output_Player().Occupied_Regions.Remove(Country_Selected_Defend.Output_Name());
                Country_Selected_Defend.Change_Occupier(Players_In_Game[Current_Player]);
                Country_Selected_Defend.Add_Troops(Convert.ToInt32(Troops_Attacking_Number.Text));
                Region_Selected_Defend_Button.Text = Convert.ToString(Country_Selected_Defend.Output_Troops());
                Country_Selected_Attack.Remove_Troops(Convert.ToInt32(Troops_Attacking_Number.Text));
                Region_Selected_Attack_Button.Text = Convert.ToString(Country_Selected_Attack.Output_Troops());
                Region_Selected_Defend_Button.FlatAppearance.BorderColor = Color.FromArgb((Players_In_Game[Current_Player]).Output_Colour(0), (Players_In_Game[Current_Player]).Output_Colour(1), (Players_In_Game[Current_Player]).Output_Colour(2));
                Hide_Attack_Phase();
                Show_Buttons();
                HelpText.Text = ("You have succesfully defeated this region and you now occupy it. Please either click another region to attack from or click next to end your attack phase.");
                Game_State = (Convert.ToInt32(Game_Period.Attack_Initial));
                Region_Selected_Attack_Button.FlatAppearance.BorderColor = Color.FromArgb((Players_In_Game[Current_Player]).Output_Colour(0), (Players_In_Game[Current_Player]).Output_Colour(1), (Players_In_Game[Current_Player]).Output_Colour(2));
                Advance_Game.Show();
                Troops_Attacking_Number.Text = ("0");
                Troops_Defending_Number.Text = ("0");
            }
            else if (Troops_Attacking_Number.Text == "0")
            {
                Hide_Attack_Phase();
                Show_Buttons();
                Country_Selected_Attack.Remove_Troops(Country_Selected_Attack.Output_Troops());
                Country_Selected_Attack.Add_Troops(Convert.ToInt32(Total_Troops_Attacking_Number.Text));
                HelpText.Text = ("Your attacking troops have been defeated. Please either click another region to attack from or click next to end your attack phase.");
                Game_State = (Convert.ToInt32(Game_Period.Attack_Initial));
                Advance_Game.Show();
                Region_Selected_Attack_Button.Text = Total_Troops_Attacking_Number.Text;
                Region_Selected_Defend_Button.Text = Total_Troops_Defending_Number.Text;
                Region_Selected_Attack_Button.FlatAppearance.BorderColor = Color.FromArgb((Players_In_Game[Current_Player].Output_Colour(0)), (Players_In_Game[Current_Player].Output_Colour(1)), (Players_In_Game[Current_Player].Output_Colour(2)));
                Region_Selected_Defend_Button.FlatAppearance.BorderColor = Color.FromArgb((Country_Selected_Defend.Output_Player().Output_Colour(0)), (Country_Selected_Defend.Output_Player().Output_Colour(1)), (Country_Selected_Defend.Output_Player().Output_Colour(2)));
                Troops_Attacking_Number.Text = ("-");
                Troops_Defending_Number.Text = ("-");
            }
        }
        private void Attack_Update(string winner)
        {
            if (winner == "Attacker")
            {
                Country_Selected_Defend.Remove_Troops(1);
                Troops_Defending_Number.Text = Convert.ToString(Convert.ToInt32(Troops_Defending_Number.Text) - 1);
                Total_Troops_Defending_Number.Text = Convert.ToString(Convert.ToInt32(Total_Troops_Defending_Number.Text) - 1);
            }
            else
            {
                Country_Selected_Attack.Remove_Troops(1);
                Troops_Attacking_Number.Text = Convert.ToString(Convert.ToInt32(Troops_Attacking_Number.Text) - 1);
                Total_Troops_Attacking_Number.Text = Convert.ToString(Convert.ToInt32(Total_Troops_Attacking_Number.Text) - 1);
            }
            // country class troops/total attack/total defend/ troops attacking/ troops defending
        }
        private void Attacker_Dice_Roll_3()
        {
            int Attack_Dice1 = Random_Number.Next(1, 7);
            int Attack_Dice2 = Random_Number.Next(1, 7);
            int Attack_Dice3 = Random_Number.Next(1, 7);
            Attacker_Dice_Rolls.Add(Attack_Dice1);
            Attacker_Dice_Rolls.Add(Attack_Dice2);
            Attacker_Dice_Rolls.Add(Attack_Dice3);
            Attacker_Dice_Rolls.Sort();
            Attacker_Dice_Rolls.Reverse();
            Attack_HelpText.Text += Convert.ToString(Attacker_Dice_Rolls[0]);
            Attack_HelpText.Text += Convert.ToString(Attacker_Dice_Rolls[1]);
            Attack_HelpText.Text += Convert.ToString(Attacker_Dice_Rolls[2]);
        }
        private void Attacker_Dice_Roll_1()
        {
            int Attack_Dice1 = Random_Number.Next(1, 7);
            Attacker_Dice_Rolls.Add(Attack_Dice1);
            Attacker_Dice_Rolls.Sort();
            Attacker_Dice_Rolls.Reverse();
            Attack_HelpText.Text += Convert.ToString(Attacker_Dice_Rolls[0]);
        }
        private void Defender_Dice_Roll_2()
        {
            int Defend_Dice1 = Random_Number.Next(1, 7);
            int Defend_Dice2 = Random_Number.Next(1, 7);
            Defender_Dice_Rolls.Add(Defend_Dice1);
            Defender_Dice_Rolls.Add(Defend_Dice2);
            Defender_Dice_Rolls.Sort();
            Defender_Dice_Rolls.Reverse();
            Attack_HelpText.Text += (". The defender rolled: ") + Convert.ToString(Defender_Dice_Rolls[0]);
            Attack_HelpText.Text += Convert.ToString(Defender_Dice_Rolls[1]);
        }
        private void Defender_Dice_Roll_1()
        {
            int Defend_Dice1 = Random_Number.Next(1, 7);
            Defender_Dice_Rolls.Add(Defend_Dice1);
            Attack_HelpText.Text += (" The defender rolled: ") + Convert.ToString(Defender_Dice_Rolls[0]);
        }

        //functions for events for forms 
        private void End_Attack_Click(object sender, EventArgs e)
        {
            Hide_Attack_Phase();
            Show_Buttons();
            HelpText.Text = ("You have withdrawn your troops. Please either click another region to attack from or click next to end your attack phase.");
            Game_State = (Convert.ToInt32(Game_Period.Attack_Initial));
            Advance_Game.Show();
            Region_Selected_Attack_Button.Text = Total_Troops_Attacking_Number.Text;
            Region_Selected_Defend_Button.Text = Total_Troops_Defending_Number.Text;
            Region_Selected_Attack_Button.FlatAppearance.BorderColor = Color.FromArgb((Players_In_Game[Current_Player].Output_Colour(0)), (Players_In_Game[Current_Player].Output_Colour(1)), (Players_In_Game[Current_Player].Output_Colour(2)));
            Region_Selected_Defend_Button.FlatAppearance.BorderColor = Color.FromArgb((Country_Selected_Defend.Output_Player().Output_Colour(0)), (Country_Selected_Defend.Output_Player().Output_Colour(1)), (Country_Selected_Defend.Output_Player().Output_Colour(2)));
            Troops_Attacking_Number.Text = ("-");
            Troops_Defending_Number.Text = ("-");
        }
        private void Finish_Game_Click(object sender, EventArgs e)
        {
            Finish_Game.Hide();
            Game_State = Convert.ToInt32(Game_Period.Place_Troops_Initial);
            foreach (Player players in Players_In_Game)
            {
                players.Occupied_Regions.Clear();
            }
            Players_In_Game.Clear();
            StartMenu form = new StartMenu();
            form.Show();
            this.Hide();
        }
        private void Play_Button_Click(object sender, EventArgs e)
        {
            Play_Button.Hide();
            Play_Button.Enabled = false;
            Player_Selection_List.Show();
            HelpText.Text = ("Please select the number of players you wish to play the game with.");
        }
        private void Player_Selection_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player_Selection_List.Hide();
            Player_Selection_List.Enabled = false;
            HelpText.Text = ("You have chosen to play with " + (Convert.ToString(Player_Selection_List.SelectedItem)) + " Please enter your username's. Once you have entered your name press the space key to enter.");
            Number_Of_Players = Convert.ToInt32(Convert.ToString(Player_Selection_List.SelectedItem).Substring(0, 1));
            Player_Name_Enter.Show();
        }
        private void Player_Name_Enter_TextChanged(object sender, EventArgs e)
        {
            foreach (char s in (Convert.ToString(Player_Name_Enter.Text)))
            {
                if (s == ' ')
                {
                    string PlayerName = Convert.ToString(Player_Name_Enter.Text);
                    if (Player1_Name.Text == "Player1")
                    {
                        Player1_Name.Text = PlayerName;
                        Player_Name_Enter.Text = String.Empty;
                        Player Player1 = new Player(PlayerName, 255, 246, 4);
                        Players_In_Game.Add(Player1);
                    }
                    else if (Player2_Name.Text == "Player2")
                    {
                        Player2_Name.Text = PlayerName;
                        Player_Name_Enter.Text = String.Empty;
                        Player Player2 = new Player(PlayerName, 0, 0, 0);
                        Players_In_Game.Add(Player2);
                    }
                    else if (Player3_Name.Text == "Player3")
                    {
                        Player3_Name.Text = PlayerName;
                        Player_Name_Enter.Text = String.Empty;
                        Player Player3 = new Player(PlayerName, 8, 146, 208);
                        Players_In_Game.Add(Player3);
                    }
                    else if (Player4_Name.Text == "Player4")
                    {
                        Player4_Name.Text = PlayerName;
                        Player_Name_Enter.Text = String.Empty;
                        Player Player4 = new Player(PlayerName, 46, 139, 87);
                        Players_In_Game.Add(Player4);
                    }
                    else if (Player5_Name.Text == "Player5")
                    {
                        Player5_Name.Text = PlayerName;
                        Player_Name_Enter.Text = String.Empty;
                        Player Player5 = new Player(PlayerName, 255, 105, 180);
                        Players_In_Game.Add(Player5);
                    }
                    else if (Player6_Name.Text == "Player6")
                    {
                        Player6_Name.Text = PlayerName;
                        Player_Name_Enter.Text = String.Empty;
                        Player Player6 = new Player(PlayerName, 255, 36, 0);
                        Players_In_Game.Add(Player6);
                    }
                    count++;
                }
                if (count == (Number_Of_Players))
                {
                    HelpText.Text = "You have now entered all the usernames. To begin placing your initial troops please click begin.";
                    Player_Name_Enter.Hide();
                    Player_Name_Enter.Enabled = false;
                    Advance_Game.Show();
                    if (Player3_Name.Text == "Player3")
                    {
                        Set_Troops(40, 2);
                        Player3_Name.Hide();
                        Player4_Name.Hide();
                        Player5_Name.Hide();
                        Player6_Name.Hide();
                    }
                    else if (Player4_Name.Text == "Player4")
                    {
                        Set_Troops(35, 3);
                        Player4_Name.Hide();
                        Player5_Name.Hide();
                        Player6_Name.Hide();
                    }
                    else if (Player5_Name.Text == "Player5")
                    {
                        Set_Troops(30, 4);
                        Player5_Name.Hide();
                        Player6_Name.Hide();
                    }
                    else if (Player6_Name.Text == "Player6")
                    {
                        Set_Troops(25, 5);
                        Player6_Name.Hide();
                    }
                    else
                    {
                        Set_Troops(20, 6);
                    }
                }
            }
        }
        private void Place_Troops_Initial_Tick(object sender, EventArgs e)
        {
            if (Remaining_Countries == 0)
            {
                HelpText.Text = ("All the regions have been occupied. Please press the next button to begin to place your remaining troops on your regions.");
                Place_Troops_Initial.Enabled = false;
                Disable_Buttons();
                Game_State = (Convert.ToInt32(Game_Period.Place_Troops_Remaining));
                Advance_Game.Show();
                Advance_Game.Text = ("Next");
            }
        }
        private void Select_Troops_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_Total_Troops.Hide();
            if (Game_State == 6)
            {
                Country_Selected_Reinforce.Remove_Troops(Select_Total_Troops.SelectedIndex + 1);
                Country_Selected_Reinforce_To.Add_Troops(Select_Total_Troops.SelectedIndex + 1);
                Region_Selected_Reinforce_Button.Text = (Convert.ToString(Country_Selected_Reinforce.Output_Troops()));
                Region_Selected_Reinforce_To_Button.Text = (Convert.ToString(Country_Selected_Reinforce_To.Output_Troops()));
                Show_Buttons();
                HelpText.Text = (Country_Selected_Reinforce_To.Output_Name() + " has been reinforced. Please click next to end your turn.");
                Advance_Game.Show();
                Disable_Buttons();
            }
            else
            {
                Troops_Attacking_Number.Text = Convert.ToString(Select_Total_Troops.SelectedIndex + 1);
                if (Country_Selected_Defend.Output_Troops() < (Convert.ToInt32(Troops_Attacking_Number.Text) - 1))
                {
                    Troops_Defending_Number.Text = Convert.ToString(Country_Selected_Defend.Output_Troops());
                }
                else
                {
                    Troops_Defending_Number.Text = Convert.ToString(Country_Selected_Defend.Output_Troops());
                }
                Attack_HelpText.Text = ("Now please select the amount of troops you would like to attack with.");
                Select_Troops_To_Attack.Show();
                Select_Troops_To_Attack.Items.Clear();
                if ((Convert.ToInt32(Troops_Attacking_Number.Text)) >= 3)
                {
                    Select_Troops_To_Attack.Items.Add(1 + " Troop");
                    Select_Troops_To_Attack.Items.Add(2 + " Troops");
                    Select_Troops_To_Attack.Items.Add(3 + " Troops");
                    Num_Troops_Attacking = 3;
                }
                else if ((Convert.ToInt32(Troops_Attacking_Number.Text)) >= 2)
                {
                    Select_Troops_To_Attack.Items.Add(1 + " Troop");
                    Select_Troops_To_Attack.Items.Add(2 + " Troops");
                    Num_Troops_Attacking = 2;
                }
                else
                {
                    Select_Troops_To_Attack.Items.Add(1 + " Troop");
                    Num_Troops_Attacking = 1;
                }
            }
        }
        private void Check_Win_Tick(object sender, EventArgs e)
        {
            Check_Win.Stop();
            foreach (Player player in (Players_In_Game))
            {
                if (player.Occupied_Regions.Count == 0)
                    {
                    Players_In_Game.Remove(player);
                }
            }
            foreach (Player player in (Players_In_Game))
            {
                if ((player.Occupied_Regions.Count) == 42)
                {
                    Win_Text.Text = (player.Output_Player_Name() + "Has won the game! Well done");
                    Disable_Buttons();
                    Advance_Game.Enabled = false;
                    try
                    {
                        Win_Text.Text += (". Game information has been saved to a file.");
                        string Game_Information = File.ReadAllText(@"D:/College/Computer Science/Game Information.txt");
                        Game_Information += ("\n\nWinner: " + player.Output_Player_Name() + "\nPlayers in game:\n");
                        foreach (Player players in Players_In_Game)
                        {
                            Game_Information += (players.Output_Player_Name() + "\n");
                        }
                        Game_Information += ("This game lasted " + Turn.Text + " turns\n");
                        Game_Information += ("This game was played at: " + Convert.ToString(DateTime.Now));
                        File.WriteAllText(@"D:/College/Computer Science/Game Information.txt", Game_Information);
                    }
                    catch
                    {
                        Win_Text.Text += (". ## FILE NOT FOUND ##");
                    }
                    HelpText.Text = ("Please click Finish Game to exit back to the start menu.");
                    Finish_Game.Show();
                }
            }
        }
        private void Place_Remaining_Troops_Tick(object sender, EventArgs e)
        {
            if (Players_Complete == (Players_In_Game.Count))
            {
                Place_Remaining_Troops.Enabled = false;
                HelpText.Text = ("All players have placed the remainder of their troops. Please click the begin turn button to begin " + (Convert.ToString(Players_In_Game[Current_Player].Output_Player_Name()) + "'s turn."));
                Game_State = (Convert.ToInt32(Game_Period.Fortify));
                Advance_Game.Text = ("Begin Turn");
                Advance_Game.Show();
                Current_Player = First_Player;
                PlayerTurn.Text = (Convert.ToString(Players_In_Game[Current_Player].Output_Player_Name()));
                PlayerTurn.ForeColor = Color.FromArgb((Players_In_Game[Current_Player].Output_Colour(0)), (Players_In_Game[Current_Player].Output_Colour(1)), (Players_In_Game[Current_Player].Output_Colour(2)));
                foreach (Control x in this.Controls)
                {
                    if ((Convert.ToString(x.Tag)) == "Country")
                    {
                        x.Enabled = false;
                    }
                }
            }
            else
            {
                if ((Players_In_Game[Current_Player].Output_Troops()) == 0)
                {
                    Players_Complete++;
                    Next_Player();
                }
            }
        }
        private void Next_Attack_Click(object sender, EventArgs e)
        {
            End_Attack.Enabled = true;
            End_Attack.Text = ("End Attack");
            Next_Attack.Text = ("Next Attack");
            Attacker_Dice_Rolls.Clear();
            Defender_Dice_Rolls.Clear();
            Attack_HelpText.Text = ("The attacker rolled: ");
            if (Convert.ToInt16(Troops_Attacking_Number.Text) >= 3 && Convert.ToInt16(Select_Troops_To_Attack.SelectedIndex) + 1 == 3 && Convert.ToInt16(Troops_Defending_Number.Text) >= 2)
            {
                Random random = new Random();
                Attacker_Dice_Roll_3();
                Defender_Dice_Roll_2();
            }
            else if (Convert.ToInt16(Select_Troops_To_Attack.SelectedIndex) + 1 == 3 && Convert.ToInt16(Troops_Attacking_Number.Text) == 3)
            {
                Attacker_Dice_Roll_3();
                Defender_Dice_Roll_1();
            }
            else if (Convert.ToInt16(Troops_Attacking_Number.Text) == 2 && Convert.ToInt16(Select_Troops_To_Attack.SelectedIndex) + 1 == 2)
            {
                int Attack_Dice2 = Random_Number.Next(1, 7);
                Attacker_Dice_Rolls.Add(Attack_Dice2);
                Attacker_Dice_Roll_1();
                Attack_HelpText.Text += Convert.ToString(Attacker_Dice_Rolls[1]);
                Defender_Dice_Roll_1();
            }
            else
            {
                Attacker_Dice_Roll_1();
                Defender_Dice_Roll_1();
            }
            //compare dice rolls
            if (Defender_Dice_Rolls.Count == 2)
            {
                Comparing_Dice_Rolls(0, ref Winner);
                Attack_Update(Winner);
                Comparing_Dice_Rolls(1, ref Winner);
                Attack_Update(Winner);
                Check_Attack_Win();
            }
            else
            {
                Comparing_Dice_Rolls(0, ref Winner);
                Attack_Update(Winner);
                Check_Attack_Win();
            }
            Attack_HelpText.Text += (". Either click end attack to withdraw or next attack to continue attacking.");

        }
        private void Select_Troops_To_Attack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Next_Attack.Enabled == false)
            {
                Select_Troops_To_Attack.Hide();
                Num_Troops_Attacking = (Select_Troops_To_Attack.SelectedIndex + 1);
                Attack_HelpText.Text = ("You have chosen to attack with " + Num_Troops_Attacking + " troops. Please click begin attack to begin your attack.");
                Next_Attack.Enabled = true;
            }
        }
        private void Advance_Game_Click(object sender, EventArgs e)
        {
            if (Game_State == 0)
            {
                Advance_Game.Hide();
                Show_Buttons();
                Random random = new Random();
                First_Player = random.Next(0, Number_Of_Players);
                Current_Player = First_Player;
                PlayerTurn.Text = (Convert.ToString(Players_In_Game[Current_Player].Output_Player_Name()));
                PlayerTurn.ForeColor = Color.FromArgb((Players_In_Game[Current_Player].Output_Colour(0)), (Players_In_Game[Current_Player].Output_Colour(1)), (Players_In_Game[Current_Player].Output_Colour(2)));
                HelpText.Text = ((Convert.ToString(Players_In_Game[Current_Player].Output_Player_Name())) + " has been randomly selected to go first. Please click a region to occupy it. Each player has " + (Convert.ToString(Players_In_Game[Current_Player].Output_Troops())) + " troops to place.");
                Place_Troops_Initial.Enabled = true;
                Static_Label.Show();
                Troops_To_Place.Show();
                Troops_To_Place.Text = (Convert.ToString(Players_In_Game[Current_Player].Output_Troops()));
            }
            else if (Game_State == 1)
            {
                Enable_Buttons();
                HelpText.Text = ("Now please place your remaining troops on your already occupied regions.");
                Advance_Game.Hide();
                Place_Remaining_Troops.Enabled = true;
            }
            else if (Game_State == 2 && Troops_To_Place.Visible == false)
            {
                HelpText.Text = "Please either click a region to attack from or click next to begin your reinforce stage";
                Game_State = (Convert.ToInt32(Game_Period.Attack_Initial));
                Enable_Buttons();
                Advance_Game.Show();
            }
            else if (Game_State == 2)
            {
                Advance_Game.Text = ("Next");
                Turn.Text = Convert.ToString(Convert.ToInt32(Turn.Text) + 1);
                Enable_Buttons();
                if ((Players_In_Game[Current_Player].Occupied_Regions.Count) <= 9)
                {
                    Players_In_Game[Current_Player].Set_Troops(3);
                }
                else
                {
                    Players_In_Game[Current_Player].Set_Troops((Players_In_Game[Current_Player].Occupied_Regions.Count) / 3);
                }
                Check_Occupier(Africa, 3);
                Check_Occupier(Asia, 7);
                Check_Occupier(Australia, 2);
                Check_Occupier(Europe, 5);
                Check_Occupier(North_America, 5);
                Check_Occupier(South_America, 2);
                HelpText.Text = ("Based on your occpied regions, " + (Players_In_Game[Current_Player].Output_Troops()) + " extra troops have been rewarded to you to fortify your regions. Please click your regions to place them.");
                Troops_To_Place.Text = (Convert.ToString(Players_In_Game[Current_Player].Output_Troops()));
                Advance_Game.Hide();
            }
            else if (Game_State == 3)
            {
                HelpText.Text = ("Please either click a region to reinforce from or click next to end your turn.");
                Game_State = (Convert.ToInt32(Game_Period.Reinforce));
            }
            else if (Game_State == 5)
            {
                Next_Player();
                Game_State = (Convert.ToInt32(Game_Period.Fortify));
                Advance_Game.Text = ("Begin Turn");
                HelpText.Text = ("Please click the begin button to begin " + (Convert.ToString(Players_In_Game[Current_Player].Output_Player_Name()) + "'s turn."));
                Troops_To_Place.Show();
            }
            else if (Game_State == 6)
            {
                Next_Player();
                Game_State = (Convert.ToInt32(Game_Period.Fortify));
                Advance_Game.Text = ("Begin Turn");
                HelpText.Text = ("Please click the begin button to begin " + (Convert.ToString(Players_In_Game[Current_Player].Output_Player_Name()) + "'s turn."));
                Troops_To_Place.Show();
            }

        }
        //42 mouse enter events for each region that change depending on the game state 
        private void Greenland_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Greenland, Greenland_Region, Greenland_List);
        }
        private void Alaska_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Alaska, Alaska_Region, Alaska_List);
        }
        private void Alberta_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Alberta, Alberta_Region, Alberta_List);
        }
        private void Scandinavia_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Scandinavia, Scandinavia_Region, Scandinavia_List);
        }
        private void Egypt_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Egypt, Egypt_Region, Egypt_List);
        }
        private void Madagasca_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Madagascar, Madagascar_Region, Madagascar_List);
        }
        private void East_Africa_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(East_Africa, East_Africa_Region, East_Africa_List);
        }
        private void South_Africa_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(South_Africa, South_Africa_Region, South_Africa_List);
        }
        private void Congo_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Congo, Congo_Region, Congo_List);
        }
        private void North_Africa_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(North_Africa, North_Africa_Region, North_Africa_List);
        }
        private void Argentina_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Argentina, Argentina_Region, Argentina_List);
        }
        private void Peru_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Peru, Peru_Region, Peru_List);
        }
        private void Brazil_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Brazil, Brazil_Region, Brazil_List);
        }
        private void Venuzuela_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Venezuela, Venezuela_Region, Venezuela_List);
        }
        private void Central_America_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Central_America, Central_America_Region, Central_America_List);
        }
        private void Eastern_United_States_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Eastern_United_States, Eastern_United_States_Region, Eastern_United_States_List);
        }
        private void Quebec_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Quebec, Quebec_Region, Quebec_List);
        }
        private void Ontario_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Ontario, Ontario_Region, Ontario_List);
        }
        private void Western_United_States_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Western_United_States, Western_United_States_Region, Western_United_States_List);
        }
        private void North_West_Territory_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(North_West_Territory, North_West_Territory_Region, North_West_Territory_List);
        }
        private void Irkutsk_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Irkutsk, Irkutsk_Region, Irkutsk_List);
        }
        private void Siberia_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Siberia, Siberia_Region, Siberia_List);
        }
        private void Kamchatka_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Kamchatka, Kamchatka_Region, Kamchatka_List);
        }
        private void Yakutsk_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Yakutsk, Yakutsk_Region, Yakutsk_List);
        }
        private void Western_Europe_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Western_Europe, Western_Europe_Region, Western_Europe_List);
        }
        private void Southern_Europe_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Southern_Europe, Southern_Europe_Region, Southern_Europe_List);
        }
        private void Great_Britain_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Great_Britain, Great_Britain_Region, Great_Britain_List);
        }
        private void Northern_Europe_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Northern_Europe, Northern_Europe_Region, Northern_Europe_List);
        }
        private void Ukraine_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Ukraine, Ukraine_Region, Ukraine_List);
        }
        private void Indionesia_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Indonesia, Indonesia_Region, Indonesia_List);
        }
        private void Middle_East_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Middle_East, Middle_East_Region, Middle_East_List);
        }
        private void Afghanistan_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Afghanistan, Afghanistan_Region, Afghanistan_List);
        }
        private void Siam_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Siam, Siam_Region, Siam_List);
        }
        private void India_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(India, India_Region, India_List);
        }
        private void Japan_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Japan, Japan_Region, Japan_List);
        }
        private void Mongolia_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Mongolia, Mongolia_Region, Mongolia_List);
        }
        private void China_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(China, China_Region, China_List);
        }
        private void Eastern_Australia_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Eastern_Australia, Eastern_Australia_Region, Eastern_Australia_List);
        }
        private void Western_Australia_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Western_Australia, Western_Australia_Region, Western_Australia_List);
        }
        private void New_Guinea_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(New_Guinea, New_Guinea_Region, New_Guinea_List);
        }
        private void Iceland_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Iceland, Iceland_Region, Iceland_List);
        }
        private void Ural_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_AllGameState(Ural, Ural_Region, Ural_List);
        }
        //42 mouse click events that change dependning on the game state
        private void Alaska_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Alaska_Region, Alaska, Alaska_List, North_America);
        }
        private void North_West_Territory_Click(object sender, EventArgs e)
        {
            Click_AllGameState(North_West_Territory_Region, North_West_Territory, North_West_Territory_List, North_America);
        }
        private void Alberta_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Alberta_Region, Alberta, Alberta_List, North_America);
        }
        private void Greenland_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Greenland_Region, Greenland, Greenland_List, North_America);
        }
        private void Ontario_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Ontario_Region, Ontario, Ontario_List, North_America);
        }
        private void Quebec_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Quebec_Region, Quebec, Quebec_List, North_America);
        }
        private void Western_United_States_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Western_United_States_Region, Western_United_States, Western_United_States_List, North_America);
        }
        private void Eastern_United_States_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Eastern_United_States_Region, Eastern_United_States, Eastern_United_States_List, North_America);
        }
        private void Central_America_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Central_America_Region, Central_America, Central_America_List, North_America);
        }
        private void Venuzuela_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Venezuela_Region, Venezuela, Venezuela_List, South_America);
        }
        private void Brazil_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Brazil_Region, Brazil, Brazil_List, South_America);
        }
        private void Peru_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Peru_Region, Peru, Peru_List, South_America);
        }
        private void Argentina_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Argentina_Region, Argentina, Argentina_List, South_America);
        }
        private void Egypt_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Egypt_Region, Egypt, Egypt_List, Africa);
        }
        private void North_Africa_Click(object sender, EventArgs e)
        {
            Click_AllGameState(North_Africa_Region, North_Africa, North_Africa_List, Africa);
        }
        private void East_Africa_Click(object sender, EventArgs e)
        {
            Click_AllGameState(East_Africa_Region, East_Africa, East_Africa_List, Africa);
        }
        private void Congo_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Congo_Region, Congo, Congo_List, Africa);
        }
        private void Madagasca_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Madagascar_Region, Madagascar, Madagascar_List, Africa);
        }
        private void South_Africa_Click(object sender, EventArgs e)
        {
            Click_AllGameState(South_Africa_Region, South_Africa, South_Africa_List, Africa);
        }
        private void Iceland_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Iceland_Region, Iceland, Iceland_List, Europe);
        }
        private void Scandinavia_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Scandinavia_Region, Scandinavia, Scandinavia_List, Europe);
        }
        private void Ukraine_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Ukraine_Region, Ukraine, Ukraine_List, Europe);
        }
        private void Northern_Europe_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Northern_Europe_Region, Northern_Europe, Northern_Europe_List, Europe);
        }
        private void Great_Britain_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Great_Britain_Region, Great_Britain, Great_Britain_List, Europe);
        }
        private void Western_Europe_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Western_Europe_Region, Western_Europe, Western_Europe_List, Europe);
        }
        private void Southern_Europe_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Southern_Europe_Region, Southern_Europe, Southern_Europe_List, Europe);
        }
        private void Indionesia_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Indonesia_Region, Indonesia, Indonesia_List, Australia);
        }
        private void New_Guinea_Click(object sender, EventArgs e)
        {
            Click_AllGameState(New_Guinea_Region, New_Guinea, New_Guinea_List, Australia);
        }
        private void Western_Australia_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Western_Australia_Region, Western_Australia, Western_Australia_List, Australia);
        }
        private void Eastern_Australia_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Eastern_Australia_Region, Eastern_Australia, Eastern_Australia_List, Australia);
        }
        private void Kamchatka_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Kamchatka_Region, Kamchatka, Kamchatka_List, Asia);
        }
        private void Yakutsk_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Yakutsk_Region, Yakutsk, Yakutsk_List, Asia);
        }
        private void Siberia_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Siberia_Region, Siberia, Siberia_List, Asia);
        }
        private void Ural_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Ural_Region, Ural, Ural_List, Asia);
        }
        private void Irkutsk_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Irkutsk_Region, Irkutsk, Irkutsk_List, Asia);
        }
        private void Japan_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Japan_Region, Japan, Japan_List, Asia);
        }
        private void Mongolia_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Mongolia_Region, Mongolia, Mongolia_List, Asia);
        }
        private void Afghanistan_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Afghanistan_Region, Afghanistan, Afghanistan_List, Asia);
        }
        private void China_Click(object sender, EventArgs e)
        {
            Click_AllGameState(China_Region, China, China_List, Asia);
        }
        private void Middle_East_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Middle_East_Region, Middle_East, Middle_East_List, Asia);
        }
        private void India_Click(object sender, EventArgs e)
        {
            Click_AllGameState(India_Region, India, India_List, Asia);
        }
        private void Siam_Click(object sender, EventArgs e)
        {
            Click_AllGameState(Siam_Region, Siam, Siam_List, Asia);
        }
    }
}
