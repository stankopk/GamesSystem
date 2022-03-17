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
        public void CreateGame(Game g)
        {
            using (GamesDBEntities gdbe = new GamesDBEntities())
            {
                g.Id = gdbe.Games.Count() + 1;
                gdbe.Games.Add(g);
                gdbe.SaveChanges();
            }
        }

        //Delete - Dev 1
        public void DeleteGame(int id)
        {
            using (GamesDBEntities gdbe = new GamesDBEntities())
            {
                var gameToDelete = gdbe.Games.Where(g => g.Id == id).FirstOrDefault();
                if (gameToDelete != null)
                {
                    gdbe.Games.Remove(gameToDelete);
                    gdbe.SaveChanges();
                }
            }
        }

        //Update - Dev 2


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
