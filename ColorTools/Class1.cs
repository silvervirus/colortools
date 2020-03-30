﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using SMLHelper.V2.Handlers;
using UnityEngine;
using System.Reflection;
using QModManager.API.ModLoading;


namespace ColorTools
{
    [QModCore]
    public class MainPatch
    {
        [QModPatch]
        public static void Patch()
        {
            Config.Load();
            OptionsPanelHandler.RegisterModOptions(new Options());
            SecondStart();
        }
        public static void SecondStart()
        {
            HarmonyInstance.Create("ColorTools.mod").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}