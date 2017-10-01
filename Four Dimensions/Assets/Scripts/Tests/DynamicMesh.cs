using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicMesh : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[4];
        Vector2[] uvs = new Vector2[4];
        int[] triangles = new int[6] {
            //LEFT HANDED RULE//
            0, 1, 2,
            2, 3, 0
        };
        vertices[0] = -Vector3.right + Vector3.up;
        vertices[1] = Vector3.right + Vector3.up;
        vertices[2] = Vector3.right - Vector3.up;
        vertices[3] = -Vector3.right - Vector3.up;

        uvs[0] = new Vector2(0, 1);
        uvs[1] = new Vector2(1, 1);
        uvs[2] = new Vector2(0, 0);
        uvs[3] = new Vector2(1, 0);

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;

        mesh.RecalculateNormals();

        GameObject newMeshObject = new GameObject();
        newMeshObject.AddComponent<MeshFilter>().mesh = mesh;
        newMeshObject.AddComponent<MeshRenderer>();


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
