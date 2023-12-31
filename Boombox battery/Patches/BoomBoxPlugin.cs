using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Boombox_battery.Patches
{
    [HarmonyPatch(typeof(BoomboxItem))]
    public class BoomboxPlugin
    {
        private const string modGUID = "Henrehs.BoomBoxBattery";

        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void PatchBattery(ref Item ___itemProperties)
        {
            ___itemProperties.requiresBattery = false;
        }
    }
}
