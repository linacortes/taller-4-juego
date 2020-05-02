using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Borrar : MonoBehaviour
{
    //  private string urlBorrar = "/http://tadeolabhack.com:8081/test/EjercicioLinaPhp/BorrarDatos.php?in=BorrarDatosUsuario&userID=1";
    private string UrlBorrar = "http://localhost/EjercicioLinaPhp/BorrarDatos.php?";

    public int IDuser = 300;
    public void borrarTodo()
    {
        StartCoroutine(borrarT());

    }

    private IEnumerator borrarT()

    {
        WWWForm form = new WWWForm();
        form.AddField("in", "BorrarTodo");
        form.AddField("userID", 0);

        WWW retroalimentacion = new WWW(UrlBorrar, form);
        yield return retroalimentacion;

        print(retroalimentacion.text);



    }

    public void borrarUsuario()
    {
        StartCoroutine(borrarU());
    }


    private IEnumerator borrarU()

    {
        WWWForm form = new WWWForm();
        form.AddField("in", "BorrarUsuario");
        form.AddField("userID", IDuser);



        WWW retroalimentacion = new WWW(UrlBorrar, form);
        yield return retroalimentacion;

        print(retroalimentacion.text);


    }

    public void borrarDatosUsuario()
    {
        StartCoroutine(borrarDU());
    }


    private IEnumerator borrarDU()

    {
        WWWForm form = new WWWForm();
        form.AddField("in", "BorrarDatosUsuario");
        form.AddField("userID", IDuser);



        WWW retroalimentacion = new WWW(UrlBorrar, form);
        yield return retroalimentacion;

        print(retroalimentacion.text);


    }

}
