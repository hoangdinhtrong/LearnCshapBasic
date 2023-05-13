using System.Reactive.Subjects;

namespace ReactExtension.Demo
{
    public class EvenNumberSubject : IDisposable
    {
        //// Subject must run before Run method
        //private readonly Subject<int> subject = new Subject<int>();

        //// ReplaySubject can run after Run method
        //private readonly ReplaySubject<int> subject = new ReplaySubject<int>();

        //// BehaviorSubject can run after Run method, and only print last one
        //private readonly BehaviorSubject<int> subject = new BehaviorSubject<int>(0);

        // Similar BehaviorSubject but we need call Oncompleted method to print and only print first one 
        // when condition be true
        private readonly AsyncSubject<int> subject = new AsyncSubject<int>();

        public readonly List<IDisposable> disposables = new List<IDisposable>();

        public void Dispose()
        {
            subject?.Dispose();
            foreach (var disposable in disposables)
            {
                disposable?.Dispose();
            }
        }

        public void Run()
        {
            Enumerable.Range(1, 100).Where(x => x % 2 == 0).ToList().ForEach(x =>
            {
                subject?.OnNext(x);
                // AsyncSubject
                if(x == 100) subject?.OnCompleted();
            });
        }

        public void Subcribe(Action<int> action)
        {
            disposables.Add(subject.Subscribe(action));
        }
    }
}
