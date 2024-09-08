using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SystemReactiveDeomes.Models
{
    internal class ObservableSimulate : IObservable<Message>
    {
        public readonly Subject<Message> _subject;
        public ObservableSimulate()=> _subject = new Subject<Message>();

        public IDisposable Subscribe(IObserver<Message> observer)
        {
           return _subject.Subscribe(observer);
        }

        public void Notify(Message newMessage)
        {
            _subject.OnNext(newMessage);
        }

       
    }
}
