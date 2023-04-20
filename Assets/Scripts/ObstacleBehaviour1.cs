using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour1 : MonoBehaviour
{
    CubeAgent agent;
    // Start is called before the first frame update
    void Awake()
    {
        agent = GameObject.Find("Agent").GetComponent<CubeAgent>();
    }

    public float speed;
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.localPosition -= new Vector3(speed,0,0);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag=="Agent")
        {
            print("bbbb");
            agent.Hit();
        }
        if (collision.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}