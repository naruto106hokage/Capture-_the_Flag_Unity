using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcquiredTheFlag : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        print("Flag Occupied by: "+collision.gameObject.name);
        Time.timeScale = 0;
    }
}
