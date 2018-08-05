using EPLDataSet;
using EPLDataSet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EPLServices
{
    public class PlayerService : IPlayer
    {
        private EPLContext _context;

        public PlayerService(EPLContext context)
        {
            _context = context;
        }

        public void Add(Player newPlayer)
        {
            _context.Add(newPlayer);
            _context.SaveChanges();
        }

         public Player GetPlayerFirstName(int ID)
        {
            return _context.Players
                .Include(asset => asset.FirstName)
                .FirstOrDefault(asset => asset.PlayerID == ID);
        }

        public Player GetPlayerLastName(int ID)
        {
            return _context.Players
                 .Include(asset => asset.LastName)
                 .FirstOrDefault(asset => asset.PlayerID == ID);
        }

        public IEnumerable<Player> GetAll()
        {
            return _context.Players
                .Include(asset => asset.FirstName)
                .Include(asset => asset.LastName)
                .Include(asset => asset.PlayerDOB)
                .Include(asset => asset.PlayerNationality)
                .Include(asset => asset.Team)
                .Include(asset => asset.Position)
                .Include(asset => asset.PlayerGameStatus);
        }

        public Player GetById(int ID)
        {
            return _context.Players
                .Include(asset => asset.FirstName)
                .Include(asset => asset.LastName)
                .FirstOrDefault(asset => asset.PlayerID == ID);
        }

        public Team GetCurrentTeamName(int ID)
        {
            return _context.Players
                .FirstOrDefault(asset => asset.PlayerID == ID)
                .Team;
        }

       

        public string GetPlayerGameStatus(int ID)
        {
            //Trying to get the status of a player one of two options Benched(not available for play) or Availabe
            //Should be able to determine using the Player ID whether or not they are availabel for play.
            var gameStatus = _context.Players
                 .OfType<Player>()
                 .Where(gS => gS.PlayerID == ID);

            return gameStatus.Any() ? "Benched" : "Available";
        }

       
    }
}
