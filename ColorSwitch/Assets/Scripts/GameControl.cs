using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public GameObject Changer;
    public GameObject Circle;

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Changer"))
        {

            float yValue = other.transform.position.y;

            yValue += 5f;

            Vector3 newPlaceSmallCircle = new Vector3(0f, yValue,0f);

            Instantiate(Circle, newPlaceSmallCircle, Quaternion.identity);

            yValue += 5f;

            Vector3 newPlaceChanger = new Vector3(0f, yValue, 0f);

            Instantiate(Changer, newPlaceChanger, Quaternion.identity);
        }
        
    }
}
