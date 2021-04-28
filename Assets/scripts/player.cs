using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed; // Скорость движения, а в дальнейшем ускорение
    [SerializeField] private Vector3 _direction; // Направление движения
    public GameObject _player;
    public int speed = 5;
    public int speedRotation = 3;
   
    public int jumpSpeed = 50;

    void Start()
    {

        _player = (GameObject)this.gameObject;
        

        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _player.transform.position += _player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _player.transform.position -= _player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) )
        {
            _player.transform.Rotate(Vector3.down * speedRotation);
        }
        if (Input.GetKey(KeyCode.D) )
        {
            _player.transform.Rotate(Vector3.up * speedRotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _player.transform.position += _player.transform.up * jumpSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _player.transform.position += _player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _player.transform.position -= _player.transform.right * speed * Time.deltaTime;
        }
    }
}
