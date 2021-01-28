using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(Terraformer))]
    [HarmonyPatch("Update")]

    internal class Terraformer_Color_Patch
    {
        public static bool Prefix(Terraformer __instance)
        {




            var tool18Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var tool19Color in tool18Color)
            {
                if (tool19Color.name.Contains("Terraformer_body"))
                {
                    tool19Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}

