using System.Collections;

namespace System.Linq;

public static partial class TaskEnumerable
{
    /// <inheritdoc cref="Enumerable.Aggregate{TSource}(IEnumerable{TSource},Func{TSource,TSource,TSource})" />
    public static async Task<TSource> AggregateAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, TSource, TSource> func,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Aggregate(func);
    }

    /// <inheritdoc cref="Enumerable.Aggregate{TSource,TAccumulate}(IEnumerable{TSource},TAccumulate,Func{TAccumulate,TSource,TAccumulate})" />
    public static async Task<TAccumulate> AggregateAsync<TSource, TAccumulate>(
        this Task<List<TSource>> source,
        TAccumulate seed,
        Func<TAccumulate, TSource, TAccumulate> func,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Aggregate(seed, func);
    }

    /// <inheritdoc cref="Enumerable.Aggregate{TSource,TAccumulate,TResult}(IEnumerable{TSource},TAccumulate,Func{TAccumulate,TSource,TAccumulate},Func{TAccumulate,TResult})" />
    public static async Task<TResult> AggregateAsync<TSource, TAccumulate, TResult>(
        this Task<List<TSource>> source,
        TAccumulate seed,
        Func<TAccumulate, TSource, TAccumulate> func,
        Func<TAccumulate, TResult> resultSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Aggregate(seed, func, resultSelector);
    }

    /// <inheritdoc cref="Enumerable.Any{TSource}(IEnumerable{TSource})" />
    public static async Task<bool> AnyAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Any();
    }

    /// <inheritdoc cref="Enumerable.Any{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<bool> AnyAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Any(predicate);
    }

    /// <inheritdoc cref="Enumerable.All{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<bool> AllAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).All(predicate);
    }

    /// <inheritdoc cref="Enumerable.Append{TSource}(IEnumerable{TSource},TSource)" />
    public static async Task<IEnumerable<TSource>> AppendAsync<TSource>(
        this Task<List<TSource>> source,
        TSource element,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Append(element);
    }

    /// <inheritdoc cref="Enumerable.Prepend{TSource}(IEnumerable{TSource},TSource)" />
    public static async Task<IEnumerable<TSource>> PrependAsync<TSource>(
        this Task<List<TSource>> source,
        TSource element,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Prepend(element);
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{int})" />
    public static async Task<double> AverageAsync(
        this Task<List<int>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{long})" />
    public static async Task<double> AverageAsync(
        this Task<List<long>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{float})" />
    public static async Task<float> AverageAsync(
        this Task<List<float>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{double})" />
    public static async Task<double> AverageAsync(
        this Task<List<double>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{decimal})" />
    public static async Task<decimal> AverageAsync(
        this Task<List<decimal>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{int?})" />
    public static async Task<double?> AverageAsync(
        this Task<List<int?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{long?})" />
    public static async Task<double?> AverageAsync(
        this Task<List<long?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{float?})" />
    public static async Task<float?> AverageAsync(
        this Task<List<float?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{double?})" />
    public static async Task<double?> AverageAsync(
        this Task<List<double?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average(IEnumerable{decimal?})" />
    public static async Task<decimal?> AverageAsync(
        this Task<List<decimal?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average();
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,int})" />
    public static async Task<double> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,long})" />
    public static async Task<double> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, long> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,float})" />
    public static async Task<float> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, float> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,double})" />
    public static async Task<double> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, double> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,decimal})" />
    public static async Task<decimal> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, decimal> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,int?})" />
    public static async Task<double?> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,long?})" />
    public static async Task<double?> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, long?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,float?})" />
    public static async Task<float?> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, float?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,double?})" />
    public static async Task<double?> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, double?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.Average{TSource}(IEnumerable{TSource},Func{TSource,decimal?})" />
    public static async Task<decimal?> AverageAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, decimal?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Average(selector);
    }

    /// <inheritdoc cref="Enumerable.OfType{TSource}(IEnumerable)" />
    public static async Task<IEnumerable<TResult>> OfTypeAsync<TSource, TResult>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).OfType<TResult>();
    }

    /// <inheritdoc cref="Enumerable.Cast{TResult}(IEnumerable)" />
    public static async Task<IEnumerable<TResult>> CastAsync<TSource, TResult>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Cast<TResult>();
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.Chunk{TSource}(IEnumerable{TSource},int)" />
    public static async Task<IEnumerable<TSource[]>> ChunkAsync<TSource>(
        this Task<List<TSource>> source,
        int size,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Chunk(size);
    }
