using System.Collections.Generic;

namespace ThaGet.Cqrs.Contract.Abstractions
{
    public interface IPagination<T>
    {
        IEnumerable<T> Items { get; set; }

        int TotalCount { get; set; }
    }
}
