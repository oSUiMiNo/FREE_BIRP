using EVMC4U;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAvatar : MonoBehaviour
{
    public List<GameObject> Avatars = new List<GameObject>();
    public ExternalReceiver Receiver = null;

    void Start()
    {
        InputEventHandler.OnDown_M += () =>
        {
            Receiver.Model = Avatars[0];
            Avatars.ForEach(a => a.SetActive(false));
            Avatars[0].SetActive(true);
        };
        InputEventHandler.OnDown_N += () =>
        {
            Receiver.Model = Avatars[1];
            Avatars.ForEach(a => a.SetActive(false));
            Avatars[1].SetActive(true);
        };
    }
}