#endif

    /// <inheritdoc cref="Enumerable.Concat{TSource}(IEnumerable{TSource},IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> ConcatAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Concat(second);
    }

    /// <inheritdoc cref="Enumerable.Contains{TSource}(IEnumerable{TSource},TSource)" />
    public static async Task<bool> ContainsAsync<TSource>(
        this Task<List<TSource>> source,
        TSource value,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Contains(value);
    }

    /// <inheritdoc cref="Enumerable.Contains{TSource}(IEnumerable{TSource},TSource,IEqualityComparer{TSource})" />
    public static async Task<bool> ContainsAsync<TSource>(
        this Task<List<TSource>> source,
        TSource value,
        IEqualityComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Contains(value, comparer);
    }

    /// <inheritdoc cref="Enumerable.Count{TSource}(IEnumerable{TSource})" />
    public static async Task<int> CountAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Count();
    }

    /// <inheritdoc cref="Enumerable.Count{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<int> CountAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Count(predicate);
    }

    ///// <inheritdoc cref="Enumerable.Count{TSource}(IEnumerable{TSource})" />
    //public static async Task<bool> TryGetNonEnumeratedCountAsync<TSource>(
    //    this Task<List<TSource>> source,
    //    out int count,
    //    CancellationToken cancellationToken = default)
    //{
    //    cancellationToken.ThrowIfCancellationRequested();

    //    return (await source.ConfigureAwait(false));
    //}

    /// <inheritdoc cref="Enumerable.LongCount{TSource}(IEnumerable{TSource})" />
    public static async Task<long> LongCountAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).LongCount();
    }

    /// <inheritdoc cref="Enumerable.LongCount{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<long> LongCountAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).LongCount(predicate);
    }

    /// <inheritdoc cref="Enumerable.DefaultIfEmpty{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource?>> DefaultIfEmptyAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).DefaultIfEmpty();
    }

    /// <inheritdoc cref="Enumerable.DefaultIfEmpty{TSource}(IEnumerable{TSource},TSource)" />
    public static async Task<IEnumerable<TSource>> DefaultIfEmptyAsync<TSource>(
        this Task<List<TSource>> source,
        TSource defaultValue,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).DefaultIfEmpty(defaultValue);
    }

    /// <inheritdoc cref="Enumerable.Distinct{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> DistinctAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Distinct();
    }

    /// <inheritdoc cref="Enumerable.Distinct{TSource}(IEnumerable{TSource},IEqualityComparer{TSource})" />
    public static async Task<IEnumerable<TSource>> DistinctAsync<TSource>(
        this Task<List<TSource>> source,
        IEqualityComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Distinct(comparer);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.DistinctBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<IEnumerable<TSource>> DistinctByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).DistinctBy(keySelector);
    }

    /// <inheritdoc cref="Enumerable.DistinctBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<TSource>> DistinctByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).DistinctBy(keySelector, comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.ElementAt{TSource}(IEnumerable{TSource},int)" />
    public static async Task<TSource> ElementAtAsync<TSource>(
        this Task<List<TSource>> source,
        int index,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ElementAt(index);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.ElementAt{TSource}(IEnumerable{TSource},Index)" />
    public static async Task<TSource> ElementAtAsync<TSource>(
        this Task<List<TSource>> source,
        Index index,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ElementAt(index);
    }
#endif

    /// <inheritdoc cref="Enumerable.ElementAtOrDefault{TSource}(IEnumerable{TSource},int)" />
    public static async Task<TSource?> ElementAtOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        int index,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ElementAtOrDefault(index);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.ElementAtOrDefault{TSource}(IEnumerable{TSource},Index)" />
    public static async Task<TSource?> ElementAtOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        Index index,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ElementAtOrDefault(index);
    }
#endif

    /// <inheritdoc cref="Enumerable.Except{TSource}(IEnumerable{TSource},IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> ExceptAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Except(second);
    }

    /// <inheritdoc cref="Enumerable.Except{TSource}(IEnumerable{TSource},IEnumerable{TSource},IEqualityComparer{TSource}?)" />
    public static async Task<IEnumerable<TSource>> ExceptAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        IEqualityComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Except(second, comparer);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.ExceptBy{TSource,TKey}(IEnumerable{TSource},IEnumerable{TKey},Func{TSource,TKey})" />
    public static async Task<IEnumerable<TSource>> ExceptByAsync<TSource, TKey>(
        this Task<List<TSource>> first,
        IEnumerable<TKey> second,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).ExceptBy(second, keySelector);
    }

    /// <inheritdoc cref="Enumerable.ExceptBy{TSource,TKey}(IEnumerable{TSource},IEnumerable{TKey},Func{TSource,TKey},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<TSource>> ExceptByAsync<TSource, TKey>(
        this Task<List<TSource>> first,
        IEnumerable<TKey> second,
        Func<TSource, TKey> keySelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).ExceptBy(second, keySelector, comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.First{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource> FirstAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).First();
    }

    /// <inheritdoc cref="Enumerable.First{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<TSource> FirstAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).First(predicate);
    }

    /// <inheritdoc cref="Enumerable.FirstOrDefault{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource?> FirstOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).FirstOrDefault();
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.FirstOrDefault{TSource}(IEnumerable{TSource},TSource)" />
    public static async Task<TSource> FirstOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        TSource defaultValue,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).FirstOrDefault(defaultValue);
    }
