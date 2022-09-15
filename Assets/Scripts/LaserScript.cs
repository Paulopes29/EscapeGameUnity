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
    private bool doorOpen = false;
    
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
                 doorOpen = true;
                 if(door.transform.position.y < 5){
                 	door.transform.Translate(Vector3.up*Time.deltaTime);
                 }
                
             }
             else
		{
			 Debug.Log(doorOpen);
			if(!door) door = GameObject.FindGameObjectWithTag("Porte");
			
			if(doorOpen){
				if(door.transform.position.y > 2.5)
				{
					door.transform.Translate(Vector3.down*Time.deltaTime);
				}
				doorOpen = false;
			}
		}


        }
        else
        {
            lr.SetPosition(1, -transform.right * 5000);
            if(!door) door = GameObject.FindGameObjectWithTag("Porte");
            if(door.transform.position.y > 2.5)
				{
					door.transform.Translate(Vector3.down*Time.deltaTime);
				}
				doorOpen = false;


        }
    }
    }
