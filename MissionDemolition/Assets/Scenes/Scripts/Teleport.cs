using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    //public GameObject grenade;
    //public GameObject projectile;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Grenade(Clone)" || other.gameObject.name == "Projectile(Clone)")
        {
            other.transform.position = teleportTarget.transform.position;
        }
        //projectile.transform.position = teleportTarget.transform.position;
    }
}
