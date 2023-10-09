using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace PetStore_EF.ViewModel
{
	public class ControlBarVM : BaseVM
	{
		public ICommand CloseWindowCommand { get; set; }
		public ICommand MinimizeWindowCommand { get; set; }
		public ICommand MaximizeWindowCommand { get; set; }
		public ICommand MouseMoveWindowCommand { get; set; }

		public ControlBarVM()
		{
			CloseWindowCommand = new RelayCommand<UserControl>(p => { return p == null ? false : true; }, p => {
				var window = (Window)getParents(p);
				if (window != null)
					window.Close();
			});
			MinimizeWindowCommand = new RelayCommand<UserControl>(p => { return p == null ? false : true; }, p =>
			{
				var window = (Window)getParents(p);
				if (window != null)
					window.WindowState = WindowState.Minimized;
			});
			MaximizeWindowCommand = new RelayCommand<UserControl>(p => { return p == null ? false : true; }, p =>
			{
				var window = (Window)getParents(p);
				if (window != null)
					window.WindowState = window.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
			});
			MouseMoveWindowCommand = new RelayCommand<UserControl>(p => { return p == null ? false : true; }, p =>
			{
				var window = (Window)getParents(p);
				if (window != null)
					window.DragMove();
			});
		}
	}
}
