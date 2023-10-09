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
		public ICommand LoadedWindowCommand { get; set; }
		public MainVM()
		{
			LoadedWindowCommand = new RelayCommand<Window>(p => { return p != null; }, p => { 
				
			});
		}
	}
}
