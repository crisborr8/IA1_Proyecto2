using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Vuforia;
using UnityEngine.Video;

public class VBTN_Quimica : MonoBehaviour
{
    public TMP_Text obj_texto;
    public GameObject main_menu;
    public GameObject self_menu;

    public AudioSource m1_clase1;
    public GameObject m2_clase1;
    public GameObject m1_clase2;
    public GameObject m2_clase2;
    public AudioSource m1_clase3;
    public GameObject m2_clase3;
    public GameObject m1_clase4;
    public GameObject m2_clase4;
    public GameObject m1_clase5;
    public GameObject m2_clase5;

    public VirtualButtonBehaviour clase1;
    public VirtualButtonBehaviour clase2;
    public VirtualButtonBehaviour clase3;
    public VirtualButtonBehaviour clase4;
    public VirtualButtonBehaviour clase5;
    public VirtualButtonBehaviour regresar;

    // Start is called before the first frame update
    void Start()
    {
        clase1.RegisterOnButtonPressed(VerClase1);
        clase2.RegisterOnButtonPressed(VerClase2);
        clase3.RegisterOnButtonPressed(VerClase3);
        clase4.RegisterOnButtonPressed(VerClase4);
        clase5.RegisterOnButtonPressed(VerClase5);
        regresar.RegisterOnButtonPressed(Regresar);
        obj_texto.text = "Ing. Química";
        HideAllMedia();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideAllMedia()
    {
        m1_clase1.Stop();
        m2_clase1.SetActive(false);
        m1_clase2.SetActive(false);
        m2_clase2.SetActive(false);
        m1_clase3.Stop();
        m2_clase3.SetActive(false);
        m1_clase4.SetActive(false);
        m2_clase4.SetActive(false);
        m1_clase5.SetActive(false);
        m2_clase5.SetActive(false);
    }

    public void VerClase1(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Química\nClase: Bioquimica\nEstudio de las reacciones químicas y procesos metabólicos que ocurren en los organismos vivos.";
        m1_clase1.Play();
        m2_clase1.SetActive(true);
    }

    public void VerClase2(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Química\nClase: Microbiologia\nEstudio de los microorganismos, su estructura, función, interacciones y su relación con la salud humana y el medio ambiente.";
        m1_clase2.SetActive(true);
        m2_clase2.SetActive(true);
    }

    public void VerClase3(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Química\nClase: Fisicoquimica\nEstudio de las propiedades físicas y químicas de la materia y sus interacciones en el nivel molecular.";
        m1_clase3.Play();
        m2_clase3.SetActive(true);
    }

    public void VerClase4(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Química\nClase: Calidad del agua\nAnálisis de la composición y características del agua para garantizar su aptitud y seguridad para el consumo humano.";
        m1_clase4.SetActive(true);
        m2_clase4.SetActive(true);
    }

    public void VerClase5(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Química\nClase: Ingenieria del azucar\nEstudio de los procesos industriales para la producción, transformación y refinamiento del azúcar y sus derivados.";
        m1_clase5.SetActive(true);
        m2_clase5.SetActive(true);
    }

    public void Regresar(VirtualButtonBehaviour vb)
    {
        main_menu.SetActive(true);
        self_menu.SetActive(false);
    }
}
