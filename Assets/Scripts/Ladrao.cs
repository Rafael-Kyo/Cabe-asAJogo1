using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladrao : MonoBehaviour
{
    [SerializeField] private float velocidade;
    [SerializeField] private float multiplicador = 5.0f;
    [SerializeField] private GameObject sangue;
    [SerializeField] private SegueMause segueMause;
  

    void Start()
    {
       velocidade = Random.Range(velocidade, velocidade + multiplicador);
       segueMause = GameObject.Find("Scope").GetComponent<SegueMause>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1 * velocidade * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("FimDeJogo");
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        segueMause.SomaPontos();
        Instantiate(sangue, transform.position, Quaternion.identity);       
        Destroy(gameObject);
    }
}