#endif

    /// <inheritdoc cref="Enumerable.FirstOrDefault{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<TSource?> FirstOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).FirstOrDefault(predicate);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.FirstOrDefault{TSource}(IEnumerable{TSource},Func{TSource,bool},TSource)" />
    public static async Task<TSource> FirstOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        TSource defaultValue,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).FirstOrDefault(predicate, defaultValue);
    }
#endif

    /// <inheritdoc cref="Enumerable.GroupBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<IEnumerable<IGrouping<TKey, TSource>>> GroupByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).GroupBy(keySelector);
    }

    /// <inheritdoc cref="Enumerable.GroupBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<IGrouping<TKey, TSource>>> GroupByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).GroupBy(keySelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.GroupBy{TSource,TKey,TElement}(IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement})" />
    public static async Task<IEnumerable<IGrouping<TKey, TElement>>> GroupByAsync<TSource, TKey, TElement>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).GroupBy(keySelector, elementSelector);
    }

    /// <inheritdoc cref="Enumerable.GroupBy{TSource,TKey,TElement}(IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<IGrouping<TKey, TElement>>> GroupByAsync<TSource, TKey, TElement>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).GroupBy(keySelector, elementSelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.GroupBy{TSource,TKey,TResult}(IEnumerable{TSource},Func{TSource,TKey},Func{TKey,IEnumerable{TSource},TResult})" />
    public static async Task<IEnumerable<TResult>> GroupByAsync<TSource, TKey, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).GroupBy(keySelector, resultSelector);
    }

    /// <inheritdoc cref="Enumerable.GroupBy{TSource,TKey,TElement,TResult}(IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement},Func{TKey,IEnumerable{TElement},TResult})" />
    public static async Task<IEnumerable<TResult>> GroupByAsync<TSource, TKey, TElement, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector,
        Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).GroupBy(keySelector, elementSelector, resultSelector);
    }

    /// <inheritdoc cref="Enumerable.GroupBy{TSource,TKey,TResult}(IEnumerable{TSource},Func{TSource,TKey},Func{TKey,IEnumerable{TSource},TResult},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<TResult>> GroupByAsync<TSource, TKey, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).GroupBy(keySelector, resultSelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.GroupBy{TSource,TKey,TElement,TResult}(IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement},Func{TKey,IEnumerable{TElement},TResult},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<TResult>> GroupByAsync<TSource, TKey, TElement, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector,
        Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).GroupBy(keySelector, elementSelector, resultSelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.GroupJoin{TOuter, TInner, TKey, TResult}(IEnumerable{TOuter},IEnumerable{TInner},Func{TOuter,TKey},Func{TInner,TKey},Func{TOuter,IEnumerable{TInner},TResult})" />
    public static async Task<IEnumerable<TResult>> GroupJoinAsync<TOuter, TInner, TKey, TResult>(
        this Task<List<TOuter>> outer,
        IEnumerable<TInner> inner,
        Func<TOuter, TKey> outerKeySelector,
        Func<TInner, TKey> innerKeySelector,
        Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await outer).GroupJoin(inner, outerKeySelector, innerKeySelector, resultSelector);
    }

    /// <inheritdoc cref="Enumerable.GroupJoin{TOuter, TInner, TKey, TResult}(IEnumerable{TOuter},IEnumerable{TInner},Func{TOuter,TKey},Func{TInner,TKey},Func{TOuter,IEnumerable{TInner},TResult},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<TResult>> GroupJoinAsync<TOuter, TInner, TKey, TResult>(
        this Task<List<TOuter>> outer,
        IEnumerable<TInner> inner,
        Func<TOuter, TKey> outerKeySelector,
        Func<TInner, TKey> innerKeySelector,
        Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await outer).GroupJoin(inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.Intersect{TSource}(IEnumerable{TSource},IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> IntersectAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Intersect(second);
    }

    /// <inheritdoc cref="Enumerable.Intersect{TSource}(IEnumerable{TSource},IEnumerable{TSource},IEqualityComparer{TSource})" />
    public static async Task<IEnumerable<TSource>> IntersectAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        IEqualityComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Intersect(second, comparer);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.IntersectBy{TSource,TKey}(IEnumerable{TSource},IEnumerable{TKey},Func{TSource,TKey})" />
    public static async Task<IEnumerable<TSource>> IntersectByAsync<TSource, TKey>(
        this Task<List<TSource>> first,
        IEnumerable<TKey> second,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).IntersectBy(second, keySelector);
    }

    /// <inheritdoc cref="Enumerable.IntersectBy{TSource,TKey}(IEnumerable{TSource},IEnumerable{TKey},Func{TSource,TKey},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<TSource>> IntersectByAsync<TSource, TKey>(
        this Task<List<TSource>> first,
        IEnumerable<TKey> second,
        Func<TSource, TKey> keySelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).IntersectBy(second, keySelector, comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.Join{TOuter, TInner, TKey, TResult}(IEnumerable{TOuter},IEnumerable{TInner},Func{TOuter,TKey},Func{TInner,TKey},Func{TOuter,TInner,TResult})" />
    public static async Task<IEnumerable<TResult>> JoinAsync<TOuter, TInner, TKey, TResult>(
        this Task<List<TOuter>> outer,
        IEnumerable<TInner> inner,
        Func<TOuter, TKey> outerKeySelector,
        Func<TInner, TKey> innerKeySelector,
        Func<TOuter, TInner, TResult> resultSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await outer).Join(inner, outerKeySelector, innerKeySelector, resultSelector);
    }

    /// <inheritdoc cref="Enumerable.Join{TOuter, TInner, TKey, TResult}(IEnumerable{TOuter},IEnumerable{TInner},Func{TOuter,TKey},Func{TInner,TKey},Func{TOuter,TInner,TResult},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<TResult>> JoinAsync<TOuter, TInner, TKey, TResult>(
        this Task<List<TOuter>> outer,
        IEnumerable<TInner> inner,
        Func<TOuter, TKey> outerKeySelector,
        Func<TInner, TKey> innerKeySelector,
        Func<TOuter, TInner, TResult> resultSelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await outer).Join(inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.Last{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource> LastAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Last();
    }

    /// <inheritdoc cref="Enumerable.Last{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<TSource> LastAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Last(predicate);
    }

    /// <inheritdoc cref="Enumerable.LastOrDefault{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource?> LastOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).LastOrDefault();
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.LastOrDefault{TSource}(IEnumerable{TSource},TSource)" />
    public static async Task<TSource> LastOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        TSource defaultValue,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).LastOrDefault(defaultValue);
    }
