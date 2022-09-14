using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using System;

public class UnlockTheDoor : MonoBehaviour
{
    public GameObject door;
    public void OnEntered(SelectEnterEventArgs args)
    {
        Debug.Log(" C'est ici : ");
        door = GameObject.FindGameObjectWithTag("TheDoor");
        door.SetActive(false);
    }

    public void OnExited(SelectExitEventArgs args)
    {
        Debug.Log("Exit");
    }
}
