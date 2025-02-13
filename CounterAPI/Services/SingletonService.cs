using CounterAPI.Interface;

namespace CounterAPI.Services
{
    public class SingletonService : ICount
    {
        private int _count;
        public int GetCount()
        {
            return ++_count;
        }
    }
}
