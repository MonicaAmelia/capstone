/************************************************************************************
Copyright : Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.

Licensed under the Oculus Utilities SDK License Version 1.31 (the "License"); you may not use
the Utilities SDK except in compliance with the License, which is provided at the time of installation
or download, or which otherwise accompanies this software in either electronic or hard copy form.

You may obtain a copy of the License at
https://developer.oculus.com/licenses/utilities-1.31

Unless required by applicable law or agreed to in writing, the Utilities SDK distributed
under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
ANY KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

This is a personalized edited version of OVR Grabbable not intended for distribution.
Edited by Eric Reed and Monica Perez for the sole purpose of completing their CAPSTONE senior project.
************************************************************************************/

using System;
using UnityEngine;

/// <summary>
/// An object that can be grabbed and thrown by OVRGrabber.
/// </summary>
public class Sticky : OVRGrabbable
{

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
    }


    private void OnTriggerEnter(Collider other)
    {
        print("HIT");
        if ((!this.isGrabbed) && other.GetType() != typeof(SphereCollider))
        {
            print("YOU ARE NOW STICKY!!");
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
