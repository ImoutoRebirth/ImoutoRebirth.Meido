﻿using System;
using System.Threading.Tasks;

namespace ImoutoRebirth.Meido.Core.ParsingStatus
{
    public interface IParsingService
    {
        Task CreateParsingStatusesForNewFile(Guid fileId, string md5);

        Task SaveSearchResult(
            int sourceId,
            Guid fileId,
            SearchStatus resultStatus,
            int? fileIdFromSource,
            string errorText);

        Task MarkAsSaved(Guid fileId, int sourceId);
    }
}