using Assets.Script;
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

    private static Dictionary<string, string> StageIDs;
    private static Dictionary<string, string> StageNameList;
    private static Dictionary<string, string> StageDescList;


    private void Awake()
    {
        StageIDs      = CreateStageIDs();
        StageNameList = CreateStageNameList();
        StageDescList = CreateStageDescList();
    }
    
    public static string SearchStageID(string ObjectName)
    {
        return StageData.StageIDs.GetOrDefault(ObjectName);
    }

    public static string SearchStageName(string ObjectName)
    {
        return StageData.StageNameList.GetOrDefault(ObjectName);
    }

    public static string SearchStageDesc(string ObjectName)
    {
        return StageData.StageDescList.GetOrDefault(ObjectName);
    }

    private Dictionary<string, string> CreateStageIDs()
    {
        return new Dictionary<string, string>()
        {
            {"StageOne","StageOne" },
            {"StageTwo","StageTwo" }
        };
    }

    private Dictionary<string,string> CreateStageNameList()
    {
        return new Dictionary<string, string>()
        {
            {"StageOne","始まりの平原" },
            {"StageTwo","緩やかな丘陵地帯" }
        };
    }

    private Dictionary<string, string> CreateStageDescList()
    {
        return new Dictionary<string, string>()
        {
            {"StageOne","穏やかな風が吹く、平原地帯" },
            {"StageTwo","空に浮かぶ大地が存在する、珍しい地帯" }
        };
    }
}

