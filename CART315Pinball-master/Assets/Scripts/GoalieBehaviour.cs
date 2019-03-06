using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalieBehaviour : MonoBehaviour
{
    private float direction = 0f;
    private bool swtichDirection = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -0.9f, direction);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(0, -0.9f, direction);
        if (!swtichDirection)
        {
            direction += 0.01f;
        }
        else
        {
            direction -= 0.01f;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Trigger");
        if(collision.gameObject.tag == "GoalPostLeft")
        {
            swtichDirection = true;
        }
        if (collision.gameObject.tag == "GoalPostRight")
        {
            swtichDirection = false;
        }
    }
}
