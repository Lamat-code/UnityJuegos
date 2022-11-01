using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    void Update()
    {
        if(transform.position.x <= -19f)
        {
            Destroy(gameObject);
        }
    }
}
