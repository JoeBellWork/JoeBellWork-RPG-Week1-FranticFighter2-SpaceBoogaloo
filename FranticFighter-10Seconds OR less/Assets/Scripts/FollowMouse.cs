using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float speed;
    private Vector3 posZ;

    private void Start()
    {
        posZ = transform.position;
    }






    void Update()
    {


        face();
    }









    void face()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = Vector3.Lerp(transform.position, mousePos, speed * Time.deltaTime); //floaty
        //transform.position = Vector3.MoveTowards(transform.position, mousePos, speed * Time.deltaTime); //not floaty

        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = direction;      
    }
}
