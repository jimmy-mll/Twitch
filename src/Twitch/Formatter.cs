namespace Twitch;

/// <summary>
/// Provides methods to format text with various styles and effects.
/// </summary>
public static class Formatter
{
    /// <summary>
    /// Formats the text in bold.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    public static string Bold(string text) => $"**{text}**";

    /// <summary>
    /// Formats the text in italic.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    public static string Italic(string text) => $"*{text}*";

    /// <summary>
    /// Formats the text with a strikethrough.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    public static string Strikethrough(string text) => $"~~{text}~~";

    /// <summary>
    /// Formats the text with an underline.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    public static string Underline(string text) => $"__{text}__";

    /// <summary>
    /// Formats the text with a specified color.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="color">The color to apply.</param>
    /// <returns>The formatted text.</returns>
    public static string Color(string text, Color color) => $"{{color={color.ToString().ToLower()}}}{text}{{/color}}";

    /// <summary>
    /// Formats the text with a specified size.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="size">The size to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the size is less than 8 or greater than 96.</exception>
    public static string Size(string text, int size)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(size, 8);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(size, 96);

        return $"{{size={size}}}{text}{{/size}}";
    }

    /// <summary>
    /// Formats the text with a specified font.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="font">The font to apply.</param>
    /// <returns>The formatted text.</returns>
    public static string Font(string text, Font font) => $"{{font={font}}}{text}{{/font}}";

    /// <summary>
    /// Formats the text with a specified alignment.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="alignment">The alignment to apply.</param>
    /// <returns>The formatted text.</returns>
    public static string Align(string text, Alignment alignment) => $"{{align={alignment.ToString().ToLower()}}}{text}{{/align}}";

    /// <summary>
    /// Formats the text with a blink effect.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    public static string Blink(string text) => $"{{blink}}{text}{{/blink}}";

    /// <summary>
    /// Formats the text with a dynamic underline.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    public static string UnderlineDynamic(string text) => $"{{underline}}{text}{{/underline}}";

    /// <summary>
    /// Formats the text with a marquee effect.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <returns>The formatted text.</returns>
    public static string Marquee(string text) => $"{{marquee}}{text}{{/marquee}}";

    /// <summary>
    /// Formats the text with a specified opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string Opacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{opacity={opacity}}}{text}{{/opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified rotation angle.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="angle">The rotation angle to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the angle is less than 0 or greater than 360.</exception>
    public static string Rotate(string text, int angle)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(angle, 0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(angle, 360);

        return $"{{rotate={angle}}}{text}{{/rotate}}";
    }

    /// <summary>
    /// Formats the text with a specified scale factor.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="factor">The scale factor to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the factor is less than 0.5 or greater than 3.0.</exception>
    public static string Scale(string text, double factor)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(factor, 0.5);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(factor, 3.0);

        return $"{{scale={factor}}}{text}{{/scale}}";
    }

    /// <summary>
    /// Formats the text with a specified offset.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="x">The horizontal offset.</param>
    /// <param name="y">The vertical offset.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the x or y offset is less than -100 or greater than 100.</exception>
    public static string Offset(string text, int x, int y)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(x, -100);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(x, 100);

        ArgumentOutOfRangeException.ThrowIfLessThan(y, -100);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(y, 100);

        return $"{{offset={x},{y}}}{text}{{/offset}}";
    }

    /// <summary>
    /// Formats the text with a border.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="border">The border style to apply.</param>
    /// <param name="color">The border color to apply.</param>
    /// <param name="width">The border width to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the width is less than 1 or greater than 5.</exception>
    public static string Border(string text, Border border, Color color, int width)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(width, 1);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(width, 5);

        return $"{{border={border.ToString().ToLower()},{color.ToString().ToLower()},{width}}}{text}{{/border}}";
    }

    /// <summary>
    /// Formats the text with a background color.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="color">The background color to apply.</param>
    /// <returns>The formatted text.</returns>
    public static string Background(string text, Color color) => $"{{background={color.ToString().ToLower()}}}{text}{{/background}}";

    /// <summary>
    /// Formats the text with a shadow effect.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="x">The horizontal shadow offset.</param>
    /// <param name="y">The vertical shadow offset.</param>
    /// <param name="blur">The shadow blur radius.</param>
    /// <param name="color">The shadow color to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the x or y offset is less than -10 or greater than 10, or when the blur is less than 0 or greater than 20.</exception>
    public static string Shadow(string text, int x, int y, int blur, Color color)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(x, -10);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(x, 10);

        ArgumentOutOfRangeException.ThrowIfLessThan(y, -10);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(y, 10);

        ArgumentOutOfRangeException.ThrowIfLessThan(blur, 0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(blur, 20);

        return $"{{shadow={x},{y},{blur},{color.ToString().ToLower()}}}{text}{{/shadow}}";
    }

    /// <summary>
    /// Formats the text with a specified background opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The background opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string BackgroundOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{background-opacity={opacity}}}{text}{{/background-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified border opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The border opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string BorderOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{border-opacity={opacity}}}{text}{{/border-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified shadow opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The shadow opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string ShadowOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{shadow-opacity={opacity}}}{text}{{/shadow-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified text opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The text opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string TextOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{text-opacity={opacity}}}{text}{{/text-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified background text opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The background text opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string BackgroundTextOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{background-text-opacity={opacity}}}{text}{{/background-text-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified border text opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The border text opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string BorderTextOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{border-text-opacity={opacity}}}{text}{{/border-text-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified shadow text opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The shadow text opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string ShadowTextOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{shadow-text-opacity={opacity}}}{text}{{/shadow-text-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified background, border, and text opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string BackgroundBorderTextOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{background-border-text-opacity={opacity}}}{text}{{/background-border-text-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified background, shadow, and text opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string BackgroundShadowTextOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{background-shadow-text-opacity={opacity}}}{text}{{/background-shadow-text-opacity}}";
    }

    /// <summary>
    /// Formats the text with a specified background, border, and shadow opacity.
    /// </summary>
    /// <param name="text">The text to format.</param>
    /// <param name="opacity">The opacity to apply.</param>
    /// <returns>The formatted text.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the opacity is less than 0.0 or greater than 1.0.</exception>
    public static string BackgroundBorderShadowTextOpacity(string text, double opacity)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(opacity, 0.0);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(opacity, 1.0);

        return $"{{background-border-shadow-text-opacity={opacity}}}{text}{{/background-border-shadow-text-opacity}}";
    }
}
