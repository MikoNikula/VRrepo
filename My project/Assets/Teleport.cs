using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{

    public InputActionReference action;

    bool startPoint = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        action.action.performed += (ctx) => 
        {
            if(startPoint){
                transform.position = new Vector3(0f, 2f, -45f);
                startPoint = !startPoint;
            }else {
                transform.position = new Vector3(0f, 2f, 0f);
                startPoint = !startPoint;
            }
        };
    }
}
