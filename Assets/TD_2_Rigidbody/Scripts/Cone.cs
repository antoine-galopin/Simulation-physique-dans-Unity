using UnityEngine;


public class Cone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Exercice 2.1: si on entre en collision avec le sol (tag "Ground"), changer la couleur du cone en rouge
        if (collision.gameObject.CompareTag("Sphere"))
        {
            Instantiate(gameObject, transform.position, transform.rotation);
        }
    }
}