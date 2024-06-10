using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MyHand : MonoBehaviour
{
    // public GameObject cube;
    private SteamVR_Action_Boolean pinch;
    private SteamVR_Action_Boolean grip;
    private SteamVR_Behaviour_Pose pose;

    // Start is called before the first frame update
    void Awake()
    {
        pinch = SteamVR_Actions.default_GrabPinch;
        grip = SteamVR_Actions.default_GrabGrip;
        pose = GetComponent<SteamVR_Behaviour_Pose>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pinch.GetStateDown(pose.inputSource) || Input.GetMouseButtonDown(0))
        {
            Console.WriteLine("pinch");
        }
    }
}
