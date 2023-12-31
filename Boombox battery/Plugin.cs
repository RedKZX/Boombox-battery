using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using BepInEx;
using BepInEx.Logging;
using Boombox_battery.Patches;
using HarmonyLib;
using UnityEngine;

namespace Boombox_battery
{
    [BepInPlugin("Henrehs.BoomBoxBattery", "BoomBoxBattery", "1.0.0.0")]
    public class BoomboxBatteryBase : BaseUnityPlugin
    {
        private const string modGUID = "Henrehs.BoomBoxBattery";
        private const string modName = "BoomBoxBattery";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony("Henrehs.BoomBoxBattery");
        private static BoomboxBatteryBase Instance;
        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("[HENREH] The Boombox will now play for all eternity!");



            harmony.PatchAll(typeof(BoomboxPlugin));
        }
    }
}
    

   