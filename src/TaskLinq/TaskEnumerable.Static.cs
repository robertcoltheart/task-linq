namespace System.Linq;

public static partial class TaskEnumerable
{
    /// <inheritdoc cref="Enumerable.Empty{TResult}" />
    public static Task<IEnumerable<TResult>> Empty<TResult>()
    {
        return Task.FromResult(Enumerable.Empty<TResult>());
    }

    /// <inheritdoc cref="Enumerable.Range(int,int)" />
    public static Task<IEnumerable<int>> RangeAsync(
        int start,
        int count,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(Enumerable.Range(start, count));
    }

    /// <inheritdoc cref="Enumerable.Repeat{TResult}(TResult,int)" />
    public static Task<IEnumerable<TResult>> RepeatAsync<TResult>(
        TResult element,
        int count,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(Enumerable.Repeat(element, count));
    }
}
