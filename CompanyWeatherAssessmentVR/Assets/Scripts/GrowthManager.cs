using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RiskDemo
{
    public class GrowthManager : MonoBehaviour
    {
        public float Height;
        public float PositionY;
        public UIToolTipManager RectOneToolTip;
        public DataManager dataManager;
        public GameObject Cube;
        [SerializeField]
        private int INDEX;
        // Start is called before the first frame update
        void Update()
        {
            if (dataManager.RiskData != null)
            {
                RectOneToolTip.UpdateUI(INDEX, dataManager.RiskData);
                Height = dataManager.RiskData[INDEX].CubeHeight;
                var toolTipPostion = RectOneToolTip.GetComponent<RectTransform>();
                PositionY = Height / 2;
                toolTipPostion.transform.position = new Vector3(toolTipPostion.position.x, PositionY + 25f, toolTipPostion.position.z);
                Cube.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                Cube.transform.localScale = new Vector3(1, Height, 1);
            }
        }
    }
}

    


