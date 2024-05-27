using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOGINMANAGER : MonoBehaviour
{
    public InputField inputpassword;


    //Cuando el usuario presione el bot+on "aceptar"
    //debe escribirse un mensaje en Consola
    //si el texto del InputPassword coincide
    //con una contraseña predefinida por ustedes
    //escrbir "Access granted", sino escribir "Acces denied"
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Inputpassword()
    {
        if ( inputpassword.text ==  "Manito1443")
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }

        }
    }

