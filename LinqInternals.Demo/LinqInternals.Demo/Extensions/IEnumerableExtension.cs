namespace LinqInternals.Demo.Extensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> NewWhere<T>(this IEnumerable<T> items, 
            Func<T, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<TResult> NewSelect<T, TResult>(this IEnumerable<T> items,
            Func<T, TResult> selectors)
        {
            foreach(var item in items)
            {
                yield return selectors(item);
            }
        }
    }
}
