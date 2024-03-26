using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football : MonoBehaviour
{

    public PowahGenerator powahGenerator;
    internal float Speed;

    // Update is called once per frame
    void Update()
    {
        powahGenerator.transform.Translate(Vector3.left * powahGenerator.CurrentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            powahGenerator.GenerateNextPowahWithGap();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}