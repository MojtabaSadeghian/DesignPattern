using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Policy
    {
        private static readonly Policy _instance = new Policy();

        public static Policy Instance {
            get
            {
                return _instance; 
            } 
        }
        private Policy()
        {

        }
        public int ID { get; set; } = 101;
        public string Insured { get; set; } = "Mojtaba";
        public string GetInsuredName() => Insured;
    }
}
