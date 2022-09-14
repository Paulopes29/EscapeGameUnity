using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacer : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Mouse0) )
        {
            transform.Translate(Vector3.left * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.Mouse1) )
        {
            transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetAxis("Mouse ScrollWheel") > 0f )
        {
            transform.Translate(Vector3.up * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetAxis("Mouse ScrollWheel") < 0f )
        {
            transform.Translate(Vector3.down * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.back * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }
    }
}
