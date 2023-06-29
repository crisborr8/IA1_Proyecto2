using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Vuforia;
using UnityEngine.Video;

public class VBTN_Civil : MonoBehaviour
{
    public TMP_Text obj_texto;
    public GameObject main_menu;
    public GameObject self_menu;

    public GameObject m1_clase1;
    public GameObject m2_clase1;
    public GameObject m1_clase2;
    public GameObject m2_clase2;
    public AudioSource m1_clase3;
    public GameObject m2_clase3;
    public GameObject m1_clase4;
    public GameObject m2_clase4;
    public AudioSource m1_clase5;
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
        obj_texto.text = "Ing. Civil";
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
        m1_clase3.Stop();
        m2_clase3.SetActive(false);
        m1_clase4.SetActive(false);
        m2_clase4.SetActive(false);
        m1_clase5.Stop();
        m2_clase5.SetActive(false);

    }

    public void VerClase1(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Pedrología\nUna clase sospechosa en la cual es posible que se estudien piedras.";
        m1_clase1.SetActive(true);
        m2_clase1.SetActive(true);
    }

    public void VerClase2(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Geofísica\nMediciones físicas y modelos matematicos para comprender como funciona la tierra?? WOW!!!";
        m1_clase2.SetActive(true);
        m2_clase2.SetActive(true);
    }

    public void VerClase3(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Aguas subterraneas\nTemas como manejo de agua bajo tierra, grietas, huecos, etc. Mas que nada acuiferos.";
        m1_clase3.Play();
        m2_clase3.SetActive(true);
    }

    public void VerClase4(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Puentes\nPuentes en rios, cañones, valles, terrenos accidentados, etc.";
        m1_clase4.SetActive(true);
        m2_clase4.SetActive(true);
    }

    public void VerClase5(VirtualButtonBehaviour vb)
    {
        HideAllMedia(); 
        obj_texto.text = "Ing. Civil\nClase: Urbanismo\nMovilidad y diseño de instrumentos de desarrollo urbano. La calle se respeta.";
        m1_clase5.Play();
        m2_clase5.SetActive(true);
    }

    public void Regresar(VirtualButtonBehaviour vb)
    {
        main_menu.SetActive(true);
        self_menu.SetActive(false);
    }
}
