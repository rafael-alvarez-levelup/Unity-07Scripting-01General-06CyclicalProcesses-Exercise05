using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private HealthBehaviour healthBehaviour;

    private Text myText;

    private void Awake()
    {
        myText = GetComponent<Text>();
    }

    private void OnEnable()
    {
        healthBehaviour.OnChanged.AddListener(OnHealthChange);
    }

    private void OnDisable()
    {
        healthBehaviour.OnChanged.RemoveListener(OnHealthChange);
    }

    private void OnHealthChange(int health)
    {
        myText.text = health.ToString();
    }
}