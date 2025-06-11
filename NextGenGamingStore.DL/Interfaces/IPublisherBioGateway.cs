using NextGenGamingStore.Models.DTO;
using NextGenGamingStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NextGenGamingStore.DL.Interfaces
{
    public interface IPublisherBioGateway
    {

        Task<PublisherBioResponse?> GetBioByPublisherId(string publisherId);

        Task<PublisherBioResponse?> GetBioByPublisher(Publisher publisher);
    }
}
