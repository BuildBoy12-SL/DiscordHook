// -----------------------------------------------------------------------
// <copyright file="ITimestampSelection.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds.Builders.EmbedBuilder.Interfaces
{
    using System;

    public interface ITimestampSelection
    {
        public IFooterSelection WithTimestamp(DateTimeOffset timestamp);
    }
}