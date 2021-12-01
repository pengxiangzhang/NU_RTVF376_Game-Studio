using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI m_TextComponent;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "City") 
            m_TextComponent.text = "Welcome, You are in a city.\nYou are trying to go to a christmas party.";
        else if (other.gameObject.name == "Suburban")
            m_TextComponent.text = "Welcome, You are in a suburban.\nYou are trying to go to a christmas party.";
        else if (other.gameObject.name == "Forest")
            m_TextComponent.text = "Welcome, You are in a forest.\nYou are trying to go to a christmas party.";
        else if (other.gameObject.name == "Construction")
            m_TextComponent.text = "Welcome, You are in a construction site.\nYou are trying to go to a christmas party.";
        else if (other.gameObject.name == "Snow")
            m_TextComponent.text = "Welcome to the christmas party.\nHave a great holiday season!";
    }
}
