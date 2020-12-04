using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//klasa samochod {kolor, ilosc kol,..}
//obiekt Audi A4 {niebieski, 4...}
public class TextGame : MonoBehaviour
{

    int min = 1;
    int max = 1000;
    int guess = (1 + 1000) / 2;

    void Start()
    {
        //komunikat powitalny dla gracza
        //instrukcja co uzytkownik am zrobic
        
        Debug.Log ("Witaj w numerkowym czarodzieju");
        Debug.Log("Wybierz liczbe calkowita z zakresu od 1 do 1000");
        Debug.Log("Czy twoja liczba jest wieksza, mniejsza od " + guess + " Czy taka sama?");
        Debug.Log("Aby odpowiedziec na pytanie nacisnij: Gorna strzlka = wieksza, Dolna strzalka = mniejsza, Enter = Taka sama ");

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = (min = guess);
            guess = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest wieksza czy mniejsza od: " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = (max = guess);
            guess = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest wieksza czy mniejsza od: " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Twoja liczba to: " + guess);
        }
    }
}
