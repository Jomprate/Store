using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsController : MonoBehaviour
{
    [Header("Inf Bar")]
    public Button HomeBTN;
    public Button MessageBTN;
    public Button UserBTN;


    [Header("Buttons")]
    public Button LoginBTN;
    public Button BuyBTN_A;
    public Button SellBTN_A;

    [Header("Buyer buttons")]
    public Button SearchBTN;
    public Button LogOutBTN;
    public Button MessagesBTN;


    [Header("seller buttons")]
    public Button SearchBTN2;
    public Button LogOutBTN2;
    public Button MessagesBTN2;

    [Header("PanelsGO")]
    [SerializeField] GameObject[] PanelsGO;

    // Start is called before the first frame update
    void Start()
    {
        HomeBTN.onClick.AddListener(StoreV);
        MessageBTN.onClick.AddListener(MessagesV);

        LoginBTN.onClick.AddListener(LoginVoid);
        BuyBTN_A.onClick.AddListener(BuyAVoid);
        SellBTN_A.onClick.AddListener(SellAVoid);

        SearchBTN.onClick.AddListener(SearchVoid_Buyer);
        SearchBTN2.onClick.AddListener(SearchVoid_Seller);

        LogOutBTN.onClick.AddListener(LogOutV);
        LogOutBTN2.onClick.AddListener(LogOutV);

        MessagesBTN.onClick.AddListener(MessagesV);
        MessagesBTN2.onClick.AddListener(MessagesV);


    }

    // Update is called once per frame
    void Update()
    {
        if (!PanelsGO[0].activeSelf)
        {
            PanelsGO[9].SetActive(true);
        }
    }

    public void StoreV()
    {
        foreach (GameObject panel in PanelsGO)
        {
            panel.SetActive(false);
        }
        PanelsGO[1].SetActive(true);

    }

    public void LoginVoid()
    {
        PanelsGO[0].SetActive(false);
        PanelsGO[1].SetActive(true);
    }
    public void BuyAVoid()
    {
        PanelsGO[0].SetActive(false);
        PanelsGO[1].SetActive(false);
        PanelsGO[3].SetActive(true);
    }
    public void SellAVoid()
    {
        PanelsGO[0].SetActive(false);
        PanelsGO[1].SetActive(false);
        PanelsGO[8].SetActive(true);
    }
    public void SearchVoid_Buyer()
    {
        PanelsGO[0].SetActive(false);
        PanelsGO[3].SetActive(false);
        PanelsGO[4].SetActive(true);

    }
    public void SearchVoid_Seller()
    {
        PanelsGO[0].SetActive(false);
        PanelsGO[3].SetActive(false);
        PanelsGO[5].SetActive(true);

    }
    public void LogOutV()
    {
        foreach (GameObject panel in PanelsGO)
        {
            panel.SetActive(false);
        }
        PanelsGO[0].SetActive(true);


    }

    public void MessagesV()
    {
        foreach (GameObject panel in PanelsGO)
        {
            panel.SetActive(false);
        }

        //PanelsGO[0].SetActive(true);
        PanelsGO[2].SetActive(true);

    }

}