#endif

    /// <inheritdoc cref="Enumerable.LastOrDefault{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<TSource?> LastOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).LastOrDefault(predicate);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.LastOrDefault{TSource}(IEnumerable{TSource},Func{TSource,bool},TSource)" />
    public static async Task<TSource> LastOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        TSource defaultValue,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).LastOrDefault(predicate, defaultValue);
    }
#endif

    /// <inheritdoc cref="Enumerable.ToLookup{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToLookup(keySelector);
    }

    /// <inheritdoc cref="Enumerable.ToLookup{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey},IEqualityComparer{TKey})" />
    public static async Task<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToLookup(keySelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.ToLookup{TSource,TKey,TElement}(IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement})" />
    public static async Task<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToLookup(keySelector, elementSelector);
    }

    /// <inheritdoc cref="Enumerable.ToLookup{TSource,TKey,TElement}(IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement},IEqualityComparer{TKey})" />
    public static async Task<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToLookup(keySelector, elementSelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{int})" />
    public static async Task<int> MaxAsync(
        this Task<List<int>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{long})" />
    public static async Task<long> MaxAsync(
        this Task<List<long>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{int?})" />
    public static async Task<int?> MaxAsync(
        this Task<List<int?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{long?})" />
    public static async Task<long?> MaxAsync(
        this Task<List<long?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{double})" />
    public static async Task<double> MaxAsync(
        this Task<List<double>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{double?})" />
    public static async Task<double?> MaxAsync(
        this Task<List<double?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{float})" />
    public static async Task<float> MaxAsync(
        this Task<List<float>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{float?})" />
    public static async Task<float?> MaxAsync(
        this Task<List<float?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{decimal})" />
    public static async Task<decimal> MaxAsync(
        this Task<List<decimal>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max(IEnumerable{decimal?})" />
    public static async Task<decimal?> MaxAsync(
        this Task<List<decimal?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource?> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max();
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},IComparer{TSource})" />
    public static async Task<TSource?> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        IComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(comparer);
    }

    /// <inheritdoc cref="Enumerable.MaxBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<TSource?> MaxByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).MaxBy(keySelector);
    }

    /// <inheritdoc cref="Enumerable.MaxBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey},IComparer{TKey}?)" />
    public static async Task<TSource?> MaxByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).MaxBy(keySelector, comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,int})" />
    public static async Task<int> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,int?})" />
    public static async Task<int?> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,long})" />
    public static async Task<long> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, long> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,long?})" />
    public static async Task<long?> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, long?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,float})" />
    public static async Task<float> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, float> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,float?})" />
    public static async Task<float?> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, float?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,double})" />
    public static async Task<double> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, double> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,double?})" />
    public static async Task<double?> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, double?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,decimal})" />
    public static async Task<decimal> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, decimal> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource}(IEnumerable{TSource},Func{TSource,decimal?})" />
    public static async Task<decimal?> MaxAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, decimal?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Max{TSource,TResult}(IEnumerable{TSource},Func{TSource,TResult})" />
    public static async Task<TResult?> MaxAsync<TSource, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, TResult> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Max(selector);
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{int})" />
    public static async Task<int> MinAsync(
        this Task<List<int>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{int})" />
    public static async Task<long> MinAsync(
        this Task<List<long>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{int?})" />
    public static async Task<int?> MinAsync(
        this Task<List<int?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{long?})" />
    public static async Task<long?> MinAsync(
        this Task<List<long?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{float})" />
    public static async Task<float> MinAsync(
        this Task<List<float>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{float?})" />
    public static async Task<float?> MinAsync(
        this Task<List<float?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{double})" />
    public static async Task<double> MinAsync(
        this Task<List<double>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{double?})" />
    public static async Task<double?> MinAsync(
        this Task<List<double?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{decimal})" />
    public static async Task<decimal> MinAsync(
        this Task<List<decimal>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min(IEnumerable{decimal?})" />
    public static async Task<decimal?> MinAsync(
        this Task<List<decimal?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource?> MinAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min();
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},IComparer{TSource})" />
    public static async Task<TSource?> MinAsync<TSource>(
        this Task<List<TSource>> source,
        IComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(comparer);
    }

    /// <inheritdoc cref="Enumerable.MinBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<TSource?> MinByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).MinBy(keySelector);
    }

    /// <inheritdoc cref="Enumerable.MinBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey},IComparer{TKey})" />
    public static async Task<TSource?> MinByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).MinBy(keySelector, comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,int})" />
    public static async Task<int> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,int?})" />
    public static async Task<int?> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,long})" />
    public static async Task<long> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, long> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,long?})" />
    public static async Task<long?> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, long?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,float})" />
    public static async Task<float> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, float> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,float?})" />
    public static async Task<float?> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, float?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,double})" />
    public static async Task<double> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, double> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,double?})" />
    public static async Task<double?> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, double?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,decimal})" />
    public static async Task<decimal> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, decimal> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource}(IEnumerable{TSource},Func{TSource,decimal?})" />
    public static async Task<decimal?> MinAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, decimal?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

    /// <inheritdoc cref="Enumerable.Min{TSource,TResult}(IEnumerable{TSource},Func{TSource,TResult})" />
    public static async Task<TResult?> MinAsync<TSource, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, TResult> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Min(selector);
    }

