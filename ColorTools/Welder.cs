using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(Welder))]
    [HarmonyPatch("Update")]

    internal class welder_Color_Patch
    {
        public static bool Prefix(Welder __instance)
        {




            var tool4Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var tool04Color in tool4Color)
            {
                if (tool04Color.name.Contains("welder_geos"))
                {
                    tool04Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}

