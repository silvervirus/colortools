using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(FireExtinguisher))]
    [HarmonyPatch("Update")]

    internal class FireE_Color_Patch
    {
        public static bool Prefix(FireExtinguisher __instance)
        {




            var tool8Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var tool08Color in tool8Color)
            {
                if (tool08Color.name.Contains("fire_extinguisher_tube_01_fp"))
                {
                    tool08Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}
