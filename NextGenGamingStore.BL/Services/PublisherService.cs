using NextGenGamingStore.BL.Interfaces;
using NextGenGamingStore.DL.Interfaces;
using NextGenGamingStore.Models.DTO;
using NextGenGamingStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static NextGenGamingStore.BL.Services.PublisherService;

namespace NextGenGamingStore.BL.Services
{



    public class PublisherService : IPublisherService
    {
        private readonly IGameService _gameService;
        private readonly IPublisherRepository _publisherRepository;
        public PublisherService(IGameService gameService, IPublisherRepository publisherRepository)
        {
            _gameService = gameService;
            _publisherRepository = publisherRepository;
        }

        public async Task<List<GetAllGamesByPublisherResponse>> GetAllGameDetails()
        {
            var result = new List<GetAllGamesByPublisherResponse>();

            var games = await _gameService.GetGames();

            foreach (var game in games)
            {
                var gameDetails = new GetAllGamesByPublisherResponse();
                gameDetails.Title = game.Title;
                gameDetails.Year = game.Year;
                gameDetails.Id = game.Id;

                foreach (var publisherId in game.PublisherIds)
                {
                    var publisher = _publisherRepository.GetById(publisherId);
                }


                result.Add(gameDetails);
            }
            return result;
        }
    }
}

