using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private KeepScore scoreScript;

    private void Start()
    {
        scoreScript = FindObjectOfType<KeepScore>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBlu")
        {
            Destroy(gameObject, 0.5f);
            scoreScript.AddScore(1);
        }
    }
}