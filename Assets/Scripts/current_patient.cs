using System.Collections.Generic;
using UnityEngine;

public class current_patient : MonoBehaviour
{
    Dictionary<string, int> comp_dict = new Dictionary<string, int>
    {
        { "Вода", 1 },
        { "Антисептик", 2 },
        { "Лимонная кислота", 3 },
        { "Куриное яйцо", 4},
        { "Столовая сода", 5},
        { "Крем для лица", 6},
        { "Грязный платок", 7},
        { "Шерсть орангутанга", 8},
        { "Пробирка с воздухом", 9},
        { "Глицин", 10},
        { "Капли в нос", 11},
        { "Компливит", 12}
    };
}