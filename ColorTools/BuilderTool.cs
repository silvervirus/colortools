using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Harmony;
using UnityEngine;

namespace ColorTools
{

    [HarmonyPatch(typeof(BuilderTool))]
    [HarmonyPatch("Update")]

    internal class builder_Color_Patch
    {
        public static bool Prefix(BuilderTool __instance)
        {




            var tool9Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
            var tool10Color = __instance.GetAllComponentsInChildren<MeshRenderer>();

            foreach (var tool09Color in tool9Color)
            {
                if (tool09Color.name.Contains("builder_geo"))
                {
                    tool09Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }

            foreach (var tool110Color in tool10Color)
            {
                if (tool110Color.name.Contains("builder"))
                {
                    tool110Color.material.color = new Color32(Convert.ToByte(Config.toolValue), Convert.ToByte(Config.toolgValue), Convert.ToByte(Config.toolbValue), 1);
                }
            }






            return true;

        }
    }
}
