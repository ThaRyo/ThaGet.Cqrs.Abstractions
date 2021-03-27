namespace ThaGet.Cqrs.Filter.Abstractions
{
    public interface IFilterInfo
    {
        string Operator { get; set; }
        string Property { get; set; }
        string Value { get; set; }
    }
}