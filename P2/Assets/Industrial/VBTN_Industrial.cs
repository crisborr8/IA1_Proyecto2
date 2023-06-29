using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Vuforia;
using UnityEngine.Video;

public class VBTN_Industrial : MonoBehaviour
{
    public TMP_Text obj_texto;
    public GameObject main_menu;
    public GameObject self_menu;

    public GameObject m1_clase1;
    public GameObject m2_clase1;
    public GameObject m1_clase2;
    public GameObject m2_clase2;
    public GameObject m1_clase3;
    public GameObject m2_clase3;
    public GameObject m1_clase4;
    public GameObject m2_clase4;
    public GameObject m1_clase5;
    public GameObject m2_clase5;

    public AudioSource musica;

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
        obj_texto.text = "Ing. Industrial";
        HideAllMedia();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideAllMedia()
    {
        m1_clase1.SetActive(false);
        m2_clase1.SetActive(false);
        m1_clase2.SetActive(false);
        m2_clase2.SetActive(false);
        m1_clase3.SetActive(false);
        m2_clase3.SetActive(false);
        m1_clase4.SetActive(false);
        m2_clase4.SetActive(false);
        m1_clase5.SetActive(false);
        m2_clase5.SetActive(false);
        musica.Stop();
    }

    public void VerClase1(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Industrial\nClase: Comercio internacional\nSe estudian las operaciones y estrategias relacionadas con el intercambio de bienes y servicios entre países.";
        m1_clase1.SetActive(true);
        m2_clase1.SetActive(true);
    }

    public void VerClase2(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Industrial\nClase: Plantas a vapor\nSe estudia el funcionamiento y diseño de sistemas que utilizan vapor como fuente de energía.";
        m1_clase2.SetActive(true);
        m2_clase2.SetActive(true);
    }

    public void VerClase3(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Industrial\nClase: Microeconomia\nSe estudian las decisiones individuales de consumo y producción, así como la asignación eficiente de recursos.";
        m1_clase3.SetActive(true);
        m2_clase3.SetActive(true);
    }

    public void VerClase4(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Industrial\nClase: Ingeniería de plantas\nSe estudian los procesos y principios de diseño para la construcción y operación de instalaciones industriales.";
        m1_clase4.SetActive(true);
        m2_clase4.SetActive(true);
    }

    public void VerClase5(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Industrial\nClase: Montaje y mantenimiento de equipo\nSe estudian las técnicas y procedimientos para la instalación y cuidado adecuado de maquinaria y equipos industriales.";
        m1_clase5.SetActive(true);
        m2_clase5.SetActive(true);
        musica.Play();
    }

    public void Regresar(VirtualButtonBehaviour vb)
    {
        main_menu.SetActive(true);
        self_menu.SetActive(false);
    }
}
