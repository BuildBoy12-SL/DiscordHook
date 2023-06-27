// -----------------------------------------------------------------------
// <copyright file="FieldBuilder.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook.Embeds.Builders.FieldBuilder
{
    using DiscordHook.Embeds.Builders.FieldBuilder.Interfaces;

    /// <summary>
    /// Fluently creates a <see cref="Field"/>.
    /// </summary>
    public class FieldBuilder : INameSelection, IValueSelection, IInlineSelection, IBuildStage
    {
        private string _name;
        private string _value;
        private bool _isInline;

        private FieldBuilder()
        {
        }

        /// <summary>
        /// Creates a new <see cref="FieldBuilder"/>.
        /// </summary>
        /// <returns>The new builder.</returns>
        public static INameSelection Create()
        {
            return new FieldBuilder();
        }

        /// <inheritdoc />
        public IValueSelection WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <inheritdoc />
        public IInlineSelection WithValue(string value)
        {
            _value = value;
            return this;
        }

        /// <inheritdoc />
        public IBuildStage IsInline(bool isInline)
        {
            _isInline = isInline;
            return this;
        }

        /// <inheritdoc />
        public Field Build()
        {
            Field field = new Field
            {
                Name = _name,
                Value = _value,
                Inline = _isInline,
            };

            return field;
        }
    }
}