using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Aggregate
{
    // ConcreteAggregate
    public class NYPaper : INewspaper
    {
        private List<string> _reporters;
        public NYPaper()
        {
            _reporters = new List<string>
                        {"John Mesh - NY",
                         "Susanna Lee - NY",
                         "Paul Randy - NY",
                         "Kim Fields - NY",
                         "Sky Taylor - NY"
                        };
        }

        public IIterator CreateIterator() => new NYPaperIterator(_reporters);
    }
}