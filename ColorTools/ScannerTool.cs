using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(ScannerTool))]
    [HarmonyPatch("Update")]

    internal class Scanner_Color_Patch
    {
        public static bool Prefix(ScannerTool __instance)
        {




            var tool3Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var tool03Color in tool3Color)
            {
                if (tool03Color.name.Contains("scanner_geo"))
                {
                    tool03Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}

