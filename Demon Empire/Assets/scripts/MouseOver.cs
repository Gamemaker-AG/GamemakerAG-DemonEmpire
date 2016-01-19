 using UnityEngine;
 using System.Collections;
 
 public class MouseOver : MonoBehaviour
 {
     Ray ray;
     RaycastHit hit;
    GameObject last;
     
     void Update()
     {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(last != null) {
            // last.GetComponent<Renderer>().material.color = Color.clear;
            last.GetComponent<MeshRenderer>().enabled = false;
        }
        if (Physics.Raycast(ray, out hit))
         {
            // hit.transform.position = new Vector3(hit.transform.position.x , hit.transform.position.y + 5, hit.transform.position.z);
            hit.transform.gameObject.GetComponent<MeshRenderer>().enabled = true;
            hit.transform.gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 1);
            last = hit.transform.gameObject;
         }
     }
 }