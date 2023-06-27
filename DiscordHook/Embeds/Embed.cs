// -----------------------------------------------------------------------
// <copyright file="Embed.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds
{
    using System;

    /// <summary>
    /// Represents an embed for a discord webhook.
    /// </summary>
    public class Embed
    {
        /// <summary>
        /// Gets or sets the author of the embed.
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// Gets or sets the title of the embed.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the title's embedded url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the content of the embed.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the color of the embed.
        /// </summary>
        public uint Color { get; set; }

        /// <summary>
        /// Gets or sets the fields of an embed.
        /// </summary>
        public Field[] Fields { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of an embed.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the footer of the embed.
        /// </summary>
        public string Footer { get; set; }
    }
}