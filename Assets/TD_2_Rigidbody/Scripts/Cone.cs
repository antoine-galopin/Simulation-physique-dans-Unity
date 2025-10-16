using UnityEngine;


public class Cone : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private GameObject conceptionEffect;

    private void OnCollisionEnter(Collision collision)
    {
        // Exercice 2.1: si on entre en collision avec le sol (tag "Ground"), changer la couleur du cone en rouge
        if (collision.gameObject.CompareTag("Sphere"))
        {
            Instantiate(conceptionEffect, transform.position, transform.rotation);
            Instantiate(gameObject, transform.position, transform.rotation);
        }

        else if (collision.gameObject.CompareTag("Car"))
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}