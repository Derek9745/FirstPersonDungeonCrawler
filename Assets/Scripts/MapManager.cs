using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField]
    private Item dictionaryData;

    private Dictionary<string, int> LevelCollection = new Dictionary<string, int>();
}
