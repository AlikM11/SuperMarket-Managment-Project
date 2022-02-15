using SuperMarket_Managment_Project.Stores;
using SuperMarket_Managment_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SuperMarket_Managment_Project.Commands
{
    public class UpdateViewCommand<TViewModel> : ICommand where TViewModel : BaseViewModel
    {
        private NavigationStore _navigatinStore;

        private readonly Func<TViewModel> _createViewModel;

        public UpdateViewCommand(NavigationStore navigatinStore, Func<TViewModel> createViewModel)
        {
            _navigatinStore = navigatinStore;
            _createViewModel = createViewModel;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _navigatinStore.SelectedViewModel = _createViewModel();
        }
    }
}
