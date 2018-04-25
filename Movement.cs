using UnityEngine;

public class Movement : MonoBehaviour {

    public GameObject[] spheres;
    public GameObject cube;
	
	// Update is called once per frame
	void Update () {
        mov();
    }

   private void mov()
    {
        for (int i = 0; i < spheres.Length; i++)
        {
            for (int j = 0; j < spheres.Length; j++)
            {
                if (Vector3.Distance(spheres[i].transform.position, spheres[j].transform.position) < 1f)
                {
                    
                }else{
                    spheres[i].transform.position = Vector3.MoveTowards(spheres[i].transform.position, cube.transform.position, (float).1);
                }
            }
        }
    }
}

