using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // Kód, který se provede, pokud dojde k srážce
        }
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Srážka s objektem na pozici: " + hit.point);
        }

    }
}
