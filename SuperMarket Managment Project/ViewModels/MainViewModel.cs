using SuperMarket_Managment_Project.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket_Managment_Project.ViewModels
{
    public class MainViewModel:BaseViewModel
    {

        private readonly NavigationStore _navigation;

        public BaseViewModel SelectedViewModel { get; set; }



        public MainViewModel(NavigationStore navigation)
        {
            _navigation = navigation;
            _navigation.SelectedViewModelChanged += OnSelectedViewChanged;
            SelectedViewModel = _navigation.SelectedViewModel;

        }



        protected void OnSelectedViewChanged()
        {
            SelectedViewModel = _navigation.SelectedViewModel;
            OnPropertChanged(nameof(SelectedViewModel));
        }

    }
}
