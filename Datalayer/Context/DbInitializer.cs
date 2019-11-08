using System;
using System.Collections.Generic;
using System.Text;
using Bogus;
using Datalayer.Entities;

namespace Datalayer.Context
{
    public static class DbInitializer
    {
        public static void Seed(VerifieerContext context)
        {
            var fakeDocuments = new Faker<Document>()
                .RuleFor(d => d.Title, f => "GAS - " + f.Person.FullName)
                .RuleFor(d => d.Description, f => f.Lorem.Sentence(20));

            var documents = fakeDocuments.Generate(10);
            context.Documents.AddRange(documents);
            context.SaveChanges();
        }
    }
}