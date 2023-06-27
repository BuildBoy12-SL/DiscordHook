// -----------------------------------------------------------------------
// <copyright file="IInlineSelection.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds.Builders.FieldBuilder.Interfaces
{
    public interface IInlineSelection
    {
        public IBuildStage IsInline(bool isInline);
    }
}