// -----------------------------------------------------------------------
// <copyright file="ITitleSelection.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds.Builders.EmbedBuilder.Interfaces
{
    public interface ITitleSelection
    {
        public IUrlSelection WithTitle(string title);
    }
}