using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTimer : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float dropCountdown = 3f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();

        rigidbody.useGravity = false;
        renderer.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= dropCountdown)
        {
            rigidbody.useGravity = true;
            renderer.enabled = true;
        }
    }
}
