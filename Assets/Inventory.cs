using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Image[] Images;
    public Sprite EmptySprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Food food))
        {
            SpriteRenderer foodSprite = food.GetComponent<SpriteRenderer>();

            foreach (var img in Images)
            {
                if (img.sprite == EmptySprite)
                {
                    img.sprite = foodSprite.sprite;
                    Destroy(collision.gameObject);
                    return;
                }
            }
        }
    }
}
