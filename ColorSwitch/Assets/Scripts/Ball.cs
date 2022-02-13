using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour
{

    private Rigidbody2D ballRigidbody;
    public float upForce;
    public Material ballMaterial;
    public Color morColor;
    private bool Create;
    public GameObject pressToPlay;
    public Text ScoreText;
    private int score = 0;
    private int counter = 0;
    public GameObject playAgainButton;

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        ballMaterial.color = Color.white;
        Create = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) )
        {   
            pressToPlay.SetActive(false);
            ballRigidbody.bodyType = RigidbodyType2D.Dynamic;
            ballRigidbody.velocity=Vector2.up*upForce;
            if (Create)
            {
                CreateBallColor();
                Create = false;
            }
           

           
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        

        if (other.CompareTag("Changer"))
        {
            CreateBallColor();
            Destroy(other.gameObject);
        }else if (other.tag==gameObject.tag)
        {
            
            counter++;

         

            if (counter==2)
            {
                score++;
                ScoreText.text = score.ToString();
                counter = 0;
            }

        }
        else
        {
            playAgainButton.SetActive(true);
            gameObject.SetActive(false);
            
        }

      
    }

   

    void CreateBallColor()
    {

        int choosedColor = Random.Range(1,5);


        switch (choosedColor)
        {
            case 1:
                ballMaterial.color = Color.cyan;
                gameObject.tag = "Cyan";
                break;
            case 2:
                ballMaterial.color = Color.magenta;
                gameObject.tag = "Pink";
                break;
            case 3:
                ballMaterial.color = Color.yellow;
                gameObject.tag = "Yellow";
                break;
            case 4:
                ballMaterial.color = morColor;
                gameObject.tag = "Magenta";
                break;
        }


    }


   public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}