namespace DILifeTime.Demo.Respositories
{
    public class Counter : ICounter
    {
        private int count;

        public void InCrement() => count++;

        public int Get() => count;
    }
}
