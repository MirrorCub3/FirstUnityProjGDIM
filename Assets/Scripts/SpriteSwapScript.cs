using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapScript : MonoBehaviour
{
    [SerializeField] private Sprite startSprite;
    [SerializeField] private Sprite changeSprite;
    public SpriteRenderer mySRender;
    public string detectTag;
    void Start()
    {
        mySRender = gameObject.GetComponent<SpriteRenderer>();
        mySRender.sprite = startSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(detectTag))
        {
            mySRender.sprite = changeSprite;
        }
    }
}
