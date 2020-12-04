using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Music_Player
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MusicPlayerMasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public MusicPlayerMasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new MusicPlayerMasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MusicPlayerMasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MusicPlayerMasterDetailPage1MasterMenuItem> MenuItems { get; set; }

            public MusicPlayerMasterDetailPage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<MusicPlayerMasterDetailPage1MasterMenuItem>(new[]
                {
                    new MusicPlayerMasterDetailPage1MasterMenuItem { Id = 0, Title = "Library", TargetType=typeof(LibraryPage), ImageName="music.png" },
                    new MusicPlayerMasterDetailPage1MasterMenuItem { Id = 1, Title = "Equalizer", TargetType=typeof(EqualizerPage), ImageName="equalizer.png"},
                    new MusicPlayerMasterDetailPage1MasterMenuItem { Id = 2, Title = "Sleep Timer" , TargetType=typeof(SleeptimePage), ImageName="alarm.png"},
                    new MusicPlayerMasterDetailPage1MasterMenuItem { Id = 3, Title = "Skin Theme" , TargetType = typeof(ThemePage), ImageName = "theme.png"},
                    new MusicPlayerMasterDetailPage1MasterMenuItem { Id = 4, Title = "Remove Ads" , TargetType=typeof(RemoveAdsPage), ImageName="ads.png"},
                    new MusicPlayerMasterDetailPage1MasterMenuItem { Id = 5, Title = "Settings" , TargetType=typeof(SettingsPage), ImageName="settings.png"},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}