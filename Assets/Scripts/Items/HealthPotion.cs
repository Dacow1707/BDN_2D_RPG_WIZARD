﻿using UnityEngine;



/// <summary>
/// Classe de gestion des potions de vie
/// </summary>
[CreateAssetMenu(fileName = "HealthPotion", menuName = "Items/Potion", order = 1)]
public class HealthPotion : Item, IUseable
{
    // Points de vie de la potion
    [SerializeField]
    private int health = default;


    /// <summary>
    /// Utilisation de la potion de vie
    /// </summary>
    public void Use()
    {
        // Si le joueur a besoin de vie
        if (Player.MyInstance.MyHealth.MyCurrentValue < Player.MyInstance.MyHealth.MyMaxValue)
        {
            // Supprime l'item de l'emplacement
            Remove();

            // Ajoute de la vie au joueur
            Player.MyInstance.MyHealth.MyCurrentValue += health;
        }
    }
}
