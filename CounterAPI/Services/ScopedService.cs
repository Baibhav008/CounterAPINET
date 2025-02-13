using CounterAPI.Interface;

namespace CounterAPI.Services
{
    public class ScopedService : ICount
    {
        private int _count;
        public int GetCount()
        {
            return ++_count;
        }
    }
}

