using System;
using BepInEx;

namespace CleansingBlock
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin("org.bepinex.plugins.CleansingBlock", "Cleansing Block Plug-In", "1.0.0.0")]
    [BepInProcess("Rounds.exe")]
    public class CleansingBlock : BaseUnityPlugin
    {
        void Awake()
        {
            UnityEngine.Debug.Log("Hello, world!");
        }
    }
}
