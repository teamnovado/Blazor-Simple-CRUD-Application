using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entities
{
    public class Document : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string File { get; set; }
    }
}
