using System.Collections.Generic;
using UnityEngine;

public class SeletorSkin : MonoBehaviour
{
    public List<Sprite> skinOptions; // Lista de sprites disponíveis para seleção

    void Start()
    {
        // Seleciona aleatoriamente uma skin da lista de opções
        Sprite selectedSkin = skinOptions[Random.Range(0, skinOptions.Count)];

        // Aplica a skin selecionada ao objeto que carrega este script como componente
        ApplySkin(selectedSkin);
    }

    void ApplySkin(Sprite skin)
    {
        // Obtém o componente SpriteRenderer do objeto
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        // Verifica se há um SpriteRenderer no objeto
        if (renderer != null)
        {
            // Aplica a skin ao SpriteRenderer
            renderer.sprite = skin;
        }
        else
        {
            Debug.LogWarning("Este objeto não possui um componente SpriteRenderer para aplicar a skin.");
        }
    }
}
