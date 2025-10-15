using UnityEngine;

public class UpdateVsFixedUpdate : MonoBehaviour
{
    // Exercice 1.1 observez l'ordre d'appel d'Update, de LateUpdate et de FixedUpdate, en fonction de différents framerates
    void Start()
    {
        //QualitySettings.vSyncCount = 0;


        //Force le nombre de FPS à 60

        // Test 1
        // Application.targetFrameRate = 120;


        // Test 2
        // Application.targetFrameRate = 24;
    }

    void Update()
    {
        Debug.Log("Update");
    }

    void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
}
