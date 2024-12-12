using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeLadrao : MonoBehaviour

{
    [SerializeField] private GameObject ladrao;
    [SerializeField] private GameObject origem;
    [SerializeField] private float tempo = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GeraLadrao", 3.0f, tempo);
    }

    private void GeraLadrao()
    {
        Instantiate(ladrao, origem.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
