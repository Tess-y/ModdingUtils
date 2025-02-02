﻿using System;
using System.Collections.Generic;
using HarmonyLib;
using ModdingUtils.Extensions;

namespace ModdingUtils.Patches
{
    // patch to reset cards and effects
    [Serializable]
    [HarmonyPatch(typeof(Player), "FullReset")]
    class PlayerPatchFullReset
    {
        private static void Prefix(Player __instance)
        {
            CustomEffects.DestroyAllEffects(__instance.gameObject);
            __instance.data.currentCards = new List<CardInfo> { };
        }
    }
}
