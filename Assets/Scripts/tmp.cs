using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tmp : MonoBehaviour {

    private MeshRenderer _mesh;
    private Collider _col;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        //if (FindObjectsOfType(GetType()).Length > 1)
        //{
        //    Destroy(gameObject);
        //}
        _mesh = GetComponent<MeshRenderer>();
        _mesh.enabled = false;
        //renderer.enabled = false
    }
    // Use this for initialization
    void Start () {
        _col = GetComponent<Collider>();
        _col.gameObject.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
