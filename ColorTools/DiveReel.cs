using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(DiveReel))]
    [HarmonyPatch("Update")]

    internal class divereel_Color_Patch
    {
        public static bool Prefix(DiveReel __instance)
        {




            var tool5Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var tool05Color in tool5Color)
            {
                if (tool05Color.name.Contains("dive_reel_geo"))
                {
                    tool05Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}

