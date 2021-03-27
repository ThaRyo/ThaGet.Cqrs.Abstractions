using System;

namespace ThaGet.Cqrs.Domain.Entities.Abstractions
{
    public interface IEntity<TId>
        where TId : struct
    {
        TId Id { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
