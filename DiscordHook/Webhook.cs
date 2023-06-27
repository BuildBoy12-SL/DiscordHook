// -----------------------------------------------------------------------
// <copyright file="Webhook.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook
{
    using System;
    using System.Collections.Generic;
    using DiscordHook.Embeds;
    using Exiled.API.Features;
    using MEC;
    using UnityEngine.Networking;
    using Utf8Json;
    using Utf8Json.Resolvers.Internal;

    /// <summary>
    /// Represents a webhook to be sent to discord.
    /// </summary>
    [Serializable]
    public class Webhook
    {
        /// <summary>
        /// Gets or sets the username of the webhook.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the url of the webhook's avatar.
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Gets or sets the text message to send.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets a list of embeds to send.
        /// </summary>
        public List<Embed> Embeds { get; set; } = new();

        /// <summary>
        /// Adds an embed to the <see cref="Embeds"/> and returns the current webhook.
        /// </summary>
        /// <param name="embed">The embed to add.</param>
        /// <returns>The current webhook.</returns>
        public Webhook WithEmbed(Embed embed)
        {
            Embeds.Add(embed);
            return this;
        }

        /// <summary>
        /// Sends the webhook to the provided webhook url.
        /// </summary>
        /// <param name="url">The url of the webhook.</param>
        public void Send(string url) => Timing.RunCoroutine(SendCoroutine(url));

        private IEnumerator<float> SendCoroutine(string url)
        {
            UnityWebRequest webRequest = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST);
            webRequest.uploadHandler = new UploadHandlerRaw(ToJson())
            {
                contentType = "application/json",
            };

            yield return Timing.WaitUntilDone(webRequest.SendWebRequest());

            if (webRequest.result
                is UnityWebRequest.Result.ConnectionError
                or UnityWebRequest.Result.ProtocolError
                or UnityWebRequest.Result.DataProcessingError)
                Log.Error($"Error while sending the webhook: {webRequest.error}");
        }

        private byte[] ToJson() => JsonSerializer.Serialize(this, new ExcludeNullSnakeCaseStandardResolver());

        private string ToJsonString() => JsonSerializer.ToJsonString(this, new ExcludeNullSnakeCaseStandardResolver());
    }
}