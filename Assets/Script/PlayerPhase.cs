using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhase : MonoBehaviour {

    public enum Phase
    {
        Phase1 = 0,
        Phase2 = 1,
        Phase3 = 2,
        Phase4 = 3
    }

    private Phase StagePhase;

    [SerializeField]
    private GameObject Player;

    private void Start()
    {
        //攻略開始を明示
        StagePhase = Phase.Phase1;
    }

    private void Update()
    {
        Debug.Log(StagePhase.ToString());
    }

    public void SetPhase(Phase _phase)
    {
        StagePhase = _phase;
    }

    public Phase GetPhase()
    {
        return StagePhase;
    }

    public bool IsPhase(Phase _phase)
    {
        return StagePhase == _phase;
    }

}
