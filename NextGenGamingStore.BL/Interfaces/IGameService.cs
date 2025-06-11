using NextGenGamingStore.Models.DTO;
using NextGenGamingStore.Models.Requests;


namespace NextGenGamingStore.BL.Interfaces
{
    public interface IGameService
    {
        Task<List<Game>> GetGames();

        Task AddGame(Game game);






        Task DeleteGame(string id);
        Task<Game?> GetGamesById(string id);
        Task AddPublisher(string gameId, Publisher publisher);
    }
}
