using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {
	
	public GameObject plane;
	public int width;
	public int height;

	private GameObject [,] grid = new GameObject[50, 50];
	
	void Awake ()
	{
		
		//width = 10;
		//height = 10;
		
		for(int x = 0; x < width; x++) {
			for(int z = 0; z < height; z++){
				GameObject gridPlane = (GameObject) Instantiate(plane);
				gridPlane.transform.position = new Vector3(gridPlane.transform.position.x + (10 * x),
					gridPlane.transform.position.y, gridPlane.transform.position.z + (10 * z));
					grid[x,z] = gridPlane;
					//grid[x,z] = null;
			}
		}
	}
}
//grid[15,27] = actualObject;