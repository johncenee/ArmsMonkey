using MelonLoader;
using BTD_Mod_Helper;
using ArmsMonkey;

[assembly: MelonInfo(typeof(ArmsMonkey.ArmsMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace ArmsMonkey;

public class ArmsMonkey : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<ArmsMonkey>("ArmsMonkey locked and loaded");
    }
}