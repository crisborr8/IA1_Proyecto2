using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Vuforia;
using UnityEngine.Video;

public class VBTN_I1 : MonoBehaviour
{
    public TMP_Text obj_texto;
    public GameObject m1_clase1;
    public AudioSource m2_clase1;
    public GameObject m1_clase2;
    public GameObject m2_clase2;
    public VirtualButtonBehaviour clase1;
    public VirtualButtonBehaviour clase2;
    public VirtualButtonBehaviour clase3;
    public VirtualButtonBehaviour clase4;
    public VirtualButtonBehaviour clase5;

    // Start is called before the first frame update
    void Start()
    {
        clase1.RegisterOnButtonPressed(VerClase1);
        clase2.RegisterOnButtonPressed(VerClase2);
        clase3.RegisterOnButtonPressed(VerClase3);
        clase4.RegisterOnButtonPressed(VerClase4);
        clase5.RegisterOnButtonPressed(VerClase5);
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
        m2_clase1.mute = true;
        m1_clase2.SetActive(false);
        m2_clase2.SetActive(false);

    }

    public void VerClase1(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Urbanismo\nMovilidad y diseño de instrumentos de desarrollo urbano. La calle se respeta.";
        m1_clase1.SetActive(true);
        m2_clase1.mute = false;
    }

    public void VerClase2(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Pedrología\nUna clase sospechosa en la cual es posible que se estudien piedras.";
        m1_clase2.SetActive(true);
        m2_clase2.SetActive(true);
    }

    public void VerClase3(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Aguas subterraneas\nasdf";
    }

    public void VerClase4(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Puentes\nasdf";
    }

    public void VerClase5(VirtualButtonBehaviour vb)
    {
        HideAllMedia();
        obj_texto.text = "Ing. Civil\nClase: Geofísica\nasdf";
    }
}
