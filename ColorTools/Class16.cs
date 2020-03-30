using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(LEDLight))]
    [HarmonyPatch("Update")]

    internal class LEDlight_Color_Patch
    {
        public static bool Prefix(LEDLight __instance)
        {




            var tool15Color = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var tool30Color = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var tool16Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();

            foreach (var tool17Color in tool15Color)
            {
                if (tool17Color.name.Contains("LED_light"))
                {
                    tool17Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }
            foreach (var tool31Color in tool30Color)
            {
                if (tool31Color.name.Contains("LED_Light"))
                {
                    tool31Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }
            foreach (var tool18Color in tool16Color)
            {
                if (tool18Color.name.Contains("LED_Light_01"))
                {
                    tool18Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }







            return true;

        }
    }
}

