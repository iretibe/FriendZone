using FriendZone.Models;
using System.Collections.Generic;

namespace FriendZone.UI.Services
{
    public class FriendZoneService : IFriendZoneService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend
            {
                FirstName = "Thomas",
                LastName = "Lemar"
            };

            yield return new Friend
            {
                FirstName = "Luis",
                LastName = "Suarez"
            };

            yield return new Friend
            {
                FirstName = "Samuel",
                LastName = "Eto'o"
            };

            yield return new Friend
            {
                FirstName = "Luis",
                LastName = "Muriel"
            };

            yield return new Friend
            {
                FirstName = "Angel",
                LastName = "Di Maria"
            };
        }
    }
}
