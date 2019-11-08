using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Datalayer.Context;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;
using Document = Datalayer.Entities.Document;

namespace Businesslayer.Services
{
    public interface IDocumentService
    {
        Task<DocumentModel> Get(int id);
        Task<List<DocumentModel>> Get();
        Task<DocumentModel> Create(DocumentModel model);
        Task<DocumentModel> Update(DocumentModel model, int id);
        Task Delete(int id);
    }

    public class DocumentService : ServiceBase, IDocumentService
    {
        public DocumentService(IMapper mapper, VerifieerContext context) : base(mapper, context)
        {
        }

        public async Task<DocumentModel> Get(int id)
        {
            var doc = await Context.Documents.SingleOrDefaultAsync(d => d.Id == id);
            return Mapper.Map<DocumentModel>(doc);
        }

        public async Task<List<DocumentModel>> Get()
        {
            var docs = await Context.Documents.ToListAsync();
            return docs.Select(d => Mapper.Map<DocumentModel>(d)).ToList();
        }

        public async Task<DocumentModel> Create(DocumentModel model)
        {
            var doc = Mapper.Map<Document>(model);

            await Context.Documents.AddAsync(doc);
            await Context.SaveChangesAsync();

            return Mapper.Map<DocumentModel>(doc); ;
        }

        public async Task<DocumentModel> Update(DocumentModel model, int id)
        {
            var doc = await Context.Documents.SingleOrDefaultAsync(d => d.Id == id);

            if (doc == null)
                return null;

            Mapper.Map(model, doc);
            Context.Documents.Update(doc);
            await Context.SaveChangesAsync();

            return await Get(id);
        }

        public async Task Delete(int id)
        {
            var result = await Context.Documents.SingleOrDefaultAsync(d => d.Id == id);

            if (result == null)
                return;

            Context.Documents.Remove(result);
            await Context.SaveChangesAsync();
        }


    }
}
