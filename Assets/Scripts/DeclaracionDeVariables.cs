using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int studentQuantit; // Numeros enteros
    float tableLengthInMeters; // Numeros decimales
    string userAdress; // Lineas de texto
    bool agreeTermsAndConditions; // Verdadero / Falso

    // Start is called before the first frame update
    void Start()
    {
        studentQuantit = 28;
        tableLengthInMeters = 1.7f;
        userAdress = "Libertador 5670";
        agreeTermsAndConditions = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
