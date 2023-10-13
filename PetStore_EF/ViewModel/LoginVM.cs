using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using BCrypt.Net;
using PetStore_EF.Model.Class;
using System.Windows.Controls;
using PetStore_EF.Model;
using PetStore_EF.View.Windows;
using System.ComponentModel;

namespace PetStore_EF.ViewModel
{
	public class LoginVM : BaseVM
	{
		public ICommand CloseWindowCommand { get; set; }
		public ICommand LoginWindowCommand { get; set; }
		public ICommand TextChangedUsernameCommand { get; set; }
		public ICommand PasswordChangedPasswordCommand { get; set; }
		public bool IsLogin { get; set; }
		public string Username { get => _Username; set { _Username = value; OnPropertyChanged(); } }
		public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
		public Visibility VisibilityErrorMessage { get => _VisibilityErrorMessage; set { _VisibilityErrorMessage = value; OnPropertyChanged(); } }
		public string TextVisibilityErrorMessage { get => _TextVisibilityErrorMessage; set { _TextVisibilityErrorMessage = value; OnPropertyChanged(); } }

		private string _Username;
		private string _Password;
		private Visibility _VisibilityErrorMessage;
		private string _TextVisibilityErrorMessage;

		public LoginVM()
		{
			IsLogin = false;
			Username = Password = "";
			TextVisibilityErrorMessage = "";
			VisibilityErrorMessage = Visibility.Collapsed; // Collapsed, Visible, Hidden

			CloseWindowCommand = new RelayCommand<Window>(p => { return true; }, p => { p.Close(); });
			LoginWindowCommand = new RelayCommand<Window>(p => { return true; }, p =>
			{
				/*Window w = new Window();
				TextBox t = new TextBox();
				t.Text = hashPassword("admin");
				w.Content = t;
				w.Show();*/

				if (!IsUserExists(Username))
					showHint("Tài khoản không tồn tại trong hệ thống.");
				else if (Password.Length == 0 || !verifyPassword(Password, getPassword(Username)))
					showHint("Mật khẩu không hợp lệ.");
				else if (Username.Length == 0)
					showHint("Không được bỏ trống tên đăng nhập.");
				else { IsLogin = true; p.Close(); }
			});
			TextChangedUsernameCommand = new RelayCommand<TextBox>(p => { return true; }, p => { VisibilityErrorMessage = Visibility.Collapsed; });
			PasswordChangedPasswordCommand = new RelayCommand<PasswordBox>(p => { return true; }, p => { VisibilityErrorMessage = Visibility.Collapsed; Password = p.Password; });
		}
		void showHint(string hint)
		{
			TextVisibilityErrorMessage = hint;
			VisibilityErrorMessage = Visibility.Visible;
		}
		string getPassword(string username) => DataProvider.Ins.DB.accounts.Where(p => p.Username == username).FirstOrDefault().Password;
		string hashPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
		bool verifyPassword(string password, string hashedPassword) => BCrypt.Net.BCrypt.Verify(password, hashedPassword);
		bool IsUserExists(string username) => DataProvider.Ins.DB.accounts.Where(p => p.Username == username).Any();
	}
}
