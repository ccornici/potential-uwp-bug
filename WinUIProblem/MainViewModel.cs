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
        private int _amount;
        public int Amount
        {
            get => _amount;
            set => SetProperty(ref _amount, value);
        }

        public async Task SendMoney()
        {
            Debug.WriteLine($"Sending {Amount}");
            await Task.Delay(1);
        }
    }
}
