using UnityEngine;

public class HoleLayerChanger : MonoBehaviour
{
    private const string enterLayer = "Collectible";
    private const string exitLayer = "Default";
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent(out CollectibleObject collectibleObject))
            return;

        other.gameObject.layer = LayerMask.NameToLayer(enterLayer);
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (!other.TryGetComponent(out CollectibleObject collectibleObject))
            return;

        other.gameObject.layer = LayerMask.NameToLayer(exitLayer);
    }
}
