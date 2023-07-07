using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnim : MonoBehaviour
{
    public GameObject logo;
    public GameObject botonInicio;
    public GameObject personaje;
    public GameObject Salir;

    private void Start()
    {
        LeanTween.moveY(logo.GetComponent<RectTransform>(), -100, 1.5f)
        .setEase(LeanTweenType.easeOutBounce);

        LeanTween.moveX(botonInicio.GetComponent<RectTransform>(), 0, 1.5f)
        .setEase(LeanTweenType.easeOutBounce);

        LeanTween.moveX(personaje.GetComponent<RectTransform>(), -700, 1.5f)
        .setEase(LeanTweenType.easeOutBounce);

        LeanTween.moveX(Salir.GetComponent<RectTransform>(), -40, 1.5f)
        .setEase(LeanTweenType.easeOutBounce);

    }
}
