using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter instance;

    private float _score;
    [SerializeField] private Text _label;

    public void AddScore(float amount)
    {
        _score += amount;
        _label.text = "SCORE: " + _score;
    }
    public void ResetScore()
    {
        _score = 0;
        _label.text = "SCORE: " + _score;
    }
    public bool IsEven() { return _score % 2 == 0; }

    public void Start()
    {
        instance = this;
    }
}
