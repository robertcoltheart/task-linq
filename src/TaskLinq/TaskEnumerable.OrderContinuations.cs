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

        return (await source.ConfigureAwait(false)).ThenBy(keySelector);
    }

    /// <inheritdoc cref="Enumerable.ThenBy{TSource,TKey}(IOrderedEnumerable{TSource},Func{TSource,TKey},IComparer{TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> ThenByAsync<TSource, TKey>(
        this Task<IOrderedEnumerable<TSource>> source,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ThenBy(keySelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.ThenByDescending{TSource,TKey}(IOrderedEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> ThenByDescendingAsync<TSource, TKey>(
        this Task<IOrderedEnumerable<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ThenByDescending(keySelector);
    }

    /// <inheritdoc cref="Enumerable.ThenByDescending{TSource,TKey}(IOrderedEnumerable{TSource},Func{TSource,TKey},IComparer{TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> ThenByDescendingAsync<TSource, TKey>(
        this Task<IOrderedEnumerable<TSource>> source,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ThenByDescending(keySelector, comparer);
    }
}
