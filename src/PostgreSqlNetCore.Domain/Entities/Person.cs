using System;

namespace PostgreSqlNetCore.Domain.Entities
{
    public class Person
    {
        public Person(Guid id, 
                      string name,
                      Guid categoryId)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Guid CategoryId { get; private set; }
    }
}