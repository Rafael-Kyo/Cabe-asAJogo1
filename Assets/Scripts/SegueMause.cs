using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

public class SegueMause : MonoBehaviour
{
    [SerializeField] private AudioClip tiro;
    [SerializeField] private AudioSource audioP;
    [SerializeField] private GameObject telaFinal;
    [SerializeField]  public TextMeshProUGUI pontosTexto;
    [SerializeField] private int pontos = 0;
    private Timer cronometro;
    private void Start()
    {
        audioP = GetComponent<AudioSource>();
        telaFinal.SetActive(false);
        cronometro = GameObject.Find("Timer").GetComponent<Timer>();
        Time.timeScale = 1.0f;
    }
    void Update()
    {
        Cursor.visible = false;

        Vector3 mousePosition = Input.mousePosition;

        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        mousePosition.z = transform.position.z;

        transform.position = mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            audioP.PlayOneShot(tiro);
        }

        //if (cronometro.VerificaTempo())
        //{
        //    Time.timeScale = 0;
        //    telaFinal.SetActive(true);
        //}

    }

    public void SomaPontos()
    {
        pontos++;
        pontosTexto.text = pontos.ToString();
    }
}
