using System;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    private float coinCount;

    private void Awake()
    {
        coinText.text = "Coins : ";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.GetComponent<Collider2D>().isTrigger)
        {
            coinCount++;
            coinText.text = "Coins: " + coinCount;
            Destroy(gameObject);
        }
    }
}
