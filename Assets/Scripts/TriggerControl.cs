using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    public GameObject DoorOBS;
    public GameObject Wall_L_02;
    public GameObject Winbox;
    public GameObject HallLight;

    public void Start()
    {
        DoorOBS.SetActive(true);
        Wall_L_02.SetActive(true);
        // set Winbox emission OFF
        Winbox.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
        Winbox.GetComponent<MeshRenderer>().material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.EmissiveIsBlack;
        
        HallLight.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        DoorOBS.SetActive(false);
        Wall_L_02.SetActive(false);
        // set Winbox emission ON
        Winbox.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
        Winbox.GetComponent<MeshRenderer>().material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.None;

        HallLight.SetActive(true);

    }
    public void OnTriggerExit(Collider other)
    {
        // set Winbox emission OFF
        Winbox.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
        Winbox.GetComponent<MeshRenderer>().material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.EmissiveIsBlack;
    }
}
