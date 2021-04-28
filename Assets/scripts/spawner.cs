using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _spawnerSpawnPlace;
    public GameObject _enemy;
   
    public float TimeSpawn;
    void Start()

    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    // Update is called once per frame
    void Repeat()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(_enemy, _spawnerSpawnPlace.position, Quaternion.identity);
        Repeat();
    }
}
