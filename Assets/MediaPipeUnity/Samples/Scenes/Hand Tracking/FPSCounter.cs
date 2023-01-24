using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class FPSCounter : MonoBehaviour
{
    private TMP_Text _text;
    void Start()
    {
        _text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = (1.0f / Time.deltaTime).ToString("00");
    }
}
