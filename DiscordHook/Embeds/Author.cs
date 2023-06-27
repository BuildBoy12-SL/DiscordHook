// -----------------------------------------------------------------------
// <copyright file="Author.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds
{
    /// <summary>
    /// Represents an author for an embed.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Gets or sets the name of the author.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the author's embedded url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the url of the author's icon.
        /// </summary>
        public string IconUrl { get; set; }
    }
}