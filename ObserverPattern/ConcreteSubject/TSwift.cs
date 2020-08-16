using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteSubject
{
    public class TSwift : ICelebrity
    {
        private string _tweet;

        public string FullName => "Taylor Swift";

        public string Tweet 
        { 
            get => _tweet; 
            set 
            {
                Notify(value);
            } 
        }

        private delegate void TweetUpdate(ICelebrity celebrity);
        private event TweetUpdate OnTweetUpdate;

        public TSwift(string tweet)
        {
            _tweet = tweet;
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            if (OnTweetUpdate != null)
            {
                OnTweetUpdate(this);
            }
        }

        public void AddFollower(IFan fan)
        {
            OnTweetUpdate += fan.Update;
        }

        public void RemoveFollower(IFan fan)
        {
            OnTweetUpdate -= fan.Update;
        }
    }
}
