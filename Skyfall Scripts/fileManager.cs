using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fileManager : MonoBehaviour
{
    public GameObject[] tilePrefab;
    public Transform target;
    public Vector3 offset;
    private Transform playerTransform;
    private float spawnZ=-20.0f;
    private float tileLength =20f;
    private int amnTile=7;
    private float safeZone=30f;
    private int lastPrefabIndex=0;

    private List<GameObject> activeTiles;
    // Start is called before the first frame update
    void Start()
    {
        activeTiles=new List<GameObject>();
        playerTransform=target.transform;
        for(int i =0;i<amnTile;i++)
        {
            if (i<2)
            {
                SpawnTile(11);
            }
            else
            {
                SpawnTile();
            }
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z-safeZone>(spawnZ-amnTile*tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
        
    }
    void SpawnTile(int prefabIndex=-1)
    {
        GameObject go;
        if(prefabIndex==-1)
            go=Instantiate(tilePrefab[RandomPrefabIndex()]) as GameObject;
        else
        {
            go=Instantiate(tilePrefab[prefabIndex]) as GameObject;
        }    
        go.transform.SetParent(transform);
        go.transform.position=Vector3.forward*spawnZ+offset;
        spawnZ+=tileLength;
        activeTiles.Add(go);
    }
    void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
    private int RandomPrefabIndex()
    {
        if(tilePrefab.Length<=1)
            return 0;

        int randomIndex=lastPrefabIndex;
        while(randomIndex==lastPrefabIndex)
        {
            randomIndex=Random.Range(0,tilePrefab.Length);
        }
        lastPrefabIndex=randomIndex;
        return randomIndex;
    }
}
