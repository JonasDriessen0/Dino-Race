using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveNoSpikes : MonoBehaviour
{
    public float scrollSpeed = 1f;
    private float _startPosition;
    private float _spriteWidth;

    void Start()
    {
        _startPosition = transform.position.x;
        _spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void LateUpdate()
    {
        float movementDistance = scrollSpeed * Time.deltaTime;
        var position = transform.position;
        float newPosition = Mathf.Repeat(position.x - movementDistance, _spriteWidth);
        
        position = new Vector2(_startPosition + newPosition, position.y);
        transform.position = position;
    }
}