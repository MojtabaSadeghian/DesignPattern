using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteSubject
{
    // Concrete Subject
    public class GClooney : ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;
        public GClooney(string tweet)
        {
            _tweet = tweet;
        }

        public string FullName => "George Clooney";

        public string Tweet
        {
            get => _tweet;
            set 
            {
                Notify(value);
            }
        }

        public void AddFollower(IFan fan)
        {
            _fans.Add(fan);
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            foreach (var fan in _fans)
            {
                fan.Update(this);
            }
        }

        public void RemoveFollower(IFan fan)
        {
            _fans.Remove(fan);
        }
    }
}
