// -----------------------------------------------------------------------
// <copyright file="AuthorBuilder.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds.Builders.AuthorBuilder
{
    using DiscordHook.Embeds.Builders.AuthorBuilder.Interfaces;

    /// <summary>
    /// Fluently builds an author.
    /// </summary>
    public class AuthorBuilder : INameSelection, IIconUrlSelection, IUrlSelection, IBuildStage
    {
        private string _name;
        private string _url;
        private string _iconUrl;

        private AuthorBuilder()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuthorBuilder"/>.
        /// </summary>
        /// <returns>The new builder.</returns>
        public static INameSelection Create()
        {
            return new AuthorBuilder();
        }

        /// <inheritdoc />
        public IIconUrlSelection WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <inheritdoc />
        public IUrlSelection WithIconUrl(string iconUrl)
        {
            _iconUrl = iconUrl;
            return this;
        }

        /// <inheritdoc />
        public IBuildStage WithUrl(string url)
        {
            _url = url;
            return this;
        }

        /// <inheritdoc />
        public Author Build()
        {
            Author author = new Author
            {
                Name = _name,
                IconUrl = _iconUrl,
                Url = _url,
            };

            return author;
        }
    }
}