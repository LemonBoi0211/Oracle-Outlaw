using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject smallOrbitP;
    public GameObject bigOrbitP;
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(smallOrbitP.transform.localPosition, Vector3.forward, Time.deltaTime * velocity);
    }
}
