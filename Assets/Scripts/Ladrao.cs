using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladrao : MonoBehaviour
{
    [SerializeField] private float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        velocidade = Random.Range(velocidade, velocidade + 10);
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
        
    }

    private void OnM()
    {
        Destroy(gameObject);
    }
}
