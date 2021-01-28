using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(PropulsionCannon))]
    [HarmonyPatch("Update")]

    internal class PropulsionCannon_Color_Patch
    {
        public static bool Prefix(PropulsionCannon __instance)
        {




            var tool6Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
            var tool25Color = __instance.GetAllComponentsInChildren<MeshRenderer>();

            foreach (var tool06Color in tool6Color)
            {
                if (tool06Color.name.Contains("Propulsion_Cannon_geo"))
                {
                    tool06Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }
            foreach (var tool26Color in tool25Color)
            {
                if (tool26Color.name.Contains("Propulsion_Cannon"))
                {
                    tool26Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }







            return true;

        }
    }
}

