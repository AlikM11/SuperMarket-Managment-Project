using SuperMarket_Managment_Project.Commands;
using SuperMarket_Managment_Project.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SuperMarket_Managment_Project.ViewModels
{
    public class RecordViewModel : BaseViewModel
    {

        public ICommand resetpassword { get; set; }
        public RecordViewModel(NavigationStore navigation)
        {            resetpassword = new UpdateViewCommand<ResetPasswordViewModel>(navigation, () => new ResetPasswordViewModel(navigation));        }
    }
}
