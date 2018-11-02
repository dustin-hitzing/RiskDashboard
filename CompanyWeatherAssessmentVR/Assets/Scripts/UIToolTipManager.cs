using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using RiskDemo;

public class UIToolTipManager : MonoBehaviour
{
    
    [SerializeField]
    private TextMeshProUGUI StateTextInfo;
    [SerializeField]
    private TextMeshProUGUI CityTextInfo;
    [SerializeField]
    private TextMeshProUGUI AddressTextInfo;
    
    public void UpdateUI(int index, Dictionary<int, RiskData> riskData)
    {
        Debug.Log(riskData);
        StateTextInfo.text = riskData[index].StateText;
        CityTextInfo.text = riskData[index].CityText;
        AddressTextInfo.text = riskData[index].AddressText;
    }

    
}


