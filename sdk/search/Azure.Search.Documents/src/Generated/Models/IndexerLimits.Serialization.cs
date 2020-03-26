// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class IndexerLimits
    {
        internal static IndexerLimits DeserializeIndexerLimits(JsonElement element)
        {
            TimeSpan? maxRunTime = default;
            long? maxDocumentExtractionSize = default;
            long? maxDocumentContentCharactersToExtract = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxRunTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRunTime = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("maxDocumentExtractionSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDocumentExtractionSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxDocumentContentCharactersToExtract"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDocumentContentCharactersToExtract = property.Value.GetInt64();
                    continue;
                }
            }
            return new IndexerLimits(maxRunTime, maxDocumentExtractionSize, maxDocumentContentCharactersToExtract);
        }
    }
}