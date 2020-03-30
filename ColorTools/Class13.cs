using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(PlayerTool))]
    [HarmonyPatch("OnHolster")]

    internal class knife_Color_Patch
    {
        public static bool Prefix(PlayerTool __instance)
        {




            var tool122Color = __instance.GetAllComponentsInChildren<MeshRenderer>();


            foreach (var tool1222Color in tool122Color)
            {
                if (tool1222Color.name.Contains("knife_01"))
                {
                    tool1222Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}

