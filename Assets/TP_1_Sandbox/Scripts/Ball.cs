using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject firework;
    [SerializeField] private Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        // Exercice 2.1: si on entre en collision avec le sol (tag "Ground"), changer la couleur du cone en rouge
        if (collision.gameObject.CompareTag("Filet"))
        {
            transform.position = new Vector3(0, 2, 0);
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            Instantiate(firework, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
        }
    }
}
