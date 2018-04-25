using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject cube;
    public GameObject guide;

	// Use this for initialization
	void Start () {
        updateCube();
	}
	
	// Update is called once per frame
	void Update () {
        moveGuide();
        if(Vector3.Distance(cube.transform.position,guide.transform.position) < .1f)
        {
            updateCube();
        }
        //updateCube();
	}

    private void moveGuide()
    {
        guide.transform.position = Vector3.MoveTowards(guide.transform.position, cube.transform.position, .1f);
    }

    private void updateCube()
    {
        Vector3 randomPos = new Vector3(Random.Range(-10f, 10f), Random.Range(0.5f, 10f), Random.Range(-10f, 10f));
        Quaternion rotation = new Quaternion(0f, 0f, 0f, 0f);
        cube.transform.SetPositionAndRotation(randomPos, rotation);
    }
}
