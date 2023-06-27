// -----------------------------------------------------------------------
// <copyright file="Color.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordHook
{
    using System;

    /// <summary>
    /// Represents a color used by discord.
    /// </summary>
    public struct Color
    {
        /// <summary>
        /// Gets the max decimal value of color.
        /// </summary>
        public const uint MaxDecimalValue = 16777215;

        /// <summary>
        /// Gets the default user color value.
        /// </summary>
        public static readonly Color Default = new(0U);

        /// <summary>
        /// Gets the teal color value.
        /// </summary>
        /// <returns>A color struct with the hex value of <see href="http://www.color-hex.com/color/1ABC9C">1ABC9C</see>.</returns>
        public static readonly Color Teal = new(1752220U);

        /// <summary>
        /// Gets the dark teal color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/11806A">11806A</see>.</returns>
        public static readonly Color DarkTeal = new(1146986U);

        /// <summary>
        /// Gets the green color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/2ECC71">2ECC71</see>.</returns>
        public static readonly Color Green = new(3066993U);

        /// <summary>
        /// Gets the dark green color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/1F8B4C">1F8B4C</see>.</returns>
        public static readonly Color DarkGreen = new(2067276U);

        /// <summary>
        /// Gets the blue color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/3498DB">3498DB</see>.</returns>
        public static readonly Color Blue = new(3447003U);

        /// <summary>
        /// Gets the dark blue color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/206694">206694</see>.</returns>
        public static readonly Color DarkBlue = new(2123412U);

        /// <summary>
        /// Gets the purple color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/9B59B6">9B59B6</see>.</returns>
        public static readonly Color Purple = new(10181046U);

        /// <summary>
        /// Gets the dark purple color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/71368A">71368A</see>.</returns>
        public static readonly Color DarkPurple = new(7419530U);

        /// <summary>
        /// Gets the magenta color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/E91E63">E91E63</see>.</returns>
        public static readonly Color Magenta = new(15277667U);

        /// <summary>
        /// Gets the dark magenta color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/AD1457">AD1457</see>.</returns>
        public static readonly Color DarkMagenta = new(11342935U);

        /// <summary>
        /// Gets the gold color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/F1C40F">F1C40F</see>.</returns>
        public static readonly Color Gold = new(15844367U);

        /// <summary>
        /// Gets the light orange color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/C27C0E">C27C0E</see>.</returns>
        public static readonly Color LightOrange = new(12745742U);

        /// <summary>
        /// Gets the orange color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/E67E22">E67E22</see>.</returns>
        public static readonly Color Orange = new(15105570U);

        /// <summary>
        /// Gets the dark orange color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/A84300">A84300</see>.</returns>
        public static readonly Color DarkOrange = new(11027200U);

        /// <summary>
        /// Gets the red color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/E74C3C">E74C3C</see>.</returns>
        public static readonly Color Red = new(15158332U);

        /// <summary>
        /// Gets the dark red color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/992D22">992D22</see>.</returns>
        public static readonly Color DarkRed = new(10038562U);

        /// <summary>
        /// Gets the light grey color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/979C9F">979C9F</see>.</returns>
        public static readonly Color LightGrey = new(9936031U);

        /// <summary>
        /// Gets the lighter grey color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/95A5A6">95A5A6</see>.</returns>
        public static readonly Color LighterGrey = new(9807270U);

        /// <summary>
        /// Gets the dark grey color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/607D8B">607D8B</see>.</returns>
        public static readonly Color DarkGrey = new(6323595U);

        /// <summary>
        /// Gets the darker grey color value.
        /// </summary>
        /// <returns> A color struct with the hex value of <see href="http://www.color-hex.com/color/546E7A">546E7A</see>.</returns>
        public static readonly Color DarkerGrey = new(5533306U);

        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> struct.
        /// </summary>
        /// <param name="value"><inheritdoc cref="Value"/></param>
        public Color(uint value) => Value = value <= MaxDecimalValue ? value : throw new ArgumentException($"Value of color cannot be greater than {MaxDecimalValue}!", nameof(value));

        /// <summary>
        /// Gets the raw value of the color.
        /// </summary>
        public uint Value { get; }

        /// <summary>
        /// Gets the red component for this color.
        /// </summary>
        public byte R => (byte)(Value >> 16);

        /// <summary>
        /// Gets the green component for this color.
        /// </summary>
        public byte G => (byte)(Value >> 8);

        /// <summary>
        /// Gets the blue component for this color.
        /// </summary>
        public byte B => (byte)Value;

        /// <summary>
        /// Implicitly converts a <see cref="uint"/> to a <see cref="Color"/>.
        /// </summary>
        /// <param name="value">The raw value of the color.</param>
        /// <returns>The color representing the provided <see cref="Value"/>.</returns>
        public static implicit operator Color(uint value) => new(value);

        /// <summary>
        /// Implicitly converts a <see cref="Color"/> to a <see cref="uint"/>.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Value"/> of the <see cref="Color"/>.</returns>
        public static implicit operator uint(Color color) => color.Value;

        /// <summary>
        /// Checks if two colors are equal.
        /// </summary>
        /// <param name="lhs">The first color.</param>
        /// <param name="rhs">The second color.</param>
        /// <returns>Whether the <see cref="Value"/> of the colors are equal.</returns>
        public static bool operator ==(Color lhs, Color rhs) => (int)lhs.Value == (int)rhs.Value;

        /// <summary>
        /// Checks if two colors are not equal.
        /// </summary>
        /// <param name="lhs">The first color.</param>
        /// <param name="rhs">The second color.</param>
        /// <returns>Whether the <see cref="Value"/> of the colors are not equal.</returns>
        public static bool operator !=(Color lhs, Color rhs) => (int)lhs.Value != (int)rhs.Value;

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Color color && (int)Value == (int)color.Value;

        /// <inheritdoc />
        public override int GetHashCode() => Value.GetHashCode();

        /// <summary>
        ///     Gets the hexadecimal representation of the color (e.g. <c>#000ccc</c>).
        /// </summary>
        /// <returns>A hexadecimal string of the color.</returns>
        public override string ToString() => $"#{Value:X6}";
    }
}