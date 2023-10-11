using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PetStore_EF.ViewModel
{
	public class ItemSelected
	{
		private string stt;
		private string name;
		private int amount;
		private double price;

		public string Name { get => name; set => name = value; }
		public int Amount { get => amount; set => amount = value; }
		public double Price { get => price; set => price = value; }
		public string Stt { get => stt; set => stt = value; }

		public ItemSelected(string stt, string name, int amount, double price)
		{
			this.Stt = stt;
			this.name = name;
			this.amount = amount;
			this.price = price;
		}
	}
	public class UC_BillVM : BaseVM
	{
		private ObservableCollection<ItemSelected> listItemSelected;
		public ObservableCollection<ItemSelected> ListItemSelected { get => listItemSelected; set => listItemSelected = value; }
		public UC_BillVM()
		{
			ListItemSelected = new ObservableCollection<ItemSelected> {
				new ItemSelected("1.", "Thức ăn cho chó", 10, 100000000),
				new ItemSelected("2.", "12312321", 10, 100000000),
				new ItemSelected("3.", "!@#!@#", 10, 100000000),
				new ItemSelected("4.", "aaasdhó", 10, 100000000),
				new ItemSelected("5.", "aa@232asdhó", 10, 100000000),
				new ItemSelected("6.", "asdasaasdhó", 10, 100000000),
				new ItemSelected("7.", "a4214sdasdaasdhó", 10, 100000000),
				new ItemSelected("8.", "aa4141asdhó", 10, 100000000),
				new ItemSelected("9.", "@42141aaAsad chó", 10, 100000000)
			};
		}

	}
}
