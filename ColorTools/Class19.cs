using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(RepulsionCannon))]
    [HarmonyPatch("Update")]

    internal class RepulsionCannon_Color_Patch
    {
        public static bool Prefix(RepulsionCannon __instance)
        {




            var tool21Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
            var tool23Color = __instance.GetAllComponentsInChildren<MeshRenderer>();

            foreach (var tool22Color in tool21Color)
            {
                if (tool22Color.name.Contains("Propulsion_Cannon_geo"))
                {
                    tool22Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }

            foreach (var tool24Color in tool23Color)
            {
                if (tool24Color.name.Contains("Propulsion_Cannon"))
                {
                    tool24Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }






            return true;

        }
    }
}

