using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControl : MonoBehaviour
{
    private PlayerController pControl;
    private Vector2 startTouchPos, endTouchPos;
    // Start is called before the first frame update
    void Start()
    {
        pControl = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPos = Input.GetTouch(0).position;
        }
        if(Input.touchCount >0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
           
            endTouchPos = Input.GetTouch(0).position;
            float yDistance = Mathf.Abs(endTouchPos.y - startTouchPos.y);
            float xDistance = Mathf.Abs(endTouchPos.x - startTouchPos.x);
            Debug.Log(("Touch Position: {0}, {1}", startTouchPos, endTouchPos));
            Debug.Log(("Touch Distances: {0}, {1}", Mathf.Abs(endTouchPos.x - startTouchPos.x), Mathf.Abs(endTouchPos.y - startTouchPos.y)));
            if (xDistance > yDistance)
            {
                if (endTouchPos.x < startTouchPos.x)
                {
                    pControl.setNextDir(-Vector2.right);
                }
                if (endTouchPos.x > startTouchPos.x)
                {
                    pControl.setNextDir(Vector2.right);
                }
            }
            if (xDistance < yDistance)
            {
                if (endTouchPos.y < startTouchPos.y)
                {
                    pControl.setNextDir(-Vector2.up);
                }
                if (endTouchPos.y > startTouchPos.y)
                {
                    pControl.setNextDir(Vector2.up);
                }
            }
        }
    }
}
