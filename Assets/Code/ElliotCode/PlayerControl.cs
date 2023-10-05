using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Transform smallOrbitP;
    public Vector3 desiredPos;
    public float radius = 2.0f;
    public float radiusSpeed = 0.5f;
    public float rotSpeed = 80.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //counter clockwise rotation
        transform.RotateAround(smallOrbitP.transform.localPosition, Vector3.forward, Time.deltaTime * rotSpeed);

        //hold thing down, increase orbit
        if (Input.GetKey(KeyCode.Space))
        {
            desiredPos = (transform.position - smallOrbitP.position).normalized * radius + smallOrbitP.position;
            transform.position = Vector3.MoveTowards(transform.position, desiredPos, Time.deltaTime * radiusSpeed);
        }

    }

}
