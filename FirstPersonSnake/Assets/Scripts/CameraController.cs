using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    


    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("right"))
        {
            transform.Rotate(0, 90, 0);
        }
        else if (Input.GetKeyDown("left"))
        {
            transform.Rotate(0, -90, 0);
        }
        transform.position = player.transform.position + offset;
        
    }
}

