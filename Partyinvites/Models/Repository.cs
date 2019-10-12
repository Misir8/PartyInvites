using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partyinvites.Models
{
    public class Repository
    {
        public static List<GuestResponse> Responses { get; } = new List<GuestResponse>();
        public static void AddResponse(GuestResponse response)
        {
            Responses.Add(response);
        }
    }
}
