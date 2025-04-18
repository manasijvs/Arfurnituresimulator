using UnityEngine;
//using Systems.Collections.Generic;
//using Systems.Collections;

public class Rotate : MonoBehaviour
{
    public Vector3 rot;
    void Update()
    {
        transform.Rotate(rot * Time.deltaTime);
    }
}
