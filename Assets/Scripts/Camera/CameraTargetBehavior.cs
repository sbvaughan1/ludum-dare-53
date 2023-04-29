using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CameraTargetActor")
        {
            Camera.main.transform.position = transform.position;
        }
    }
}
