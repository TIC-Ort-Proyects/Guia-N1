using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeriaLosTresGustos : MonoBehaviour
{
    // 1. Declarar variables
    public string codigoGusto;
    public int gramosHelado;

    float precioPorMilGramos = 500;
    float precioTotal;
    float porcentajeDescuento;

    // Start is called before the first frame update
    void Start()
    {
        // 2. Ingreso y validacion de datos
        if (gramosHelado < 250 || gramosHelado > 3000)
        {
            Debug.Log("Cantidad de helado no valida");
            return;
        }

        if (codigoGusto == "CHO" || codigoGusto == "DDL")
        {
            porcentajeDescuento = 0;

        } else if (codigoGusto == "FRU")
        {
            porcentajeDescuento = 10;
        } else
        {
            Debug.Log("Codigo de gusto no valido");
            return;
        }

        // 3. Processamiento de datos
        precioTotal = gramosHelado * (precioPorMilGramos / 1000) * (1 - porcentajeDescuento / 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
