using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ApplicationManager : MonoBehaviour
{
    public TextMeshProUGUI StateText;
    public TextMeshProUGUI CityText;
    public TextMeshProUGUI AddressText;
    // Start is called before the first frame update
    void Start()
    {
        StateText.text = "State: TX";
        CityText.text = "City: Houston";
        AddressText.text = "Address: 123 Awesometon Rd";
    }
}
