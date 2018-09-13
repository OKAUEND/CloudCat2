using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageData : MonoBehaviour
{

    public enum CompleteFlag
    {
        None = 0,
        NoComplete = 1,
        Play = 2,
        Complete = 3
    }

    public struct ProgressiveState
    {
        public static CompleteFlag Stage1;
        public static CompleteFlag Stage2;
    }

    public static Dictionary<string, string> StageNameList;

    private void Awake()
    {
        StageNameList = CreateStageNameList();
    }

    private Dictionary<string, string> CreateStageNameList()
    {
        return new Dictionary<string, string>()
        {
            {"StageOne","StageOne" },
            {"StageTwo","StageTwo" }
        };
    }
}

