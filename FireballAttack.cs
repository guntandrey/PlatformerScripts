using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    public GameObject fireballprefab;
    public Transform attackPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballprefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
