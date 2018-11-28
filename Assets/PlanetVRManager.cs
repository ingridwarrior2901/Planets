using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetVRManager : MonoBehaviour
{
    [Header("VR Game Objects")]
    public GameObject controllerMain;
    public GameObject editorEmulator;

    [Header("Camera Game Objects")]
    public GameObject vrCamera;
    public GameObject orbitCamera;
   
    public bool useVR = false;

    private GameObject m_controllerMain;
    private GameObject m_editorEmulator;

    void Start()
    {
        m_controllerMain = Instantiate(controllerMain);
        m_editorEmulator = Instantiate(editorEmulator);
    }

    void Update()
    {
        OnVRSettingsChange();
    }

    void OnVRSettingsChange() 
    {
        orbitCamera.SetActive(!useVR);
        VRGameObjects();
    }

    void VRGameObjects()
    {
        vrCamera.SetActive(useVR);
        m_controllerMain.SetActive(useVR);
        m_editorEmulator.SetActive(useVR);
    }
}
