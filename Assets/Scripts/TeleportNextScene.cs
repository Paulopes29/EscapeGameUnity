using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class TeleportNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTeleporting(TeleportingEventArgs args)
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
 	  SceneManager.LoadScene(nextSceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
