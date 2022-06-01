using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _force;

    private void Update()
    {
        if (EnterSphere.flag == true)
        {
            Explode();
        }
        
    }

    public void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody rigidbody = colliders[i].attachedRigidbody;
            if (rigidbody != null)
            {
                rigidbody.AddExplosionForce(_force, transform.position, _radius);
            }
        }
        
    }
}
