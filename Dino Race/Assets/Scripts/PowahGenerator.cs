using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowahGenerator : MonoBehaviour
{
    public GameObject Powah;

    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;

    public float SpeedMultiplier;
    // Start is called before the first frame update
    void Awake()
    {
        CurrentSpeed = MinSpeed;
        generatePowah();
    }

    public void GenerateNextPowahWithGap()
    {
        float randomWait = Random.Range(15.8f, 17.9f);
        Invoke("generatePowah", randomWait);
    }

    void generatePowah()
    {
        GameObject PowahIns = Instantiate(Powah, transform.position, transform.rotation);

        PowahIns.GetComponent<Football>().powahGenerator = this;
        PowahIns.GetComponent<Football>().Speed = CurrentSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentSpeed < MaxSpeed)
        {
            CurrentSpeed += SpeedMultiplier;
        }
    }
}
