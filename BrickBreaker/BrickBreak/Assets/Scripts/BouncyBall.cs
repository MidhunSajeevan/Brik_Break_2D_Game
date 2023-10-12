                                                                                                                                                                                                                  
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BouncyBall : MonoBehaviour
{
    public float minY = -5f;
    public Rigidbody2D rb;
    public float MaxxVelocity = 15f;
    private int score = 0;
    private int life = 5;
    public Text scoretext;
    public GameObject[] liveimage;
    public GameObject GameOverPannel;
    public GameObject GameWinPannel;
    public GameObject WinnerPannel;
    public float speed;
    public GameObject points;
    public GameObject Explossion;
    public GameObject player;
    

    private void Start()
    {
        rb.velocity = Vector2.down * speed;
       
    }

    
    void Update()
    {
        
        if (score == 800)
        {
            WinnerPannel.SetActive(true);
            Destroy(gameObject);
            player.SetActive(false);
          
        }
        if (life == 0)
        {
            GameOver();

        } else if (transform.position.y < minY)
        {
            transform.position = new Vector3(0, 3, 0);
            rb.velocity = Vector2.down * speed;
            life--;
            liveimage[life].SetActive(false);
        }
        if (rb.velocity.magnitude > MaxxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxxVelocity);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            GameObject.FindObjectOfType<AudioSource>().Play();
            Instantiate(Explossion, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            score += 10;
            scoretext.text = score.ToString("00000");
            
        }
    }
        public void GameOver()
        {


            GameOverPannel.SetActive(true);
            GameWinPannel.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
            if (score > 0 && score <= 310)
            {
               
                GameObject child1 = points.transform.GetChild(0).gameObject;
                child1.SetActive(true);
            }
            else if (score > 310 && score <= 620)
            {
                GameObject child1 = points.transform.GetChild(0).gameObject;
                child1.SetActive(true);
                GameObject child2 = points.transform.GetChild(1).gameObject;
                child2.SetActive(true);
            }
            else
            {
                GameObject child1 = points.transform.GetChild(0).gameObject;
                child1.SetActive(true);
                GameObject child2 = points.transform.GetChild(1).gameObject;
                child2.SetActive(true);
                GameObject child3 = points.transform.GetChild(2).gameObject;
                child3.SetActive(true);
            }


        }
    }


