using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuComptageDifferent : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquetteTemps;

    public int tempsJeu;

    void Start()
    {
        InvokeRepeating("PasserPoints", 0f, 1f);
        tempsJeu = 0;
    }

    public void PasserPoints()
    {
        // Augmenter les points du jeu
        tempsJeu += 1;
        // Actualiser l'UI
        _etiquetteTemps.text = "$" + tempsJeu.ToString();
    }
}
