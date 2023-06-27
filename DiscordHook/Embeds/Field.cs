// -----------------------------------------------------------------------
// <copyright file="Field.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds
{
    /// <summary>
    /// Represents a field of an embed.
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Gets or sets the title of the field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the content of the field.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this field should be able to share lines with other fields.
        /// </summary>
        public bool Inline { get; set; }
    }
}