#if NET8_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.Order{T}(IEnumerable{T})" />
    public static async Task<IOrderedEnumerable<T>> OrderAsync<T>(
        this Task<List<T>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Order();
    }

    /// <inheritdoc cref="Enumerable.Order{T}(IEnumerable{T},IComparer{T})" />
    public static async Task<IOrderedEnumerable<T>> OrderAsync<T>(
        this Task<List<T>> source,
        IComparer<T>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Order(comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.OrderBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> OrderByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).OrderBy(keySelector);
    }

    /// <inheritdoc cref="Enumerable.OrderBy{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey},IComparer{TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> OrderByAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).OrderBy(keySelector, comparer);
    }

#if NET8_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.OrderDescending{T}(IEnumerable{T})" />
    public static async Task<IOrderedEnumerable<T>> OrderDescendingAsync<T>(
        this Task<List<T>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).OrderDescending();
    }

    /// <inheritdoc cref="Enumerable.OrderDescending{T}(IEnumerable{T},IComparer{T})" />
    public static async Task<IOrderedEnumerable<T>> OrderDescendingAsync<T>(
        this Task<List<T>> source,
        IComparer<T>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).OrderDescending(comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.OrderByDescending{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> OrderByDescendingAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).OrderByDescending(keySelector);
    }

    /// <inheritdoc cref="Enumerable.OrderByDescending{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey},IComparer{TKey})" />
    public static async Task<IOrderedEnumerable<TSource>> OrderByDescendingAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).OrderByDescending(keySelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.Reverse{TSource}(IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> ReverseAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Reverse<TSource>();
    }

    /// <inheritdoc cref="Enumerable.Select{TSource,TResult}(IEnumerable{TSource},Func{TSource,TResult})" />
    public static async Task<IEnumerable<TResult>> SelectAsync<TSource, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, TResult> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Select(selector);
    }

    /// <inheritdoc cref="Enumerable.Select{TSource,TResult}(IEnumerable{TSource},Func{TSource,int,TResult})" />
    public static async Task<IEnumerable<TResult>> SelectAsync<TSource, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, int, TResult> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Select(selector);
    }

    /// <inheritdoc cref="Enumerable.SelectMany{TSource,TResult}(IEnumerable{TSource},Func{TSource,IEnumerable{TResult}})" />
    public static async Task<IEnumerable<TResult>> SelectManyAsync<TSource, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, IEnumerable<TResult>> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SelectMany(selector);
    }

    /// <inheritdoc cref="Enumerable.SelectMany{TSource,TResult}(IEnumerable{TSource},Func{TSource,IEnumerable{TResult}})" />
    public static async Task<IEnumerable<TResult>> SelectManyAsync<TSource, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, int, IEnumerable<TResult>> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SelectMany(selector);
    }

    /// <inheritdoc cref="Enumerable.SelectMany{TSource,TCollection,TResult}(IEnumerable{TSource},Func{TSource,int,IEnumerable{TCollection}},Func{TSource,TCollection,TResult})" />
    public static async Task<IEnumerable<TResult>> SelectManyAsync<TSource, TCollection, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, int, IEnumerable<TCollection>> collectionSelector,
        Func<TSource, TCollection, TResult> resultSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SelectMany(collectionSelector, resultSelector);
    }

    /// <inheritdoc cref="Enumerable.SelectMany{TSource,TCollection,TResult}(IEnumerable{TSource},Func{TSource,IEnumerable{TCollection}},Func{TSource,TCollection,TResult})" />
    public static async Task<IEnumerable<TResult>> SelectManyAsync<TSource, TCollection, TResult>(
        this Task<List<TSource>> source,
        Func<TSource, IEnumerable<TCollection>> collectionSelector,
        Func<TSource, TCollection, TResult> resultSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SelectMany(collectionSelector, resultSelector);
    }

    /// <inheritdoc cref="Enumerable.SequenceEqual{TSource}(IEnumerable{TSource},IEnumerable{TSource})" />
    public static async Task<bool> SequenceEqualAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).SequenceEqual(second);
    }

    /// <inheritdoc cref="Enumerable.SequenceEqual{TSource}(IEnumerable{TSource},IEnumerable{TSource},IEqualityComparer{TSource}?)" />
    public static async Task<bool> SequenceEqualAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        IEqualityComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).SequenceEqual(second, comparer);
    }

    /// <inheritdoc cref="Enumerable.Single{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource> SingleAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Single();
    }

    /// <inheritdoc cref="Enumerable.Single{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<TSource> SingleAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Single(predicate);
    }

    /// <inheritdoc cref="Enumerable.SingleOrDefault{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource?> SingleOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SingleOrDefault();
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.SingleOrDefault{TSource}(IEnumerable{TSource},TSource)" />
    public static async Task<TSource> SingleOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        TSource defaultValue,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SingleOrDefault(defaultValue);
    }
