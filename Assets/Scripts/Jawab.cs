using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jawab : MonoBehaviour
{
    public GameObject feedBenar, feedSalah;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    public void Jawaban(bool jawab)
    {
        if(jawab)
        {
            feedBenar.SetActive(false);
            feedBenar.SetActive(true);
            int skor = PlayerPrefs.GetInt ("skor") + 1;
            PlayerPrefs.SetInt ("skor", skor);
        }
        else
        {
            feedSalah.SetActive(false);
            feedSalah.SetActive(true);
        }
        gameObject.SetActive (false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex()+1).gameObject.SetActive (true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
