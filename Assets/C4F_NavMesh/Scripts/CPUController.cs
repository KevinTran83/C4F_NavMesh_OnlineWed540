using UnityEngine;
using UnityEngine.AI;

public class CPUController : MonoBehaviour
{
    [SerializeField] private float _moveRange = 10f;

    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        
    }

    private void PickNewDestination()
    {
        Vector3 newDest = Random.insideUnitSphere * _moveRange
                        + transform.position;

        
    }
}
