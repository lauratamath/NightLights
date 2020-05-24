using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Labels : MonoBehaviour
{
    public Image imagen;
    public Text label;

    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;
        Ray forwardSign = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(forwardSign, out hit, 3) && !hit.collider.CompareTag("Untagged"))
        {
            if (imagen) imagen.enabled = true;
            if (label)
            {
                label.enabled = true;
                label.text = hit.collider.tag;
            }

        }
        else
        {

            if (imagen) imagen.enabled = false;
            if (label) label.enabled = false;
        }
    }
}