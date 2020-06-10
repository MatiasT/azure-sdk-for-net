// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class SkuAutoGenerated : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Tier != null)
            {
                writer.WritePropertyName("tier");
                writer.WriteStringValue(Tier);
            }
            if (Size != null)
            {
                writer.WritePropertyName("size");
                writer.WriteStringValue(Size);
            }
            if (Family != null)
            {
                writer.WritePropertyName("family");
                writer.WriteStringValue(Family);
            }
            if (Model != null)
            {
                writer.WritePropertyName("model");
                writer.WriteStringValue(Model);
            }
            if (Capacity != null)
            {
                writer.WritePropertyName("capacity");
                writer.WriteNumberValue(Capacity.Value);
            }
            writer.WriteEndObject();
        }

        internal static SkuAutoGenerated DeserializeSkuAutoGenerated(JsonElement element)
        {
            string name = default;
            string tier = default;
            string size = default;
            string family = default;
            string model = default;
            int? capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
            }
            return new SkuAutoGenerated(name, tier, size, family, model, capacity);
        }
    }
}