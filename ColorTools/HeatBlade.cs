using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(HeatBlade))]
    [HarmonyPatch("OnToolUseAnim")]

    internal class hotknife_Color_Patch
    {
        public static bool Prefix(HeatBlade __instance)
        {




            var tool11Color = __instance.GetAllComponentsInChildren<MeshRenderer>();


            foreach (var tool111Color in tool11Color)
            {
                if (tool111Color.name.Contains("knife_01_hot"))
                {
                    tool111Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}

