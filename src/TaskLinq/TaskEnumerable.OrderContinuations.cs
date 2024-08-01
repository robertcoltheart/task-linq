namespace System.Linq;

public static partial class TaskEnumerable
{
    /// <inheritdoc cref="Enumerable.ThenBy{TSource,TKey}(IOrderedEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> ThenByAsync<TSource, TKey>(
        this Task<IOrderedEnumerable<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source).ThenBy(keySelector);
    }

    /// <inheritdoc cref="Enumerable.ThenBy{TSource,TKey}(IOrderedEnumerable{TSource},Func{TSource,TKey},IComparer{TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> ThenByAsync<TSource, TKey>(
        this Task<IOrderedEnumerable<TSource>> source,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source).ThenBy(keySelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.ThenByDescending{TSource,TKey}(IOrderedEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> ThenByDescendingAsync<TSource, TKey>(
        this Task<IOrderedEnumerable<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source).ThenByDescending(keySelector);
    }

    /// <inheritdoc cref="Enumerable.ThenByDescending{TSource,TKey}(IOrderedEnumerable{TSource},Func{TSource,TKey},IComparer{TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> ThenByDescendingAsync<TSource, TKey>(
        this Task<IOrderedEnumerable<TSource>> source,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source).ThenByDescending(keySelector, comparer);
    }
}
