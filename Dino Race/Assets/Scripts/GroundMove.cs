using UnityEngine;
using UnityEngine.Serialization;

public class GroundMove : MonoBehaviour
{
    public SpikeGenerator spikeGenerator;

    private float _startPosition;
    private float _spriteWidth;

    void Start()
    {
        _startPosition = transform.position.x;
        _spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float movementDistance = spikeGenerator.CurrentSpeed * Time.deltaTime;
        var position = transform.position;
        float newPosition = Mathf.Repeat(position.x - movementDistance, _spriteWidth);
        
        position = new Vector2(_startPosition + newPosition, position.y);
        transform.position = position;
    }
}