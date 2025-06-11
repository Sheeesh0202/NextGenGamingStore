﻿
using MessagePack;

namespace NextGenGamingStore.Models.DTO
{
  
        [MessagePackObject]
        public class Publisher : ICacheItem<string>
        {
            [Key(0)]
            public string Id { get; set; } = string.Empty;

            [Key(1)]
            public DateTime DateInserted { get; set; }

            [Key(2)]
            public string Name { get; set; } = string.Empty;

            [Key(3)]
            public string Bio { get; set; } = string.Empty;

            public string GetKey()
            {
                return Id;
            }
        }
}
