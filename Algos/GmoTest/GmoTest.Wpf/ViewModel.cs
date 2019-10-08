using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmoTest.Wpf
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Numbers = new ObservableCollection<NumberViewModel>();
            var o = Observable.Generate(
                    new Random(),
                    _ => true,
                    r => r,
                    r => r.Next(1, 100),
                    r => TimeSpan.FromSeconds((r.NextDouble() * 9) + 1) //A random range between 1-10 
                )
                .Timestamp()
                .Select((i, index) => (i, index))
                .ObserveOnDispatcher()
                .Subscribe(t =>
                {
                    var nvm = new NumberViewModel(t.i.Value, t.i.Timestamp.LocalDateTime);
                    Numbers.Insert(0, nvm);
                    Count = t.index + 1;    //because zero based
                });
        }

        public ObservableCollection<NumberViewModel> Numbers { get; }
        public int Count { get; set; }  //Won't work properly without DependencyProperty / MVVM framework.
    }

    public class NumberViewModel
    {
        public NumberViewModel(int number, DateTime timeProduced)
        {
            this.Number = number;
            this.TimeProduced = timeProduced.ToString("h:mm:ss.ff");
        }

        public int Number { get; }
        public string TimeProduced { get; }
    }
}
