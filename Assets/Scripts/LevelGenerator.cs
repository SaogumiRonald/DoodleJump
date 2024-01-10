
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    public GameObject platformPrefab;
    public GameObject movingPlatformPrefab;
    //public GameObject breakingPlatformPrefab;
    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = 0.2f;
    public float maxY = 1.5f;

     void Start() {
    Vector3 spawnerPosition = new Vector3();

    for (int i = 0; i < numberOfPlatforms; i++){
        spawnerPosition.x = UnityEngine.Random.Range(-levelWidth, levelWidth);
        spawnerPosition.y += UnityEngine.Random.Range(minY, maxY);

        GameObject platformToInstantiate;

        if (Random.Range(0, 2) == 0){
            platformToInstantiate = platformPrefab;
        }
        else {
            platformToInstantiate = movingPlatformPrefab;
        }

        Instantiate(platformToInstantiate, spawnerPosition, Quaternion.identity);
    }
}
}