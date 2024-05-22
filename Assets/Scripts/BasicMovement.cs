using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class BasicMovement : NetworkBehaviour
{
    Rigidbody rb;
    [SerializeField] public float speed =100f; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsOwner) return;
        if (rb != null)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            if (h!=0)
            {
                this.transform.Translate(h * speed * Time.deltaTime, 0, 0);
            }
            if(v!=0)
            {
                this.transform.Translate(0,0,v * speed * Time.deltaTime);
            }
            
        }
    }
}
