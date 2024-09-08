using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemReactiveDeomes.Models
{
    internal class Observer : IObserver<Message>
    {
        public  string? Name { get; set; }

        public void OnCompleted()
        {
            Console.WriteLine($"Observer With Name {Name} Compleletd Notified from the IOserverable");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        //OnNext like the Update Function.
        public void OnNext(Message value)
        {
            Console.WriteLine($"Listen to Update : {value} With Observer Name {Name}");
        }
    }
}
