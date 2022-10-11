using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    private ObjectPool<Cube> cubePool;

    [SerializeField] private Transform spawnPoint;

    public static float SpawnTime = 1;
    public static float CubeSpeed = 5;
    public static float CubeHideDistance = 10;

    void Start()
    {
        cubePool = new ObjectPool<Cube>(cubePrefab, 5);

        StartCoroutine(SpawnCube());
    }

    private IEnumerator SpawnCube()
    {
        Cube cube = cubePool.GetObject();

        cube.SetToStartPosition(spawnPoint.position);
        
        cube.Speed = CubeSpeed;
        cube.HideDistance = CubeHideDistance;

        yield return new WaitForSeconds(SpawnTime);

        StartCoroutine(SpawnCube());
    }

    public void OnSpawnTimeChanged()
    {
        StopAllCoroutines();
        StartCoroutine(SpawnCube());
    }
}
