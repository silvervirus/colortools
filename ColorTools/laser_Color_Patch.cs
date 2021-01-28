using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000012 RID: 18
	[HarmonyPatch(typeof(LaserCutter))]
	[HarmonyPatch("Update")]
	internal class laser_Color_Patch
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002EEC File Offset: 0x000010EC
		public static bool Prefix(LaserCutter __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			SkinnedMeshRenderer[] allComponentsInChildren2 = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("Laser_cutter_geo");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.laservalue), Convert.ToByte(MainPatch.config.lasergvalue), Convert.ToByte(MainPatch.config.laserbvalue), 1);
				}
			}
			return true;
		}
	}
}
