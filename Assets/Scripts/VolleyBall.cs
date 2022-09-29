using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBall : MonoBehaviour
{
    public AudioClip teleportSound;

    void OnCollisionEnter(Collision collision)
    {
        transform.position = Camera.main.transform.position + new Vector3(0,10,0);
        GetComponent<Rigidbody>().velocity = Vector3.zero;

        if (teleportSound != null)
        {
            AudioSource.PlayClipAtPoint(teleportSound, Camera.main.transform.position);
        }
    }
}
