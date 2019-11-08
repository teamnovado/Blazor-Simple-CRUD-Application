using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using AutoMapper;
using SharedLibrary.Models;
using Document = Datalayer.Entities.Document;

namespace Businesslayer.Mapper
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<Document, DocumentModel>();
            CreateMap<DocumentModel, Document>();
        }
    }
}
