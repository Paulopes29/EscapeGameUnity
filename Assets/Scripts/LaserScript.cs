using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField]

    private Transform startPoint;
    private GameObject[] objs;

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
                 objs = GameObject.FindGameObjectsWithTag("Porte");

                    foreach (GameObject obj in objs)
                    {
                        Destroy(obj);
                    }   
             }


        }
        else
        {
            lr.SetPosition(1, -transform.right * 5000);
        }
    }
}
