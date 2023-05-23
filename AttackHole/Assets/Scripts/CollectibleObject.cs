using System;
using DG.Tweening;
using UnityEngine;

public class CollectibleObject : MonoBehaviour
{
    private bool isInteracted = false;

    private Collider collider;
    private Rigidbody rb;

    private void Awake()
    {
        collider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isInteracted)
            return;
        
        if (!collision.gameObject.TryGetComponent(out HoleController holeController))
            return;

        isInteracted = true;
        
        HandleOnCollected(holeController.HolePosition, holeController.transform);
    }

    private void Update()
    {
        
    }

    private void HandleOnCollected(Transform target, Transform parent)
    {
        collider.isTrigger = true;
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;

        float distance = Vector3.Distance(target.position, transform.position);

        Vector3 force = direction * distance;
        rb.AddForce(force, ForceMode.Impulse);
        rb.AddTorque(force, ForceMode.Impulse);
        
    }
}
