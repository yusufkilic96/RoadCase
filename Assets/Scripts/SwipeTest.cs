using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{

    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        desiredPosition = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (swipeControls.SwipeLeft)
        {
            desiredPosition += Vector3.left*3;
        }
            
        if (swipeControls.SwipeRight)
        {
            desiredPosition += Vector3.right*3;
        }
            

        player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);
        
    }
}
