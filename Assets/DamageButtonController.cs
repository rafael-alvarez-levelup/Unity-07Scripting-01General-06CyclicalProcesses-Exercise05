using UnityEngine;
using UnityEngine.EventSystems;

public class DamageButtonController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private HealthBehaviour healthBehavior;

    private readonly int damage = 10;

    public void OnPointerClick(PointerEventData eventData)
    {
        DealDamage(damage);
    }

    private void DealDamage(int damageAmount)
    {
        healthBehavior.DoDamage(damageAmount);
    }
}