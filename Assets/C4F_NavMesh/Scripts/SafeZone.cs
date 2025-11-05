using UnityEngine;

public class SafeZone : MonoBehaviour
{
    [SerializeField] private bool _isEven;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() == null) return;

        if (ScoreCounter.instance.IsEven() != _isEven)      return;

        ScoreCounter.instance.AddScore(1);
    }
}
