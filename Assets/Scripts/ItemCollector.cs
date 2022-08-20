using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] TextMeshProUGUI coinsText;
    [SerializeField] AudioSource coinsAudioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = $"Coins: {coins}";
            coinsAudioSource.Play();
        }
    }
}
