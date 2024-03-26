using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    private SpikeGenerator spikeGenerator;
    internal float Speed;

    // Assign the SpikeGenerator reference through the inspector
    public void SetSpikeGenerator(SpikeGenerator generator)
    {
        spikeGenerator = generator;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * (spikeGenerator.CurrentSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            spikeGenerator.GenerateNextSpikeWithGap();
            Debug.Log("GenerateSpike");
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}