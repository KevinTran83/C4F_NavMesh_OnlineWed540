using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Respawn : MonoBehaviour
{
    [SerializeField] private LayerMask _enemyLayer;
    private Vector3      _spawnPos;
    private NavMeshAgent _agent;
    [SerializeField] private UnityEvent _onRespawn;

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

            _onRespawn?.Invoke();

            // Reset score
            ScoreCounter.instance.ResetScore();
        }
    }

    public void DoRespawn()
    { 
        transform.position = _spawnPos;
        _agent.ResetPath();
    }
}
