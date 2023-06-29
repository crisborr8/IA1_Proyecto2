using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Vuforia;
using UnityEngine.Video;

public class VBTN_Electronica : MonoBehaviour
{
    public TMP_Text obj_texto;
    public GameObject main_menu;
    public GameObject self_menu;

    public GameObject m1_clase1;
    public AudioSource m2_clase1;
    public GameObject m1_clase2;
    public GameObject m2_clase2;
    public GameObject m1_clase3;
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
        obj_texto.text = "Ing. Electr�nica";
        HideAllMedia();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideAllMedia()
    {
        m1_clase1.SetActive(false);
        m2_clase1.Stop();
        m1_clase2.SetActive(false);
        m2_clase2.SetActive(false);
        m1_clase3.SetActive(false);
        m2_clase3.SetActive(false);
        m1_clase4.SetActive(false);
        m2_clase4.SetActive(false);
        m1_clase5.SetActive(false);
        m2_clase5.SetActive(false);
    }

    public void VerClase1(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Electr�nica\nClase: Teor�a electromagn�tica\nClase sobre el estudio de las interacciones entre la electricidad y el magnetismo en la ingenier�a electr�nica.";
        m1_clase1.SetActive(true);
        m2_clase1.Play();
    }

    public void VerClase2(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Electr�nica\nClase: Electr�nica\nClase que abarca los fundamentos te�ricos y pr�cticos de los circuitos electr�nicos y sus aplicaciones en la ingenier�a.";
        m1_clase2.SetActive(true);
        m2_clase2.SetActive(true);
    }

    public void VerClase3(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Electr�nica\nClase: Circuitos el�cticos\nClase centrada en el an�lisis y dise�o de circuitos el�ctricos, abordando leyes, teoremas y componentes b�sicos de la ingenier�a electr�nica.";
        m1_clase3.SetActive(true);
        m2_clase3.SetActive(true);
    }

    public void VerClase4(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Electr�nica\nClase: Rob�tica\nClase sobre dise�o, construcci�n y programaci�n de robots para aplicaciones pr�cticas en ingenier�a electr�nica.";
        m1_clase4.SetActive(true);
        m2_clase4.SetActive(true);
    }

    public void VerClase5(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Electr�nica\nClase: Telecomunicaciones y redes locales\nClase que explora los principios y tecnolog�as de las telecomunicaciones, as� como el dise�o y gesti�n de redes locales de comunicaci�n.";
        m1_clase5.SetActive(true);
        m2_clase5.SetActive(true);
    }

    public void Regresar(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        main_menu.SetActive(true);
        self_menu.SetActive(false);
    }
}
