using System;

namespace PostgreSqlNetCore.Domain.Entities
{
    public class Category
    {
        public Category(Guid id, 
                        string description)
        {
            Id = id;
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Description { get; private set; }
    }
}