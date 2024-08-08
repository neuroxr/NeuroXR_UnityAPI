using NeuroXR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class API_Control : MonoBehaviour
{
    private NeuroXR_API_Unity api;
    public Text serverIpPort;

    void Start()
    {
        api = GetComponent<NeuroXR_API_Unity>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            api.serverIpPort = serverIpPort.text;
            api.Connect();
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            api.Disconnect();
        }
    }
}
