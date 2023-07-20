using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string boolName;
    [SerializeField] private bool changeSprite = false;
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Sprite state1;
    [SerializeField] private Sprite state2;

    private void OnMouseDown() 
    {
        if(animator)
            animator.SetBool(boolName, !animator.GetBool(boolName));
        
        if(changeSprite)
            sprite.sprite = animator.GetBool(boolName) ? state2 : state1;
    }
}
