using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;

namespace SmartBuilding.Utilities
{
    public class DrawingUtils
    {
        public DrawingUtils() { }

        /// <summary>
        /// Draw a string using the specified SpriteFont twice. One first and offset by two pixels (the shadow), and the second in precisely the specified position.
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch doing the drawing.</param>
        /// <param name="font">The SpriteFont to use.</param>
        /// <param name="text">The text to draw.</param>
        /// <param name="position">The position for the base text (not the shadow).</param>
        /// <param name="textColour">The <see cref="Color"/> of the text.</param>
        /// <param name="shadowColour">The <see cref="Color"/> of the shadow.</param>
        public void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color textColour, Color shadowColour, int xOffset = 2, int yOffset = 2)
        {
            // Draw the shadow...
            spriteBatch.DrawString(
                spriteFont: font,
                text: text,
                position: position + new Vector2(xOffset, yOffset),
                shadowColour
            );

            // ...and draw the text itself.
            spriteBatch.DrawString(
                spriteFont: font,
                text: text,
                position: position,
                textColour
            );
        }

    }
}