﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TerrainFeatureRefresh.Framework.Ui;

public class AllLocationsCheckbox : Checkbox
{
    private TfrToggle toggle;

    public AllLocationsCheckbox(Rectangle bounds, string name, Texture2D texture, SpriteFont font, ref TfrToggle toggle) : base(bounds, name, texture, font)
    {
        this.toggle = toggle;
    }

    public override void ReceiveLeftClick()
    {
        base.ReceiveLeftClick();

        this.toggle.On = this.isChecked;
    }
}
