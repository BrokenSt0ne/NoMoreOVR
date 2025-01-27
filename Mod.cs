using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using UnityEngine;

namespace NoMoreOVR
{
    [BepInPlugin("BrokenStone.NoMoreOVR", "NoMoreOVR", "1.0.0")]
    public class Mod : BaseUnityPlugin
    {
        bool ran;
        bool disabled = false;

        void Update()
        {
            if (GorillaTagger.Instance != null && !ran)
            {
                ran = true;
            }

            if(ran && !disabled)
            {
                foreach (OVRManager instances in GameObject.FindObjectsOfType<OVRManager>())
                {
                    instances.enabled = false;
                    disabled = true;
                    Debug.Log("[NoMoreOVR] Disabled OVRManager.");
                }
            }
        }
    }
}
