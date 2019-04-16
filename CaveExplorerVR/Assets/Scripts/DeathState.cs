using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : MonoBehaviour {

    [SerializeField] private Collider playerCollider;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public AudioSource cry;

    private void OnTriggerEnter(Collider other)
    {
        if (playerCollider.Equals(other)) {
            cry.Play();
            player.transform.position = respawnPoint.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (playerCollider.Equals(other))
        {
            cry.Play();
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
