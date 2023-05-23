using UnityEngine;

public class Hole : MonoBehaviour
{
    public HoleMovement HoleMovement { get; private set; }

    private void Awake()
    {
        HoleMovement = GetComponent<HoleMovement>().Init(this);
    }
}
