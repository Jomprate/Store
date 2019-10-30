using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagesController : MonoBehaviour
{
    public Button SalesBTN;
    public Button purchasesBTN;

    public GameObject salesGO;
    public GameObject purchasesGO;

    void Start()
    {
        SalesBTN.onClick.AddListener(SalesV);
        purchasesBTN.onClick.AddListener(PurchasesV);

    }

    void SalesV()
    {
        salesGO.SetActive(true);
        purchasesGO.SetActive(false);
    }
    void PurchasesV()
    {
        salesGO.SetActive(false);
        purchasesGO.SetActive(true);

    }

}
