namespace ThaGet.Cqrs.Domain.Entities.Abstractions
{
    public interface IVersionedEntity<TRowVersion>
    {
        public TRowVersion RowVersion { get; set; }
    }
}
