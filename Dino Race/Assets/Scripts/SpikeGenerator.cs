using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject Spike;

    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;
    public float SpeedMultiplier;

    void Start()
    {
        CurrentSpeed = MinSpeed;
        generateSpike();
    }

    public void GenerateNextSpikeWithGap()
    {
        float randomWait = Random.Range(0.7f, 1.9f);
        Invoke("generateSpike", randomWait);
    }

    void generateSpike()
    {
        GameObject SpikeIns = Instantiate(Spike, transform.position, transform.rotation);

        SpikeIns.GetComponent<SpikeScript>().SetSpikeGenerator(this);
        SpikeIns.GetComponent<SpikeScript>().Speed = CurrentSpeed;
    }

    void Update()
    {
        if (CurrentSpeed < MaxSpeed)
        {
            CurrentSpeed += SpeedMultiplier;
        }
    }
}
