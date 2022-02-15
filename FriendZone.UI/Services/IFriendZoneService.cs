using FriendZone.Models;
using System.Collections.Generic;

namespace FriendZone.UI.Services
{
    public interface IFriendZoneService
    {
        IEnumerable<Friend> GetAll();
    }
}