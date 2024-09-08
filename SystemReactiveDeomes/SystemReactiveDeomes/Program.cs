using System.Reactive.Linq;
using SystemReactiveDeomes.Models;

namespace SystemReactiveDeomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableSimulate observable = new ObservableSimulate();
            var observer_1  = new Observer() { Name="First Observer"};
            var observer_2 = new Observer() { Name = "Second Observer" };

            observable.Subscribe(observer_1);
            observable.Subscribe(observer_2);

            observable.Notify(new("Hello World....!"));

        }
    }
}
