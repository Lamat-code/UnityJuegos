using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_WhellRt : MonoBehaviour
{
    public float rotationSpeed = 100f;

    

    void Update()
    {

        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));

    }
}
