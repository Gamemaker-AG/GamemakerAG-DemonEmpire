using UnityEngine;
using UnityEditor;
using System.Collections;

public class CameraController : MonoBehaviour {

public float camAngle = 20;
public float scrollDistance = 5;
public float scrollSpeed = 40;

 // Use this for initialization
 void Start () {
 
 }
 
 // Update is called once per frame
 void Update () {
 
	 float correct = Mathf.Sin(camAngle) * 5;
     float mousePosX = Input.mousePosition.x; 
     float mousePosY = Input.mousePosition.y; 
     if (mousePosX < scrollDistance && this.transform.position.x > 0) //linker Rand 
             { 
                 transform.Translate(Vector3.right * -scrollSpeed * Time.deltaTime); 
             } 
             
     if (mousePosX >= Screen.width - scrollDistance && this.transform.position.x < 500) 
             { 
                 transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime); 
             }
     
     if (mousePosY < scrollDistance && this.transform.position.z > 0) 
             { 
                 transform.Translate(Vector3.forward * -scrollSpeed * Time.deltaTime, Space.World); 
             } 
             
     if (mousePosY >= Screen.height - scrollDistance && this.transform.position.z < 500) 
             { 
                 transform.Translate(Vector3.forward * scrollSpeed * Time.deltaTime, Space.World);
             }
     }
}