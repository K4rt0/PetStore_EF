﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace PetStore_EF.ViewModel
{
	public class BaseVM : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		public FrameworkElement getParents(UserControl control)
		{
			FrameworkElement parent = control;
			while (parent.Parent != null)
			{
				parent = parent.Parent as FrameworkElement;
			}
			return parent;
		}
	}
	
	class RelayCommand<T> : ICommand
	{
		private readonly Predicate<T> _canExecute;
		private readonly Action<T> _execute;

		public RelayCommand(Predicate<T> canExecute, Action<T> execute)
		{
			if (execute == null)
				throw new ArgumentNullException("execute");
			_canExecute = canExecute;
			_execute = execute;
		}
		public bool CanExecute(object parameter)
		{
			try
			{
				return _canExecute == null ? true : _canExecute((T)parameter);
			}
			catch
			{
				return true;
			}
		}
		public void Execute(object parameter)
		{
			_execute((T)parameter);
		}
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
	}
}
