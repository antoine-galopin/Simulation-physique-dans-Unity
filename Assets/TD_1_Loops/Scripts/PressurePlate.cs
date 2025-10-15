using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PressurePlate : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Animator animator;

    private float pressDuration = 1.5f;

    // Exercice 1.3: décommentez ce code
    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(PressAndRelease());
    }

    IEnumerator PressAndRelease()
    {
        animator.SetBool("Pressed", true);
        yield return new WaitForSeconds(pressDuration);
        animator.SetBool("Pressed", false);
    }

    // Exercice 1.2: décommentez ce code
    public void OnPointerEnter(PointerEventData eventData)
    {
        //animator.SetBool("Pressed", true);
    }

    // Exercice 1.2: décommentez ce code
    public void OnPointerExit(PointerEventData eventData)
    {
        //animator.SetBool("Pressed", false);
    }
}
