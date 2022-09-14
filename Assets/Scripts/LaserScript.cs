using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LaserScript : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField]

    private Transform startPoint;
    private GameObject door;
    private GameObject ground;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lr.SetPosition(0, startPoint.position);
        RaycastHit hit;

        if(Physics.Raycast(transform.position, -transform.right, out hit))
        {
            if(hit.collider)
            {
                lr.SetPosition(1, hit.point);
                
            }
            

             if(hit.transform.tag == "Obstacle")
             {
                 if(!door) door = GameObject.FindGameObjectWithTag("Porte");
		     if(!ground) ground = GameObject.FindGameObjectWithTag("GroundTeleportationValide");
		     ground.GetComponent<TeleportationArea>().enabled = true;
			door.SetActive(false);
             }else
		{
			if(!door) door = GameObject.FindGameObjectWithTag("Porte");
			door.SetActive(true);

		     if(!ground) ground = GameObject.FindGameObjectWithTag("GroundTeleportationValide");
		     ground.GetComponent<TeleportationArea>().enabled = false;

		}


        }
        else
        {
            lr.SetPosition(1, -transform.right * 5000);
        }
    }
}
