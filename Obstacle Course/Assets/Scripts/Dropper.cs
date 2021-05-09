using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitTime = 3.0f;
    MeshRenderer render;
    Rigidbody rigidBody;
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        render.enabled = false;
        rigidBody.useGravity = false;
    }
    
    
    void Update() 
    {
        if (Time.time > waitTime) {
            render.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
