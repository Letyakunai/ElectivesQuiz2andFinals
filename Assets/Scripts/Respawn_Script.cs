using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Script : MonoBehaviour
{

    // Get the initial spawn location and rotation of the object that is going to respawn.
    private Vector3 spawnPosition;
    private Quaternion spawnRotation;

    private void Awake()
    {
        spawnPosition = gameObject.transform.position;
        spawnRotation = gameObject.transform.rotation;
    }
    public void Respawn()
    {
        transform.position = spawnPosition;
        transform.rotation = spawnRotation;
    }

}
