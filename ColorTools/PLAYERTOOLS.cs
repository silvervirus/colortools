using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x0200000A RID: 10
	[HarmonyPatch(typeof(PlayerTool))]
	[HarmonyPatch("OnDraw")]
	internal class playertool_Color_Patch
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000025CC File Offset: 0x000007CC
		public static bool Prefix(PlayerTool __instance)
		{

			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			MeshRenderer[] allComponentsInChildren1 = __instance.GetAllComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer MeshRenderer in allComponentsInChildren1)
			{
				bool flag = MeshRenderer.name.Contains("RifleMesh");
				if (flag)
				{
					MeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Riflegvalue), Convert.ToByte(MainPatch.config.Riflegvalue), Convert.ToByte(MainPatch.config.Riflebvalue), 1);
				}
				bool flag2 = MeshRenderer.name.Contains("GunMain");
				if (flag2)
				{
					MeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Gunvalue), Convert.ToByte(MainPatch.config.Gungvalue), Convert.ToByte(MainPatch.config.Gunbvalue), 1);
				}
			}
				foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("Terraformer_body");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Terrabuildervalue), Convert.ToByte(MainPatch.config.Terrabuildergvalue), Convert.ToByte(MainPatch.config.Terrabuilderbvalue), 1);
				}
				bool flag2 = skinnedMeshRenderer.name.Contains("Terraformer_front_01_02");
				if (flag2)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Terrabuildervalue), Convert.ToByte(MainPatch.config.Terrabuildergvalue), Convert.ToByte(MainPatch.config.Terrabuilderbvalue), 1);
				}
				bool flag3 = skinnedMeshRenderer.name.Contains("Terraformer_front_02_02");
				if (flag3)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Terrabuildervalue), Convert.ToByte(MainPatch.config.Terrabuildergvalue), Convert.ToByte(MainPatch.config.Terrabuilderbvalue), 1);
				}
				bool flag4 = skinnedMeshRenderer.name.Contains("Terraformer_front");
				if (flag4)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Terrabuildervalue), Convert.ToByte(MainPatch.config.Terrabuildergvalue), Convert.ToByte(MainPatch.config.Terrabuilderbvalue), 1);
				}


			}

			return true;
		}
	}
}
