using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RiskDemo
{
    public class DataManager : MonoBehaviour
    {
        public Dictionary<int, RiskData> RiskData;

        private void Update()
        {
            if (RiskData == null)
            {
                RiskData = CreateRiskDataDictionary();
            }
            
        }

        Dictionary<int, RiskData> CreateRiskDataDictionary()
        {
            return new Dictionary<int, RiskData>
        {
            { 1, new RiskData
                {
                    StateText = "TX",
                    CityText = "Houston",
                    AddressText = "123 AwesomeTown St",
                    CubeHeight = 5
                }
            },
            { 2, new RiskData
                {
                    StateText = "TX",
                    CityText = "Austin",
                    AddressText = "321 SuperDeDuper Ave",
                    CubeHeight = 8
                }
            },
            { 3, new RiskData
                {
                    StateText = "TX",
                    CityText = "Otherton",
                    AddressText = "2 gether ln",
                    CubeHeight = 15
                }
            }
        };
        }
    }

    public class RiskData
    {
        public string StateText { get; set; }
        public string CityText { get; set; }
        public string AddressText { get; set; }
        public float CubeHeight { get; set; }
    }
}

