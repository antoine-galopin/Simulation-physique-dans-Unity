using UnityEngine;
using UnityEngine.EventSystems;

public class ConeRaycaster : MonoBehaviour
{
    [SerializeField] private LayerMask m_LayerMask;

    void Update()
    {
        //Exercice 2.3 si on fait un clic gauche, faire un raycast depuis la souris, et si on touche un cone, appliquer une force au rigidbody du Cone
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo, m_LayerMask))
            {
                Rigidbody rigidbody = hitInfo.collider.GetComponent<Rigidbody>();

                if (rigidbody != null)
                {
                    //rigidbody.AddForce(new Vector3(0, 500, 0));
                    // Move the force direction on the click position
                    
                    Vector3 forceDirection = (hitInfo.point - Camera.main.transform.position).normalized;
                    rigidbody.AddForce(forceDirection * 500);
                }
            }
        }
    }
}
