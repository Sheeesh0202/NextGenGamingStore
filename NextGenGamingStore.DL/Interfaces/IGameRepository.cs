using NextGenGamingStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGenGamingStore.DL.Interfaces
{
    public interface IGameRepository
    {
        Task<List<Game>> GetGames();

        Task AddGame(Game game);

        Task DeleteGame(string id);
        Task<Game?> GetGamesById(string id);


    }
}
