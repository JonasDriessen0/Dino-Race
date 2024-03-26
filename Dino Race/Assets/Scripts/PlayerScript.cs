using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float JumpForce;
    public float HP;
    public float HPincrease;
    public float maxHP;
    public AudioClip clip;
    public AudioSource source;

    public CameraShake cameraShake;

    public GameObject redWinTextObject; // Reference to the UI Text object

    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded == true)
            {
                RB.AddForce(Vector2.up * JumpForce);
                source.Play();
                isGrounded = false;
            }
        }

        if (isAlive == true && HP < maxHP)
        {
            HP += HPincrease * Time.deltaTime;
            redWinTextObject.SetActive(false);
        }

        if (isAlive == false)
        {
            Debug.Log("Red Dino Wins");
            redWinTextObject.SetActive(true); // Show the UI Text object
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if (collision.gameObject.CompareTag("spike"))
        {
            HP -= 1;
            cameraShake.Shake();
            if (HP < 0)
            {
                isAlive = false;
            }
        }

        if (collision.gameObject.CompareTag("FootballPowah"))
        {
            Debug.Log("Kick");
        }
    }
}