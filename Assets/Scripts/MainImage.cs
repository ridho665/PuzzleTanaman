using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainImage : MonoBehaviour
{
    [SerializeField] private GameObject imageUnknown;
    [SerializeField] private GameController gameController;

    public void OnMouseDown() 
    {
        if (imageUnknown.activeSelf && gameController.canOpen)
        {
            imageUnknown.SetActive(false);
            gameController.imageOpened(this);
        }    
    }

    public int _spriteId;

    public int spriteId
    {
        get { return _spriteId; }
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _spriteId = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Close()
    {
        imageUnknown.SetActive(true);
    }
}
