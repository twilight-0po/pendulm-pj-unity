using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class measure : MonoBehaviour
{
    Rigidbody2D rigid;
    float min_velocity;
    float speed;
    int stop;
    float currentTime;
    bool srt;
    float val;
    float max_speed;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(10, 0); //¹Ì´Â Èû ¼³Á¤
        stop = 0;
        currentTime = 0;
        max_speed = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        speed = rigid.velocity.magnitude;
        if (speed >= max_speed)
        {
            max_speed = speed;
        }
        if (speed <= 0.1 && stop == 0)
        {
            srt = false;
            stop = stop + 1;
            currentTime = Time.time - currentTime;
            Debug.Log(transform.position);
            Debug.Log("it took " + val + "seconds");
            Debug.Log("the max speed is " + max_speed);

        }
        else if (speed > 0.1)
        {
            stop = 0;
            srt = true;
        }
        if (srt)

        {
            val += Time.deltaTime;
        }
        else
        {
            val = 0;
        }
    }
}