#endif

    /// <inheritdoc cref="Enumerable.SingleOrDefault{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<TSource?> SingleOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SingleOrDefault(predicate);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.SingleOrDefault{TSource}(IEnumerable{TSource},Func{TSource,bool},TSource)" />
    public static async Task<TSource> SingleOrDefaultAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        TSource defaultValue,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SingleOrDefault(predicate, defaultValue);
    }
#endif

    /// <inheritdoc cref="Enumerable.Skip{TSource}(IEnumerable{TSource},int)" />
    public static async Task<IEnumerable<TSource>> SkipAsync<TSource>(
        this Task<List<TSource>> source,
        int count,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Skip(count);
    }

    /// <inheritdoc cref="Enumerable.SkipWhile{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<IEnumerable<TSource>> SkipWhileAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SkipWhile(predicate);
    }

    /// <inheritdoc cref="Enumerable.SkipWhile{TSource}(IEnumerable{TSource},Func{TSource,int,bool})" />
    public static async Task<IEnumerable<TSource>> SkipWhileAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SkipWhile(predicate);
    }

#if NET6_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
    /// <inheritdoc cref="Enumerable.SkipLast{TSource}(IEnumerable{TSource},int)" />
    public static async Task<IEnumerable<TSource>> SkipLastAsync<TSource>(
        this Task<List<TSource>> source,
        int count,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).SkipLast(count);
    }
