using Xunit;

namespace TaskLinq.Tests;

public class TaskEnumerableTests
{
    [Fact]
    public async Task CanOperateOnEnumerable()
    {
        var result = await GetEnumerableAsync()
            .OrderByAsync(x => x)
            .SelectAsync(x => x)
            .ToArrayAsync();

        Assert.NotEmpty(result);
    }

    [Fact]
    public async Task CanOperateOnArray()
    {
        var result = await GetArrayAsync()
            .OrderByAsync(x => x)
            .SelectAsync(x => x)
            .ToArrayAsync();

        Assert.NotEmpty(result);
    }

    [Fact]
    public async Task CanOperateOnList()
    {
        var result = await GetListAsync()
            .OrderByAsync(x => x)
            .SelectAsync(x => x)
            .ToArrayAsync();

        Assert.NotEmpty(result);
    }

    private Task<IEnumerable<int>> GetEnumerableAsync()
    {
        return Task.FromResult<IEnumerable<int>>(new[] { 1, 2 });
    }

    private Task<List<int>> GetListAsync()
    {
        return Task.FromResult<List<int>>(new List<int> { 1, 2 });
    }

    private Task<int[]> GetArrayAsync()
    {
        return Task.FromResult<int[]>(new[] { 1, 2 });
    }
}
