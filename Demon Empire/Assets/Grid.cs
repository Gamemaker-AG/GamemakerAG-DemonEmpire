using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {
	
	public GameObject plane;
	public int width;
	public int height;

	private GameObject [,] grid = new GameObject[10,10];
	
	void Awake ()
	{
		
		width = 10;
		height = 10;
		
		for(int x = 0; x < width; x++) {
			for(int z = 0; z < height; z++){
				GameObject gridPlane = (GameObject) Instantiate(plane);
				gridPlane.transform.position = new Vector3(gridPlane.transform.position.x + x,
					gridPlane.transform.position.y, gridPlane.transform.position.z +z);
					grid[x,z] = gridPlane;
			}
		}
	}
}
