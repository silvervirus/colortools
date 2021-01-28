using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000013 RID: 19
	[HarmonyPatch(typeof(ScannerTool))]
	[HarmonyPatch("Update")]
	internal class Scanner_Color_Patch
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002F80 File Offset: 0x00001180
		public static bool Prefix(ScannerTool __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("scanner_geo");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Scannervalue), Convert.ToByte(MainPatch.config.Scannergvalue), Convert.ToByte(MainPatch.config.Scannerbvalue), 1);
				}
			}
			return true;
		}
	}
}
