using UnityEngine;
using UnityEngine.AI;

public class HoleMovement : MonoBehaviour
{
    [SerializeField] private Joystick joystick;

    [SerializeField] private float moveSpeed = 5f;

    private NavMeshAgent agent;

    private Hole hole;
    
    public HoleMovement Init(Hole hole)
    {
        this.hole = hole;
        agent = GetComponent<NavMeshAgent>();

        return this;
    }

    private void Update()
    {
        Vector2 direction = joystick.Direction;

        Vector3 input = new(direction.x, 0f, direction.y);

        agent.Move(input * (moveSpeed * Time.deltaTime));
    }
}
