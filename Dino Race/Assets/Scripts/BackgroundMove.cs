using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float scrollSpeed = 1f;
    public SpikeGenerator spikeGenerator;
    private float _startPosition;
    private float _spriteWidth;

    void Start()
    {
        _startPosition = transform.position.x;
        _spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void LateUpdate()
    {
        float movementDistance = spikeGenerator.CurrentSpeed * scrollSpeed * 0.35f * Time.deltaTime;
        var position = transform.position;
        float newPosition = Mathf.Repeat(position.x - movementDistance, _spriteWidth);
        
        position = new Vector2(_startPosition + newPosition, position.y);
        transform.position = position;
    }
}