#endif

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{int})" />
    public static async Task<int> SumAsync(
        this Task<List<int>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{long})" />
    public static async Task<long> SumAsync(
        this Task<List<long>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{float})" />
    public static async Task<float> SumAsync(
        this Task<List<float>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{double})" />
    public static async Task<double> SumAsync(
        this Task<List<double>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{decimal})" />
    public static async Task<decimal> SumAsync(
        this Task<List<decimal>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{int?})" />
    public static async Task<int?> SumAsync(
        this Task<List<int?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{long?})" />
    public static async Task<long?> SumAsync(
        this Task<List<long?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{float?})" />
    public static async Task<float?> SumAsync(
        this Task<List<float?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{double?})" />
    public static async Task<double?> SumAsync(
        this Task<List<double?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum(IEnumerable{decimal?})" />
    public static async Task<decimal?> SumAsync(
        this Task<List<decimal?>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum();
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,int})" />
    public static async Task<int> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,long})" />
    public static async Task<long> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, long> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,float})" />
    public static async Task<float> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, float> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,double})" />
    public static async Task<double> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, double> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,decimal})" />
    public static async Task<decimal> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, decimal> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,int?})" />
    public static async Task<int?> SumAsync<TSource>(this Task<List<TSource>> source,
        Func<TSource, int?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,long?})" />
    public static async Task<long?> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, long?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,float?})" />
    public static async Task<float?> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, float?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,double?})" />
    public static async Task<double?> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, double?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Sum{TSource}(IEnumerable{TSource},Func{TSource,decimal?})" />
    public static async Task<decimal?> SumAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, decimal?> selector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Sum(selector);
    }

    /// <inheritdoc cref="Enumerable.Take{TSource}(IEnumerable{TSource},int)" />
    public static async Task<IEnumerable<TSource>> TakeAsync<TSource>(
        this Task<List<TSource>> source,
        int count,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Take(count);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.Take{TSource}(IEnumerable{TSource},Range)" />
    public static async Task<IEnumerable<TSource>> TakeAsync<TSource>(
        this Task<List<TSource>> source,
        Range range,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Take(range);
    }
#endif

    /// <inheritdoc cref="Enumerable.TakeWhile{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<IEnumerable<TSource>> TakeWhileAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).TakeWhile(predicate);
    }

    /// <inheritdoc cref="Enumerable.TakeWhile{TSource}(IEnumerable{TSource},Func{TSource,int,bool})" />
    public static async Task<IEnumerable<TSource>> TakeWhileAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).TakeWhile(predicate);
    }

#if NET6_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
    /// <inheritdoc cref="Enumerable.TakeLast{TSource}(IEnumerable{TSource},int)" />
    public static async Task<IEnumerable<TSource>> TakeLastAsync<TSource>(
        this Task<List<TSource>> source,
        int count,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).TakeLast(count);
    }
#endif

    /// <inheritdoc cref="Enumerable.ToArray{TSource}(IEnumerable{TSource})" />
    public static async Task<TSource[]> ToArrayAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToArray();
    }

    /// <inheritdoc cref="Enumerable.ToList{TSource}(IEnumerable{TSource})" />
    public static async Task<List<TSource>> ToListAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToList();
    }

#if NET8_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.ToDictionary{TKey,TValue}(IEnumerable{KeyValuePair{TKey,TValue}})" />
    public static async Task<Dictionary<TKey, TValue>> ToDictionaryAsync<TKey, TValue>(
        this Task<List<KeyValuePair<TKey, TValue>>> source,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToDictionary();
    }

    /// <inheritdoc cref="Enumerable.ToDictionary{TKey,TValue}(IEnumerable{KeyValuePair{TKey,TValue}},IEqualityComparer{TKey}?)" />
    public static async Task<Dictionary<TKey, TValue>> ToDictionaryAsync<TKey, TValue>(
        this Task<List<KeyValuePair<TKey, TValue>>> source,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToDictionary(comparer);
    }

    /// <inheritdoc cref="Enumerable.ToDictionary{TKey,TValue}(IEnumerable{ValueTuple{TKey,TValue}})" />
    public static async Task<Dictionary<TKey, TValue>> ToDictionaryAsync<TKey, TValue>(
        this Task<List<(TKey Key, TValue Value)>> source,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToDictionary();
    }

    /// <inheritdoc cref="Enumerable.ToDictionary{TKey,TValue}(IEnumerable{ValueTuple{TKey,TValue}},IEqualityComparer{TKey}?)" />
    public static async Task<Dictionary<TKey, TValue>> ToDictionaryAsync<TKey, TValue>(
        this Task<List<(TKey Key, TValue Value)>> source,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToDictionary(comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.ToDictionary{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToDictionary(keySelector);
    }

    /// <inheritdoc cref="Enumerable.ToDictionary{TSource,TKey}(IEnumerable{TSource},Func{TSource,TKey},IEqualityComparer{TKey})" />
    public static async Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToDictionary(keySelector, comparer);
    }

    /// <inheritdoc cref="Enumerable.ToDictionary{TSource,TKey,TElement}(IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement})" />
    public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToDictionary(keySelector, elementSelector);
    }

    /// <inheritdoc cref="Enumerable.ToDictionary{TSource,TKey,TElement}(IEnumerable{TSource},Func{TSource,TKey},Func{TSource,TElement},IEqualityComparer{TKey})" />
    public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
        this Task<List<TSource>> source,
        Func<TSource, TKey> keySelector,
        Func<TSource, TElement> elementSelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
        where TKey : notnull
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToDictionary(keySelector, elementSelector, comparer);
    }

