﻿using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe de gestion des boutons des items du vendeur
/// </summary>
public class VendorButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    // Image de l'item du bouton
    [SerializeField]
    private Image icon = default;

    // Propriété d'accès à l'image de l'item du bouton
    //public Image MyIcon { get => icon; }

    // Titre de l'item du bouton
    [SerializeField]
    private Text title = default;

    // Propriété d'accès au titre de l'item du bouton
    //public Text MyTitle { get => title; }

    // Prix de l'item du bouton
    [SerializeField]
    private Text price = default;

    // Quantité de l'item du bouton
    [SerializeField]
    private Text quantity = default;


    // Propriété d'accès à l'item du vendeur
    //public Item MyItem { get; set; }

    // Référence sur le script LootWindow
    //private VendorWindow vendorWindow;


    /// <summary>
    /// Awake
    /// </summary>
    private void Awake()
    {
        // Référence sur le script LootWindow
        //vendorWindow = GetComponentInParent<VendorWindow>();
    }

    /// <summary>
    /// Entrée du curseur
    /// </summary>
    /// <param name="eventData">Evenement d'entrée</param>
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Affiche le tooltip
        //UIManager.MyInstance.ShowTooltip(new Vector2(1, 0), transform.position, MyLoot);
    }

    /// <summary>
    /// Sortie du curseur
    /// </summary>
    /// <param name="eventData">Evenement de sortie</param>
    public void OnPointerExit(PointerEventData eventData)
    {
        // Masque le tooltip
        //UIManager.MyInstance.HideTooltip();
    }

    /// <summary>
    /// Gestion du clic
    /// </summary>
    /// <param name="eventData">Evenement de clic</param>
    public void OnPointerClick(PointerEventData eventData)
    {
        /*
        // Récupère l'item s'il y a de la place 
        if (InventoryScript.MyInstance.AddItem(MyItem))
        {
            // Réinitialisation du bouton
            gameObject.SetActive(false);

            // Retire l'item de la page et de la liste des butins
            //vendorWindow.TakeLoot(MyItem);

            // Masque le tooltip
            UIManager.MyInstance.HideTooltip();
        }
        */
    }

    /// <summary>
    /// Ajoute un item
    /// </summary>
    /// <param name="vendorItem">item du vendeur</param>
    public void AddItem(VendorItem vendorItem)
    {
        // Active le bouton de l'item
        gameObject.SetActive(true);
    }
}