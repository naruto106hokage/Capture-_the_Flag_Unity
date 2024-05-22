using UnityEngine;

public class NameUpdate : MonoBehaviour
{
 
    void Start()
    {
        gameObject.name = "Netcode" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
    }
}
