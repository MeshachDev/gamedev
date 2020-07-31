using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class playermovement1camera : MonoBehaviour
{
    public float mousesen =100f;
    public Transform player;
    float xroa = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState =CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * mousesen * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mousesen * Time.deltaTime;

        xroa = Mathf.Clamp(xroa, -80f, 80f);
        player.Rotate(Vector3.up * mousex);
        xroa -= mousey;
        transform.localRotation = Quaternion.Euler(xroa, 0f, 0f);

       

    }
}
