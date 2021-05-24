using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade_Script : MonoBehaviour
{
    bool CurrentlyCutting = false;
    Rigidbody2D rb;
    public new Camera camera;

    void Start()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cut();
        } else if (Input.GetMouseButtonUp(0))
        {
            StopCut();
        }
        
        if(CurrentlyCutting)
        {
            UpdateCut();
        }
    }
    
    void UpdateCut()
    {
        //rb.position.z = 10;
        rb.position = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    void Cut()
    {
        CurrentlyCutting = true;
    }
    void StopCut()
    {
        CurrentlyCutting = false;
    }
}
