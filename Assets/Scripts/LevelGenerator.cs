using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
	public GameObject platformPrefab;
	public int numberOfPlatforms = 200;
	public float levelWidth = 3f;
	public float minY = 0.2f;
	public float maxY = 1.5f;

    void Start() {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 10; i++) {
            SpawnerPosition.x = UnityEngine.Random.Range(-1.5f, 1.5f);
            SpawnerPosition.y += UnityEngine.Random.Range(1.5f, 1.5f);

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }
}
