using FriendZone.Models;
using FriendZone.UI.Services;
using System.Collections.ObjectModel;

namespace FriendZone.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendZoneService _friendZoneService;
        public ObservableCollection<Friend> Friends { get; set; }
        private Friend _selectedFriend;

        public MainViewModel(IFriendZoneService friendZoneService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendZoneService = friendZoneService;
        }

        public void Load()
        {
            var friends = _friendZoneService.GetAll();

            Friends.Clear();

            foreach (var item in friends)
            {
                Friends.Add(item);
            }
        }

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }

            set 
            { 
                _selectedFriend = value;
                OnPropertyChanged();
            }
        }
    }
}
