using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    // Start is called before the first frame update
    void Start()
    {
        ChangeSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}