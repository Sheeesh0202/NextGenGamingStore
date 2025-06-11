﻿using NextGenGamingStore.Models.DTO;

namespace NextGenGamingStore.Models.Responses
{
    public class GetAllGamesByPublisherResponse
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
        public List<Publisher> Publishers { get; set; }
        

       
    }
}
