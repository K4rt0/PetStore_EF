using PetStore_EF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PetStore_EF.ViewModel
{
	public class UC_Menu_ProductVM : BaseVM
	{
		private ObservableCollection<Product> _products;
		public ObservableCollection<Product> Products { get => _products; set => _products = value; }
		public UC_Menu_ProductVM()
		{
			Products = new ObservableCollection<Product>
			{
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000),
				new Product("C:\\Users\\K4rt0\\Desktop\\WindowsProgram\\PetStore\\Assets\\Products\\Product_1.png", "Bóng cao su", 100000)
			};
		}
	}
}
