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

namespace Frisbee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public NewMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new NewMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class NewMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NewMasterDetailPageMenuItem> MenuItems { get; set; }

            public NewMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<NewMasterDetailPageMenuItem>(new[]
                {
                    new NewMasterDetailPageMenuItem { Id = 0, Title = "Profile", TargetType = typeof(Profile) },
                    new NewMasterDetailPageMenuItem { Id = 1, Title = "Gallery", TargetType = typeof(Gallery)},
                    new NewMasterDetailPageMenuItem { Id = 2, Title = "Share", TargetType = typeof(SharePage) },
                    new NewMasterDetailPageMenuItem {Id = 3, Title = "Settings", TargetType = typeof(SettingsPage)},
                    new NewMasterDetailPageMenuItem {Id = 4, Title = "Home", TargetType = typeof(NewMasterDetailPageDetail)}
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
