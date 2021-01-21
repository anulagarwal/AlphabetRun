using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PaperRollHandler : MonoBehaviour
{
    #region Properties
    [Header("Component Reference")]
    [SerializeField] private TextMeshPro txt = null;
    #endregion

    #region Core Functions
    public void ChangeTxt(string value)
    {
        txt.SetText(value);
    }
    #endregion
}
