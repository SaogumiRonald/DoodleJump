using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private GameObject _deadZone;
    [SerializeField] private int _numberOfPlatforms;
    [SerializeField] private float _minX;
	[SerializeField] private float _maxX;
    [SerializeField] private float _minY;
	[SerializeField] private float _maxY;

    void Start() {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < _numberOfPlatforms; i++) {
            SpawnerPosition.x = UnityEngine.Random.Range(_minX, _maxX);
            SpawnerPosition.y += UnityEngine.Random.Range(_minY, _maxY);

            Instantiate(_platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }
}
