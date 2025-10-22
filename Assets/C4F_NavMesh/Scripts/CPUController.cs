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
        if (_agent.remainingDistance < 1) PickNewDestination();
    }

    private void PickNewDestination()
    {
        Vector3 newDest = Random.insideUnitSphere * _moveRange
                        + transform.position;

        if (NavMesh.SamplePosition ( newDest,
                                     out NavMeshHit hit,
                                     1,
                                     NavMesh.AllAreas
                                   )) _agent.SetDestination(hit.position);
        else PickNewDestination();
    }
}
