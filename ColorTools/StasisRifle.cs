using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(StasisRifle))]
    [HarmonyPatch("Awake")]

    internal class StasisRifle_Color_Patch
    {
        public static bool Prefix(StasisRifle __instance)
        {




            var tool5Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var tool05Color in tool5Color)
            {
                if (tool05Color.name.Contains("stasis_rifle_geo"))
                {
                    tool05Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}

