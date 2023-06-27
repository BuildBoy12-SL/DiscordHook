// -----------------------------------------------------------------------
// <copyright file="EmbedBuilder.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds.Builders.EmbedBuilder
{
    using System;
    using DiscordHook.Embeds.Builders.EmbedBuilder.Interfaces;

    /// <summary>
    /// Fluently builds an embed.
    /// </summary>
    public class EmbedBuilder : IAuthorSelection, ITitleSelection, IUrlSelection, IDescriptionSelection, IColorSelection, IFieldSelection, ITimestampSelection, IFooterSelection, IBuildStage
    {
        private Author _author;
        private string _title;
        private string _url;
        private string _description;
        private Color _color;
        private Field[] _fields;
        private DateTimeOffset _timestamp;
        private string _footer;

        private EmbedBuilder()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuthorBuilder"/>.
        /// </summary>
        /// <returns>The new builder.</returns>
        public static IAuthorSelection Create()
        {
            return new EmbedBuilder();
        }

        /// <inheritdoc />
        public ITitleSelection WithAuthor(Author author)
        {
            _author = author;
            return this;
        }

        /// <inheritdoc />
        public IUrlSelection WithTitle(string title)
        {
            _title = title;
            return this;
        }

        /// <inheritdoc />
        public IDescriptionSelection WithUrl(string url)
        {
            _url = url;
            return this;
        }

        /// <inheritdoc />
        public IColorSelection WithDescription(string description)
        {
            _description = description;
            return this;
        }

        /// <inheritdoc />
        public IFieldSelection WithColor(Color color)
        {
            _color = color;
            return this;
        }

        /// <inheritdoc />
        public ITimestampSelection WithFields(params Field[] fields)
        {
            _fields = fields;
            return this;
        }

        /// <inheritdoc />
        public IFooterSelection WithTimestamp(DateTimeOffset timestamp)
        {
            _timestamp = timestamp;
            return this;
        }

        /// <inheritdoc />
        public IBuildStage WithFooter(string footer)
        {
            _footer = footer;
            return this;
        }

        /// <inheritdoc />
        public Embed Build()
        {
            Embed embed = new Embed
            {
                Author = _author,
                Title = _title,
                Url = _url,
                Description = _description,
                Color = _color,
                Fields = _fields,
                Timestamp = _timestamp,
                Footer = _footer,
            };

            return embed;
        }
    }
}