using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVolumeTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player has entered the trigger.");
        }
    }
}
