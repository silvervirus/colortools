using System;
using HarmonyLib;
using UnityEngine;


namespace ColorTools
{
	// Token: 0x02000011 RID: 17
	[HarmonyPatch(typeof(AirBladder))]
	[HarmonyPatch("Update")]
	internal class AirBladder_Color_Patch
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002E60 File Offset: 0x00001060
		public static bool Prefix(AirBladder __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("air_bladder_geo");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Airvalue), Convert.ToByte(MainPatch.config.Airgvalue), Convert.ToByte(MainPatch.config.Airbvalue), 1);
				}
			}
			return true;
		}
	}
}
