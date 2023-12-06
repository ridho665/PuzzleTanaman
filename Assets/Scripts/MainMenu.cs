using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    public void MengenalKata()
    {
        SceneManager.LoadScene("MengenalKata");
    }

    public void Informasi()
    {
        SceneManager.LoadScene("Informasi");
    }

    public void Permainan()
    {
        SceneManager.LoadScene("Permainan");
    }

    public void Keluar()
    {
        Application.Quit();
    }

    public void Petunjuk()
    {
        SceneManager.LoadScene("Petunjuk");
    }

    public void Deskripsi()
    {
        SceneManager.LoadScene("Deskripsi");
    }

    public void Profil()
    {
        SceneManager.LoadScene("Profil");
    }

    public void KataKembar()
    {
        SceneManager.LoadScene("KataKembar");
    }
    public void FinishKataKembar()
    {
        SceneManager.LoadScene("FinishKataKembar");
    }

    public void MewarnaiKata()
    {
        SceneManager.LoadScene("MewarnaiKata");
    }

    public void BowlingKata()
    {
        SceneManager.LoadScene("BowlingKata");
    }  

    public void Berbelanja()
    {
        SceneManager.LoadScene("Berbelanja");
    }

    public void PuzzleKata()
    {
        SceneManager.LoadScene("PuzzleKata");
    }

    
      
}
