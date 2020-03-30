using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(Flare))]
    [HarmonyPatch("Update")]

    internal class Flare_Color_Patch
    {
        public static bool Prefix(Flare __instance)
        {




            var tool20Color = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var tool27Color = __instance.GetAllComponentsInChildren<MeshRenderer>();

            foreach (var tool19Color in tool20Color)
            {
                if (tool19Color.name.Contains("flare"))
                {
                    tool19Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }

            foreach (var tool28Color in tool27Color)
            {
                if (tool28Color.name.Contains("flare_cap"))
                {
                    tool28Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }






            return true;

        }
    }
}

