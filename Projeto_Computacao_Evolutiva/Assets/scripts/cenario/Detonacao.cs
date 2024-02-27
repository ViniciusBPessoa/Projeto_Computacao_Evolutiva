using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonacao : MonoBehaviour
{
    public List<string> listaDestro = new List<string>();
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se a tag da colisão está na lista de tags permitidas
        if (listaDestro.Contains(collision.gameObject.tag))
        {
            Destroy(collision.gameObject);
        }
    }
}
