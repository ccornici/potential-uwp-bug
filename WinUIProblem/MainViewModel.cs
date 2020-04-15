using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUIProblem
{
    public class MainViewModel : Observable
    {
        public Dictionary<string, string> MyItems { get; set; } = new Dictionary<string, string>();

        public MainViewModel()
        {
            MyItems.Add("item_1", "ITEM 1");
            MyItems.Add("item_2", "ITEM 2");
            SelectedItem = "item_1";
        }

        private int _amount;
        public int Amount
        {
            get => _amount;
            set => SetProperty(ref _amount, value);
        }

        private string _selectedItem;
        public string SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        public async Task SendMoney()
        {
            Debug.WriteLine($"Sending {Amount}");
            await Task.Delay(1);
        }
    }
}
