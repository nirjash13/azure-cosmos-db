using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmosDbInvestigation.Structures;

namespace DocumentDbInvestigation.Interfaces
{
  public interface IRepository<TDocument>
    where TDocument : DocumentBase
  {
    Task<IQueryable<TDocument>> Read(Guid tenantId);

    Task Create(TDocument item);

    Task Create(IEnumerable<TDocument> documents);

    Task Update(DocumentBase<TDocument> item);

    Task Update(IEnumerable<DocumentBase<TDocument>> items);

    Task Upsert(DocumentBase<TDocument> item);

    Task Upsert(IEnumerable<DocumentBase<TDocument>> items);
  }
}
