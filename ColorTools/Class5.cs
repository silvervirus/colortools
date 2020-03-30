using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(LaserCutter))]
    [HarmonyPatch("Update")]

    internal class laser_Color_Patch
    {
        public static bool Prefix(LaserCutter __instance)
        {




            
            var tool2Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
            var tool3Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var tool02Color in tool2Color)
            {
                if (tool02Color.name.Contains("Laser_cutter_geo"))
                {
                    tool02Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }

               


                

            }

            return true;

        }
    }
}

