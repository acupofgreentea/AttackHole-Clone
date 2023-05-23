using UnityEngine;

public class CollectibleObject : MonoBehaviour
{
    private bool isInteracted = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (isInteracted)
            return;
        
        if (!collision.gameObject.TryGetComponent(out Hole hole))
            return;

        isInteracted = true;
    }
}
