namespace PokeApi.V2.Tests;

public class EnumerateApiResourcesRangeTests(PokeApiClientFixture fixture)
{
    public static TheoryData<Range> RangeTestData => new(
    [
        0..50,
        1300..,
        100..150,
        ^50..
    ]);
    [Theory]
    [MemberData(nameof(RangeTestData))]
    public async Task EnumerateApiResourcesSucceedsWithRange(Range range)
    {
        var cancellationToken = TestContext.Current.CancellationToken;
        var p = await fixture.Client.GetApiResourcePageAsync<Pokemon>(0, 1, cancellationToken);
        var count = p.Count;
        var (offset, length) = range.GetOffsetAndLength(count);
        var page = await fixture.Client.GetApiResourcePageAsync<Pokemon>(offset, length, cancellationToken);
        var expected = page.Results;
        Assert.Equal(expected, fixture.Client.EnumerateApiResourcesAsync<Pokemon>(range, cancellationToken: cancellationToken));
    }
}