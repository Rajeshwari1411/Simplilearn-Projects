using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary

{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }
    public class Player
    {
        private int _PlayerId;
        private string _PlayerName;
        private int _PlayerAge;
        public int PlayerID
        {
            get { return _PlayerId; }
            set { _PlayerId = value; }  
        }
        public string PlayerNAME
        {
            get { return _PlayerName; }
            set { _PlayerName = value; }
        }
        public int PlayerAGE
        {
            get { return _PlayerAge; }
            set { _PlayerAge = value; }
        }
       
    }
    public class OneDayTeam : Player, ITeam
    {
        
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }
        public void Remove(int PlayerId)
        {
            Player player = null;
            foreach(var item in oneDayTeam)
            {
                if(item.PlayerID == PlayerId)
                {
                   player = item; 
                }
            }
            OneDayTeam.Remove(player);
            Console.WriteLine("Player removed successfully");
        }

        private static void Remove(Player player)
        {
            
        }

        public Player GetPlayerById(int playerId)
        {
            Player player = null;
            foreach (var item in oneDayTeam)
            {
                if (item.PlayerID == playerId)
                {
                    player = item; break;
                }
            }
            return player;

        }

        public Player GetPlayerByName(string PlayerName)
        {
            Player player = null;
            foreach(var item in oneDayTeam)
            {
                if(item.PlayerNAME == PlayerName)
                {
                    player=item; break; 
                }
            }
            return player;
        }


        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }





    }


}

