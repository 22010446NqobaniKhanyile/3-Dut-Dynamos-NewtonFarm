
using UnityEngine;
//using TMPro;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5;
    public float JumpSp = 7;
    private float direction = 0f;
    private Rigidbody2D square;
    public bool isGrounded;
    public int score;
  //  public TMP_Text scoreDisplay;
    public Text scorDisplay;
    public Text HighScore;
    public Text DeathScore;
    void Start()
    {
        square = GetComponent<Rigidbody2D>();
        HighScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();

    }
    void OnCollisionStay2D()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        //This is movements
        direction = Input.GetAxis("Horizontal");

        if (direction > 0f)
        {
            square.velocity = new Vector2(direction * speed, square.velocity.y);
        }
        else if(direction< 0f)
        {
            square.velocity = new Vector2(direction* speed, square.velocity.y);
        }
        else
        {
            square.velocity = new Vector2(0, square.velocity.y);

        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            square.velocity = new Vector2(square.velocity.x,JumpSp);
            isGrounded = false;
        }

    }
        
    public void AddScore()
    {
            score = score +10;
            scorDisplay.text = score.ToString("0");
            DeathScore.text = score.ToString("0");
        //scoreDisplay.text = "Score: " + score;   
    }
    public void FinalHighScore()
    {
     //   HighScore.text = score.ToString();

        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            HighScore.text = score.ToString();
        }
    }

}
