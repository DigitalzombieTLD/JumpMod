using System;
using MelonLoader;
using Harmony;
using UnityEngine;
using System.Reflection;
using System.Xml.XPath;
using System.Globalization;
using UnhollowerRuntimeLib;
using ModSettings;

namespace JumpMod
{
    public class JumpModMain : MelonMod
    {        
        public override void OnApplicationStart()
        {  
            MelonLogger.Log("Jump mod succesfully loaded");



            // Settings menu
            JumpMod.Settings.OnLoad();
        }

        public override void OnLevelWasInitialized(int level)
        {
           
        }

        public override void OnUpdate()
        {
           
        }

        public override void OnFixedUpdate()
        {

        }
    }
}