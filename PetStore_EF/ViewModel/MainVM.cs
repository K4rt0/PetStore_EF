using PetStore_EF.Model;
using PetStore_EF.View.UserControls;
using PetStore_EF.View.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PetStore_EF.ViewModel
{
	public class MainVM : BaseVM
	{
		public ICommand LoadedMainWindowCommand { get; set; }
		public ICommand UCHomeCommand { get; set; }
		public ICommand UCCustomerCommand { get; set; }
		public ICommand UCProductCommand { get; set; }
		public ICommand UCReportCommand { get; set; }
		public ICommand IsRadioButtonChecked { get; set; }
		public string ContentCardInfo { get => _ContentCardInfo; set => _ContentCardInfo = value; }
		//public bool IsRadioButtonChecked { get => _IsRadioButtonChecked; set { _IsRadioButtonChecked = value; OnPropertyChanged(); } }

		private string _ContentCardInfo;
		//private bool _IsRadioButtonChecked;

		public MainVM()
		{
			ContentCardInfo = "Đây là một phần mềm độc đáo và tiện lợi, được thiết kế đặc biệt để hỗ trợ việc quản lý cửa hàng chăm sóc thú cưng một cách hiệu quả và việc theo dõi, điều hành cửa hàng của bạn sẽ trở nên đơn giản hơn bao giờ hết." +
				"\n\nCác tính năng của hệ thống:" +
				"\n- Đăng nhập: Chức năng hỗ trợ cho việc bảo mật của nhân viên và quản lý cửa hàng tránh gây ra những xung đột tốt nhất có thể." +
				"\n- Quản lý bán hàng thuận tiện: Với khả năng nhập và xuất hàng tồn, phần mềm con giúp bạn kiểm soát tình trạng hàng hóa trong cửa hàng một cách hiệu quả." +
				"\n- Thống kê: Pet Store còn cung cấp chức năng thống kê mạnh mẽ, giúp bạn hiểu rõ hơn về hiệu suất kinh doanh của cửa hàng. Bạn có thể theo dõi doanh số bán hàng hàng ngày, tuần, hoặc tháng, và dễ dàng xác định những mặt hàng nào đang bán chạy nhất" +
				"\n- Báo cáo chi tiết: hệ thống cung cấp chức năng báo cáo để nhân viên báo cáo số bán hằng ngày. Việc báo cáo này sẽ giúp doanh thu hằng ngày có bị sai sót hay không và chỉnh sửa gấp với chức năng ghi chú cho Admin kiểm soát." +
				"\n\nChúc bạn có một ngày làm việc thật tốt !";
			LoadedMainWindowCommand = new RelayCommand<Window>(p => { return true; }, p =>
			{
				p.Hide();
				LoginWindow loginWindow = new LoginWindow();
				loginWindow.ShowDialog();
				if ((loginWindow.DataContext as LoginVM).IsLogin == true)
				{
					p.Show();
				}
				else
					p.Close();
			});
			IsRadioButtonChecked = new RelayCommand<ContentControl>(p => { return true; }, p => { p.Content = new UC_Menu_Home(); });
			UCHomeCommand = new RelayCommand<ContentControl>(p => { return true; }, p => { p.Content = new UC_Menu_Home(); });
			UCCustomerCommand = new RelayCommand<ContentControl>(p => { return true; }, p => { });
			UCProductCommand = new RelayCommand<ContentControl>(p => { return true; }, p => { p.Content = new UC_Menu_Product(); });
			UCReportCommand = new RelayCommand<ContentControl>(p => { return true; }, p => { });
		}
	}
}
