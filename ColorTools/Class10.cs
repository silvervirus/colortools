using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(FlashLight))]
    [HarmonyPatch("Start")]

    internal class FlashLight_Color_Patch
    {
        public static bool Prefix(FlashLight __instance)
        {




            var tool7Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var tool07Color in tool7Color)
            {
                if (tool07Color.name.Contains("flashlight_batt_rig_Flashlight"))
                {
                    tool07Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }








            return true;

        }
    }
}

