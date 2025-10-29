using UnityEngine;
using UnityEngine.AI;

public class Respawn : MonoBehaviour
{
    [SerializeField] private LayerMask _enemyLayer;
    private Vector3      _spawnPos;
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _spawnPos = transform.position;
    }

    private void OnCollisionEnter(Collision col)
    {
        if ( ( (1 << col.collider.gameObject.layer) & _enemyLayer) != 0)
        {
            // Respawn
            DoRespawn();
        }
    }

    public void DoRespawn()
    { 
        transform.position = _spawnPos;
        _agent.ResetPath();
    }
}
