using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    private Rigidbody bulletRigibody;
    [SerializeField]
    private float moveSpeed = 10f;


    void Start()
    {
        bulletRigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BullectMove();
    }

    private void BullectMove()
    {
        bulletRigibody.velocity = transform.forward * moveSpeed;
    }

}
