using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mineSpawner : MonoBehaviour

{
    [SerializeField] private GameObject _mine; // Наша мина
    [SerializeField] private Transform _mineSpawnPlace; // точка, где создается
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(_mine, _mineSpawnPlace.position, _mineSpawnPlace.rotation);
          
            // Создаем _mine в точке _mineSpawnPlace

        }
       
    }
}
