// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MediaLiveEventEncoderConnectedEventData
    {
        internal static MediaLiveEventEncoderConnectedEventData DeserializeMediaLiveEventEncoderConnectedEventData(JsonElement element)
        {
            Optional<string> ingestUrl = default;
            Optional<string> streamId = default;
            Optional<string> encoderIp = default;
            Optional<string> encoderPort = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestUrl"))
                {
                    ingestUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamId"))
                {
                    streamId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderIp"))
                {
                    encoderIp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderPort"))
                {
                    encoderPort = property.Value.GetString();
                    continue;
                }
            }
            return new MediaLiveEventEncoderConnectedEventData(ingestUrl.Value, streamId.Value, encoderIp.Value, encoderPort.Value);
        }
    }
}
