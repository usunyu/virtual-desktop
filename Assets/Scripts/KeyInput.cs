using UnityEngine;
using System.Collections;
using Valve.VR;

public class KeyInput : MonoBehaviour
{

    public SteamVR_TrackedObject left;
    public SteamVR_TrackedObject right;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SteamVR_Controller.Device leftDevice = null;
        SteamVR_Controller.Device rightDevice = null;
        if (left.index != SteamVR_TrackedObject.EIndex.None)
        {
            leftDevice = SteamVR_Controller.Input((int)left.index);
        }
        if (right.index != SteamVR_TrackedObject.EIndex.None)
        {
            rightDevice = SteamVR_Controller.Input((int)right.index);
        }
        if (leftDevice != null && leftDevice.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            SteamVR.instance.overlay.ShowKeyboard(0, 0, "Description", 256, "", true, 0);
        }
        if (rightDevice != null && rightDevice.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            SteamVR.instance.overlay.ShowKeyboard(0, 0, "Description", 256, "", true, 0);
        }
    }

    void OnEnable()
    {
        SteamVR_Events.SystemAction(EVREventType.VREvent_KeyboardCharInput, OnKeyboard).Enable(true);
    }

    void OnDisable()
    {
        SteamVR_Events.SystemAction(EVREventType.VREvent_KeyboardCharInput, OnKeyboard).Enable(false);
    }

    private void OnKeyboard(VREvent_t evt)
    {
        VdmDesktopManager.Instance.SimulateKey((char)evt.data.keyboard.cNewInput0);
    }
}
