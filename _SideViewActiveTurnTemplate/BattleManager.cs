using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager Instance;

    public List<Unit> AllUnits;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    public void PauseTime() {
        AllUnits.ForEach(f => f.enabled = false);
    }

    public void ResumeTime() {
        AllUnits.ForEach(f => f.enabled = true);
    }
}
