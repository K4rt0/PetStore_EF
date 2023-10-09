using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace PetStore_EF.ViewModel
{
	public class LoginVM : BaseVM
	{
		public ICommand CloseWindowCommand { get; set; }
		public ICommand LoginWindowCommand { get; set; }
		public bool IsLogin { get; set; }

		public LoginVM()
		{
			CloseWindowCommand = new RelayCommand<Window>(p => { return true; }, p => { IsLogin = false; p.Close(); });
			LoginWindowCommand = new RelayCommand<Window>(p => { return true; }, p => { IsLogin = true; p.Close(); });
		}
	}
}
