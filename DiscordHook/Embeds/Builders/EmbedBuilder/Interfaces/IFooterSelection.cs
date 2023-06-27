// -----------------------------------------------------------------------
// <copyright file="IFooterSelection.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds.Builders.EmbedBuilder.Interfaces
{
    public interface IFooterSelection
    {
        public IBuildStage WithFooter(string footer);
    }
}