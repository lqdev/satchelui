using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Xamarin.Forms;
using SatchelUI;
using SatchelUI.Models;
using System.Collections.ObjectModel;

namespace SatchelUI.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            ObservableCollection<ShoppingListItem> items = new ObservableCollection<ShoppingListItem>();

            ShoppingListView.ItemsSource = null;
            PurchasedListView.ItemsSource = null;
            
            items.Add(new ShoppingListItem { Id = 1, Name = "Apples", Purchased = true });
            items.Add(new ShoppingListItem { Id = 2, Name = "Bananas", Purchased = false });
            items.Add(new ShoppingListItem { Id = 3, Name = "Peanut Butter", Purchased = false});

            ShoppingListView.ItemsSource = items.Where(t => t.Purchased == true);
            PurchasedListView.ItemsSource = items.Where(t => t.Purchased == false);
        }
    }
}
