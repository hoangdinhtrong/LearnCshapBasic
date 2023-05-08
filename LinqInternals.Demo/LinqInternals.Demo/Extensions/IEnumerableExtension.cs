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

        public static IEnumerable<TResult> NewSelectMany<T, TResult>(this IEnumerable<T> items,
            Func<T, IEnumerable<TResult>> selectors)
        {
            foreach( var item in items)
            {
                foreach (var innerItem in selectors(item))
                {
                    yield return innerItem;
                }
            }
        }

        public static IEnumerable<TResult> NewJoin<T, TH, TKey, TResult>(this IEnumerable<T> items,
            IEnumerable<TH> innerItems,
            Func<T, TKey> outerKeySelectors,
            Func<TH, TKey> innerKeySelectors,
            Func<T, TH, TResult> resultSelectors)
        {
            foreach (var item in items)
            {
                if (item == null) continue;

                TKey? outerKey = outerKeySelectors(item);
                if(outerKey == null) continue;

                foreach (var innerItem in innerItems)
                {
                    if (outerKey.Equals(innerKeySelectors(innerItem)))
                    {
                        yield return resultSelectors(item,innerItem);
                    }
                }
            }
        }
    }
}
