using StardewModdingAPI;
using StardewModdingAPI.Utilities;
using System;

namespace HomeSweetHomeSpouseDialogues
{
    /// <summary>Minimal API surface used when Generic Mod Config Menu is installed.</summary>
    internal interface IGenericModConfigMenuApi
    {
        void Register(IManifest mod, Action reset, Action save, bool titleScreenOnly = false);

        void AddKeybindList(
            IManifest mod,
            Func<KeybindList> getValue,
            Action<KeybindList> setValue,
            Func<string> name,
            Func<string> tooltip = null,
            string fieldId = null);
    }
}
