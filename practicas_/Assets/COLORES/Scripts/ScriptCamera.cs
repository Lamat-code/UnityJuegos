using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamera : MonoBehaviour
{
    public  Transform playerTransform;

    void Update()
    {
        if(playerTransform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerTransform.position.y, transform.position.z);
        }
    }
}
