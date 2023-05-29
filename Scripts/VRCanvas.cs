using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.UI;

[RequireComponent(typeof(TrackedDeviceGraphicRaycaster))]
public class VRCanvas : MonoBehaviour
{
    private Canvas canvas;

    void OnEnable()
    {
        canvas = GetComponent<Canvas>();

        if(Camera.main)
            canvas.worldCamera = Camera.main;
    }
}