#if NET6_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
    /// <inheritdoc cref="Enumerable.ToHashSet{TSource}(IEnumerable{TSource})" />
    public static async Task<HashSet<TSource>> ToHashSetAsync<TSource>(
        this Task<List<TSource>> source,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToHashSet();
    }

    /// <inheritdoc cref="Enumerable.ToHashSet{TSource}(IEnumerable{TSource},IEqualityComparer{TSource})" />
    public static async Task<HashSet<TSource>> ToHashSetAsync<TSource>(
        this Task<List<TSource>> source,
        IEqualityComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).ToHashSet(comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.Union{TSource}(IEnumerable{TSource},IEnumerable{TSource})" />
    public static async Task<IEnumerable<TSource>> UnionAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Union(second);
    }

    /// <inheritdoc cref="Enumerable.Union{TSource}(IEnumerable{TSource},IEnumerable{TSource},IEqualityComparer{TSource})" />
    public static async Task<IEnumerable<TSource>> UnionAsync<TSource>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        IEqualityComparer<TSource>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Union(second, comparer);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.UnionBy{TSource,TKey}(IEnumerable{TSource},IEnumerable{TSource},Func{TSource,TKey})" />
    public static async Task<IEnumerable<TSource>> UnionByAsync<TSource, TKey>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        Func<TSource, TKey> keySelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).UnionBy(second, keySelector);
    }

    /// <inheritdoc cref="Enumerable.UnionBy{TSource,TKey}(IEnumerable{TSource},IEnumerable{TSource},Func{TSource,TKey},IEqualityComparer{TKey})" />
    public static async Task<IEnumerable<TSource>> UnionByAsync<TSource, TKey>(
        this Task<List<TSource>> first,
        IEnumerable<TSource> second,
        Func<TSource, TKey> keySelector,
        IEqualityComparer<TKey>? comparer,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).UnionBy(second, keySelector, comparer);
    }
#endif

    /// <inheritdoc cref="Enumerable.Where{TSource}(IEnumerable{TSource},Func{TSource,bool})" />
    public static async Task<IEnumerable<TSource>> WhereAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Where(predicate);
    }

    /// <inheritdoc cref="Enumerable.Where{TSource}(IEnumerable{TSource},Func{TSource,int,bool})" />
    public static async Task<IEnumerable<TSource>> WhereAsync<TSource>(
        this Task<List<TSource>> source,
        Func<TSource, int, bool> predicate,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await source.ConfigureAwait(false)).Where(predicate);
    }

    /// <inheritdoc cref="Enumerable.Zip{TFirst,TSecond,TResult}(IEnumerable{TFirst},IEnumerable{TSecond},Func{TFirst,TSecond,TResult})" />
    public static async Task<IEnumerable<TResult>> ZipAsync<TFirst, TSecond, TResult>(
        this Task<List<TFirst>> first,
        IEnumerable<TSecond> second,
        Func<TFirst, TSecond, TResult> resultSelector,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Zip(second, resultSelector);
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc cref="Enumerable.Zip{TFirst,TSecond}(IEnumerable{TFirst},IEnumerable{TSecond})" />
    public static async Task<IEnumerable<(TFirst First, TSecond Second)>> ZipAsync<TFirst, TSecond>(
        this Task<List<TFirst>> first,
        IEnumerable<TSecond> second,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Zip(second);
    }

    /// <inheritdoc cref="Enumerable.Zip{TFirst,TSecond,TThird}(IEnumerable{TFirst},IEnumerable{TSecond},IEnumerable{TThird})" />
    public static async Task<IEnumerable<(TFirst First, TSecond Second, TThird Third)>> ZipAsync<TFirst, TSecond, TThird>(
        this Task<List<TFirst>> first,
        IEnumerable<TSecond> second,
        IEnumerable<TThird> third,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return (await first).Zip(second, third);
    }
#endif
}
