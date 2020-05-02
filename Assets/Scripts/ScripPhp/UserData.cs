using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
  // private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/EjercicioLinaPhp/escribir.php?";
    private string getUrlEscribir = "http://localhost/EjercicioLinaPhp/escribir.php";
    public int IDuser = 300;
    private string nombre = "";
    private int edad = 0;
    private string sexo ="";

    public InputField campoNombre;
    public InputField campoEdad;
    public InputField campoSexo;
    
    //[SerializeField]
    public void SenData()
    {
        StartCoroutine(enviarDatosUsuario());
        

    }
    public IEnumerator enviarDatosUsuario()
    {
        nombre = campoNombre.text;
        sexo = campoSexo.text;

        if (campoEdad.text !="")
        {
            edad = int.Parse(campoEdad.text);
        }
        else
        {
            print("el campo de edad no puede estar vacio ");
        }

        print(IDuser + "" + nombre + "" + edad + sexo + "");

        if (nombre ==""|| edad==0 || sexo=="")
        {
            print("los campos de nombre, sedad y sexo deben tener informacion");
        }
        else 
        {
            WWWForm form = new WWWForm();
            form.AddField("id", IDuser);
            form.AddField("no", nombre);
            form.AddField("ed", edad);
            form.AddField("se", sexo);

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;

            print(retroalimentacion.text);


        }





    }

}
