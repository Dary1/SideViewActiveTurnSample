using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int TurnWait = 300;
    int TurnCount = 0;
    public Animator Animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TurnCount++ == TurnWait) {
            TurnCount = 0;
            BattleManager.Instance.PauseTime();
            this.Animator.Play("AttackEntry");
            
        }
    }

    public void ResumeTime() {
        BattleManager.Instance.ResumeTime();
    }
}
