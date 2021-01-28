using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(AirBladder))]
    [HarmonyPatch("Update")]

    internal class AirBladder_Color_Patch
    {
        public static bool Prefix(AirBladder __instance)
        {




            var toolColor = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
           

            foreach (var tool01Color in toolColor)
            {
                if (tool01Color.name.Contains("air_bladder_geo"))
                {
                    tool01Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }
            



            



            return true;

        }
    }
}

