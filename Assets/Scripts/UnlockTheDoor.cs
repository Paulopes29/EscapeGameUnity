using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using System;
using UnityEngine.SceneManagement;

public class UnlockTheDoor : MonoBehaviour
{
    public GameObject door;
    public void OnEntered(SelectEnterEventArgs args)
    {
        if(!door) door = GameObject.FindGameObjectWithTag("TheDoor");
        door.SetActive(false);
    }

    public void OnExited(SelectExitEventArgs args)
    {
        if(!door) door = GameObject.FindGameObjectWithTag("TheDoor");
        door.SetActive(true);
    }
}
