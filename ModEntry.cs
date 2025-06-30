/// ModEntry.cs -> StardewX Entrypoint for Stardew Valley 1.6
/// 
/// Due to the sheer size of this mod, not every single piece of this mods
/// code and logic are in the one file. This would make this file several
/// dozen megabytes and tens of thousands of lines long, something we
/// absolutely do not want to deal with at all.


// Disables "Using directive is unnecessary" warning.
#pragma warning disable IDE0005
// Disables "functionname(args) is unused" warning.
#pragma warning disable IDE0051

using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace StardewX
{
    internal sealed class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {

        }

        private static void DummyFunc()
        {

        }
    }
}