using PetStore_EF.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PetStore_EF.ViewModel
{
	public class MainVM : BaseVM
	{
		public ICommand LoadedMainWindowCommand { get; set; }
		public MainVM()
		{
			LoadedMainWindowCommand = new RelayCommand<Window>(p => { return true; }, p =>
			{
				p.Hide();
				LoginWindow loginWindow = new LoginWindow();
				loginWindow.ShowDialog();
				if ((loginWindow.DataContext as LoginVM).IsLogin == true)
					p.Show();
				else
					p.Close();
			});
		}
	}
}
