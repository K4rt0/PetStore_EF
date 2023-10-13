using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PetStore_EF.Model
{
	public class Product
	{
		private string productImage;
		private string productName;
		private int productPrice;

		public string ProductImage { get => productImage; set => productImage = value; }
		public string ProductName { get => productName; set => productName = value; }
		public int ProductPrice { get => productPrice; set => productPrice = value; }

		public Product() { }
		public Product(string ProductImage, string ProductName, int ProductPrice)
		{
			this.ProductImage = ProductImage;
			this.ProductName = ProductName;
			this.ProductPrice = ProductPrice;
		}
	}
}
