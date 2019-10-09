using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public GameObject _player_game_object;
    private Random _mRandom;
    public float speed = 4.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("enter"))
        {
            Debug.Log("hello general kenobi");
          
        }

       

        if (Input.GetKey("up"))
        {
           
            transform.position += new Vector3( 0.0f,
                                    1* Time.deltaTime * speed, 0.0f);
        }

        if (Input.GetKey("down"))
        {

            transform.position += new Vector3(0.0f,
                                    -1 * Time.deltaTime * speed, 0.0f);
        }
        if (Input.GetKey("right"))
        {
           
            transform.position += new Vector3( 
                                    1* Time.deltaTime * speed, 0.0f, 0.0f);
        }

        if (Input.GetKey("left"))
        {

            transform.position += new Vector3(
                                    -1 * Time.deltaTime * speed, 0.0f, 0.0f);
        }
        
    }
}
