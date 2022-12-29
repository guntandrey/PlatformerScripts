using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Health player = other.GetComponent<Health>();

        player.TakeDamage(playerDamage);
    }
}
