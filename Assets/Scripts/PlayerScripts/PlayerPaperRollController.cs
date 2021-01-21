using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaperRollController : MonoBehaviour
{
    #region Properties
    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 0f;

    [Header("Component Reference")]
    [SerializeField] private Animator playerCharacterAnimator = null;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        
    }

    private void Update()
    {
        if(LevelManager.Instance.CurrentLevelStatus == LevelStatus.Gameplay)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            playerCharacterAnimator.SetBool("Running", true);
        }
    }
    #endregion
}
