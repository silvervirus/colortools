using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000003 RID: 3
	[HarmonyPatch(typeof(FlashLight))]
	[HarmonyPatch("Start")]
	internal class FlashLight_Color_Patch
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000208C File Offset: 0x0000028C
		public static bool Prefix(FlashLight __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("flashlight_batt_rig_Flashlight");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Flightvalue), Convert.ToByte(MainPatch.config.Flightgvalue), Convert.ToByte(MainPatch.config.Flightbvalue), 1);
				}
			}
			return true;
		}
	}
}
