using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace PlayerAndTeamRequirement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            c1:
            Console.WriteLine(" 1:To Add Player 2:To Remove Player by Id 3:Get Player By Id 4:Get Player by Name 5:Get All Players: ");
            int i=Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                    case 1:
                    c2:
                  
                   OneDayTeam one=new OneDayTeam();
                    if(OneDayTeam.oneDayTeam.Count !=OneDayTeam.oneDayTeam.Capacity)
                    {
                        Console.WriteLine("Enter the PlayerId:");
                        one.PlayerID=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the PlayerName:");
                        one.PlayerNAME=Console.ReadLine();
                        Console.WriteLine("Enter the PlayerAge:");
                        one.PlayerAGE=Convert.ToInt32(Console.ReadLine());
                        one.Add(one);
                    }
                    else
                    {
                        Console.WriteLine("The Team already contains 11 players");
                        goto c1;
                    }
                    Console.WriteLine("Do you want to continue(yes/no)?:");
                    string j=Console.ReadLine();
                    if (j == "yes")
                    {
                        goto c2;
                    }
                    
                    break;
                    case 2:
                    OneDayTeam day = new OneDayTeam();
                    Console.WriteLine("Enter PlayerId to Remove:");
                    int k=Convert.ToInt32(Console.ReadLine());
                    day.Remove(k);
                   
                    break;
                    case 3:
                    OneDayTeam team = new OneDayTeam();
                    Console.WriteLine("Enter the PlayerId to get:");
                    int l=Convert.ToInt32(Console.ReadLine());  
                    Player plr=team.GetPlayerById(l);
                    Console.WriteLine($"{plr.PlayerID}{plr.PlayerNAME}{plr.PlayerAGE}");
                    
                    break;
                    case 4:
                    OneDayTeam OneDay=new OneDayTeam();
                    Console.WriteLine("Enter the PlayerName to get:");
                    string m=Console.ReadLine();
                    Player ply=OneDay.GetPlayerByName(m);
                    Console.WriteLine($"{ply.PlayerID}{ply.PlayerNAME}{ply.PlayerAGE}");
                    
                    break ;
                    case 5:
                    Console.WriteLine("Get all players in a team");
                    List<Player> list=new List<Player>();
                    OneDayTeam onedayteam = new OneDayTeam();
                    list = onedayteam.GetAllPlayers();
                    foreach(var item in list)
                    {
                        Console.WriteLine($"{item.PlayerID}{item.PlayerNAME}{item.PlayerAGE}");
                    }
                    break;
                   

                
            }
            Console.WriteLine("Do u want to start again?");
            string n=Console.ReadLine();
            if(n=="yes")
            {
                goto c1;
            }
            Console.ReadLine();
        }
    }
}
