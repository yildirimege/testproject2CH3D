using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    private Vector3 moveDirection;
    private Vector3 startPos;

    private Vector3 direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       Vector3 mousePos = Input.mousePosition;
        if(Input.GetMouseButtonDown(0)) {

           startPos = mousePos;
        }
        else if (Input.GetMouseButton(0))
        {
          
            moveDirection = (mousePos - startPos).normalized;
            var direction = new Vector3(moveDirection.x, 0, moveDirection.y);
            gameObject.transform.position += direction * speed * Time.deltaTime;




        }
        


    }
}
