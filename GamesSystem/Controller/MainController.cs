using GamesSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesSystem.Controller
{
    class MainController
    {
        //Create - Team Leader

        //Update - Dev 1
        //Delete - Dev 2


        //Read - Team Leader
        public List<Game> ShowAllGames()
        {
            using (GamesDBEntities gdbe = new GamesDBEntities())
            {
                var games = gdbe.Games.ToList();
                return games;
            }
        }
    }
}
