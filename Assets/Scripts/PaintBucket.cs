using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBucket : MonoBehaviour
{
    public Color[] colorList;
    public Color curColor;
    public int colorCount;

    public GameObject LECI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curColor = colorList[colorCount];

        var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, -Vector2.up);

        if(Input.GetButton("Fire1"))
        {
            if(hit.collider != null)
            {
                SpriteRenderer sp = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                Debug.Log(hit.collider.name);
                
                sp.color = curColor;
            }
        }
    }

    public void Paint(int colorCode)
    {
        colorCount = colorCode;
    }

    public void Lanjut()
    {
        
    }
}
