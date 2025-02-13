using CounterAPI.Interface;

namespace CounterAPI.Services
{
    public class TransientService : ICount
    {
        private int _count;
        public int GetCount()
        {
            return ++_count;
        }
    }
}

