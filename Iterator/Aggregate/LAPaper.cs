using Iterator.Iterator;

namespace Iterator.Aggregate
{
    // ConcreteAggregate
    public class LAPaper : INewspaper
    {
        private string[] _reporters;
        public LAPaper()
        {
            _reporters = new[] { "Ronald Smith - QLD",
                                 "Danny Glover - NSW"
                                };
        }
        public IIterator CreateIterator() => new LAPaperIterator(_reporters);
    }
}
