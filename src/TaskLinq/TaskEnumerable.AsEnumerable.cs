namespace System.Linq;

public static partial class TaskEnumerable
{
    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
        this Task<IEnumerable<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).AsEnumerable();
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
        this Task<IOrderedEnumerable<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<IGrouping<TKey, TElement>>> AsEnumerableAsync<TKey, TElement>(
        this Task<ILookup<TKey, TElement>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TElement>> AsEnumerableAsync<TKey, TElement>(
        this Task<IGrouping<TKey, TElement>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
        this Task<ICollection<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
        this Task<IList<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
        this Task<ISet<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
        this Task<HashSet<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> AsEnumerableAsync<TSource>(
        this Task<TSource[]> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<KeyValuePair<TKey, TValue>>> AsEnumerableAsync<TKey, TValue>(
        this Task<IDictionary<TKey, TValue>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }

    /// <inheritdoc cref="Enumerable.AsEnumerable{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<KeyValuePair<TKey, TValue>>> AsEnumerableAsync<TKey, TValue>(
        this Task<Dictionary<TKey, TValue>> source,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return await source.ConfigureAwait(false);
    }
}
