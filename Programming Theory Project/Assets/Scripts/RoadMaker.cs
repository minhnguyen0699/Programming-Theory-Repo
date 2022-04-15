using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMaker : MonoBehaviour
{
    public Transform playerT;
    public GameObject blockPref;
    public float spawnz = 0f;
    private float blocklen = 54.60001f;
    private int nbrBlocksInScreen=50;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < nbrBlocksInScreen; i++)
        {
            SpawnBlocks();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (playerT.position.z > spawnz-(nbrBlocksInScreen * blocklen)) {
           SpawnBlocks(); 
        }
            
    }
     private void SpawnBlocks()
     {
        GameObject go = Instantiate(blockPref) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnz;
        spawnz += blocklen;
                                        
    }
}
