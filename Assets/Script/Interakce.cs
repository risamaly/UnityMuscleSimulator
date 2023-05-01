using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interakce : MonoBehaviour
{
    public float detectionDistance = 2f;
    public LayerMask interactableLayer;
    public Text interactText; // pøidejte Text komponentu z UI do této promìnné
    

    private GameObject detectedObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, detectionDistance, interactableLayer))
        {
            detectedObject = hit.collider.gameObject;
            interactText.text = "Press E to interact";
        }
        else
        {
            detectedObject = null;
            interactText.text = "E";
        }

        if (Input.GetKeyDown(KeyCode.E) && detectedObject != null)
        {
            // Zmìna scény nebo spuštìní funkce interakce
        }
        if (Physics.Raycast(ray, out hit, detectionDistance, interactableLayer))
        {
            detectedObject = hit.collider.gameObject;
            // Kód pro zobrazení indikace interakce
        }
    }
    void Interact()
    {
        if (detectedObject != null)
        {
            // Kód pro interakci s objektem
        }
    }

}
