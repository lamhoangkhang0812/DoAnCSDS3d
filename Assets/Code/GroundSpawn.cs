using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public static GroundSpawn Instance ;
    private Vector3 nextSpawnPoint;
    public GameObject groundTile;

    private void Awake ()
    {
        if (Instance==null)
        {
            Instance = this ; 
        
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        for (int i=0 ; i<40 ; i++)
        {
            SpawnTile();
        }
    }
    public void SpawnTile() 
    {
        GameObject temp = Instantiate(groundTile,nextSpawnPoint,Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).position;
    }
    
}
