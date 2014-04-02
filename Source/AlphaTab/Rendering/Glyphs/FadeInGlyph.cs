﻿using AlphaTab.Platform;

namespace AlphaTab.Rendering.Glyphs
{
    public class FadeInGlyph : Glyph
    {
        public FadeInGlyph(int x = 0, int y = 0)
            : base(x, y)
        {
        }

        public override void Paint(int cx, int cy, ICanvas canvas)
        {
            var size = (int)(6 * Scale);

            canvas.BeginPath();
            canvas.MoveTo(cx + X, cy + Y);
            canvas.QuadraticCurveTo(cx + X + (Width / 2), cy + Y, cx + X + Width, cy + Y - size);
            canvas.MoveTo(cx + X, cy + Y);
            canvas.QuadraticCurveTo(cx + X + (Width / 2), cy + Y, cx + X + Width, cy + Y + size);
            canvas.Stroke();
        }
    }
}