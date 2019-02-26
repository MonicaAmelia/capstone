using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : MonoBehaviour {

    [SerializeField] private Collider playerCollider;
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (playerCollider.Equals(other))
            player.transform.position = respawnPoint.transform.position;
    }
}
