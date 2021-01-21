using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperRollStackHandler : MonoBehaviour
{
    #region Properties
    [Header("Properties")]
    [SerializeField] private string word = "";

    [Header("Editor Setup")]
    [SerializeField] private GameObject paperRollPrefab = null;
    [SerializeField] private float paperRollLength = 1;

    private Vector3 positionOffset = Vector3.zero;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        word.ToUpper();
        SpawnPaperRolls();
    }
    #endregion

    #region Private Functions
    private void SpawnPaperRolls()
    {
        for(int i = 0; i < word.Length; i++)
        {
            GameObject tempObj = Instantiate(paperRollPrefab, transform.position + positionOffset, Quaternion.identity);
            positionOffset.y += paperRollLength;
            tempObj.GetComponent<PaperRollHandler>().ChangeTxt(word[word.Length - i - 1].ToString());
        }
    }
    #endregion
}
