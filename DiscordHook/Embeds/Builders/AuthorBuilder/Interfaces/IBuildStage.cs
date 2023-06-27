// -----------------------------------------------------------------------
// <copyright file="IBuildStage.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds.Builders.AuthorBuilder.Interfaces
{
    using Author = DiscordHook.Embeds.Author;

    public interface IBuildStage
    {
        public Author Build();
    }
}