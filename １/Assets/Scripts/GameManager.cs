using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class GameManager : MonoBehaviour
{
    public GameObject TitleImage;
    public GameObject ClearImage;

    // トランプの裏面
    public GameObject TrumpImage;
    public GameObject TrumpImage1;
    public GameObject TrumpImage2;
    public GameObject TrumpImage3;
    public GameObject TrumpImage4;
    public GameObject TrumpImage5;
    public GameObject TrumpImage6;
    public GameObject TrumpImage7;
    public GameObject TrumpImage8;
    public GameObject TrumpImage9;
    public GameObject TrumpImage10;
    public GameObject TrumpImage11;
    public GameObject TrumpImage12;
    public GameObject TrumpImage13;
    public GameObject TrumpImage14;
    public GameObject TrumpImage15;
    public GameObject TrumpImage16;
    public GameObject TrumpImage17;
    public GameObject TrumpImage18;
    public GameObject TrumpImage19;

    // トランプの表面
    public GameObject _TrumpImage;
    public GameObject _TrumpImage1;
    public GameObject _TrumpImage2;
    public GameObject _TrumpImage3;
    public GameObject _TrumpImage4;
    public GameObject _TrumpImage5;
    public GameObject _TrumpImage6;
    public GameObject _TrumpImage7;
    public GameObject _TrumpImage8;
    public GameObject _TrumpImage9;
    public GameObject _TrumpImage10;
    public GameObject _TrumpImage11;
    public GameObject _TrumpImage12;
    public GameObject _TrumpImage13;
    public GameObject _TrumpImage14;
    public GameObject _TrumpImage15;
    public GameObject _TrumpImage16;
    public GameObject _TrumpImage17;
    public GameObject _TrumpImage18;
    public GameObject _TrumpImage19;

    public float count = 0;
    public float count2 = 0;

    private float set1 = 0;
    private float set2 = 0;
    private float set3 = 0;
    private float set4 = 0;
    private float set5 = 0;
    private float set6 = 0;
    private float set7 = 0;
    private float set8 = 0;
    private float set9 = 0;
    private float set10 = 0;

    void Start()
    {
        TitleImage.SetActive(true);
    }

    void Update()
    {
        if (count2 == 10)
        {
            Invoke(nameof(Clear), 0.5f);
        }

        if (set1 == 2 || set2 == 2 || set3 == 2 || set4 == 2 || set5 == 2||
            set6 == 2 || set7 == 2 || set8 == 2 || set9 == 2 || set10 == 2)
        {
            Invoke(nameof(DestroyTrump), 0.5f);
        }
        else if (count >= 2)
        {
            Invoke(nameof(Reset), 0.5f);
            count = 0;

            set1 = 0;
            set2 = 0;
            set3 = 0;
            set4 = 0;
            set5 = 0;
            set6 = 0;
            set7 = 0;
            set8 = 0;
            set9 = 0;
            set10 = 0;
        }

    }

    public void OnClickTrump()
    {
        GameObject.Find("Trump").SetActive(false);
        count++;
        set1++;
    }
    public void OnClickTrump1()
    {
        GameObject.Find("Trump (1)").SetActive(false);
        count++;
        set2++;
    }
    public void OnClickTrump2()
    {
        GameObject.Find("Trump (2)").SetActive(false);
        count++;
        set3++;
    }
    public void OnClickTrump3()
    {
        GameObject.Find("Trump (3)").SetActive(false);
        count++;
        set4++;
    }
    public void OnClickTrump4()
    {
        GameObject.Find("Trump (4)").SetActive(false);
        count++;
        set5++;
    }
    public void OnClickTrump5()
    {
        GameObject.Find("Trump (5)").SetActive(false);
        count++;
        set5++;
    }
    public void OnClickTrump6()
    {
        GameObject.Find("Trump (6)").SetActive(false);
        count++;
        set6++;
    }
    public void OnClickTrump7()
    {
        GameObject.Find("Trump (7)").SetActive(false);
        count++;
        set7++;
    }
    public void OnClickTrump8()
    {
        GameObject.Find("Trump (8)").SetActive(false);
        count++;
        set1++;
    }
    public void OnClickTrump9()
    {
        GameObject.Find("Trump (9)").SetActive(false);
        count++;
        set7++;
    }
    public void OnClickTrump10()
    {
        GameObject.Find("Trump (10)").SetActive(false);
        count++;
        set8++;
    }
    public void OnClickTrump11()
    {
        GameObject.Find("Trump (11)").SetActive(false);
        count++;
        set9++;
    }
    public void OnClickTrump12()
    {
        GameObject.Find("Trump (12)").SetActive(false);
        count++;
        set2++;
    }
    public void OnClickTrump13()
    {
        GameObject.Find("Trump (13)").SetActive(false);
        count++;
        set3++;
    }
    public void OnClickTrump14()
    {
        GameObject.Find("Trump (14)").SetActive(false);
        count++;
        set10++;
    }
    public void OnClickTrump15()
    {
        GameObject.Find("Trump (15)").SetActive(false);
        count++;
        set4++;
    }
    public void OnClickTrump16()
    {
        GameObject.Find("Trump (16)").SetActive(false);
        count++;
        set8++;
    }
    public void OnClickTrump17()
    {
        GameObject.Find("Trump (17)").SetActive(false);
        count++;
        set6++;
    }
    public void OnClickTrump18()
    {
        GameObject.Find("Trump (18)").SetActive(false);
        count++;
        set9++;
    }
    public void OnClickTrump19()
    {
        GameObject.Find("Trump (19)").SetActive(false);
        count++;
        set10++;
    }

    public void Reset()
    {
        TrumpImage.SetActive(true);
        TrumpImage1.SetActive(true);
        TrumpImage2.SetActive(true);
        TrumpImage3.SetActive(true);
        TrumpImage4.SetActive(true);
        TrumpImage5.SetActive(true);
        TrumpImage6.SetActive(true);
        TrumpImage7.SetActive(true);
        TrumpImage8.SetActive(true);
        TrumpImage9.SetActive(true);
        TrumpImage10.SetActive(true);
        TrumpImage11.SetActive(true);
        TrumpImage12.SetActive(true);
        TrumpImage13.SetActive(true);
        TrumpImage14.SetActive(true);
        TrumpImage15.SetActive(true);
        TrumpImage16.SetActive(true);
        TrumpImage17.SetActive(true);
        TrumpImage18.SetActive(true);
        TrumpImage19.SetActive(true);
    }

    public void DestroyTrump()
    {
        if (set1 == 2)
        {
            TrumpImage.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage8.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage8.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set1 = 0;
            count2++;
        }
        if (set2 == 2)
        {
            TrumpImage1.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage12.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage1.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage12.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set2 = 0;
            count2++;
        }
        if (set3 == 2)
        {
            TrumpImage2.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage13.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage2.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage13.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set3 = 0;
            count2++;
        }
        if (set4 == 2)
        {
            TrumpImage3.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage15.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage3.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage15.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set4 = 0;
            count2++;
        }
        if (set5 == 2)
        {
            TrumpImage4.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage5.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage4.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage5.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set5 = 0;
            count2++;
        }
        if (set6 == 2)
        {
            TrumpImage6.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage17.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage6.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage17.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set6 = 0;
            count2++;
        }
        if (set7 == 2)
        {
            TrumpImage7.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage9.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage7.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage9.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set7 = 0;
            count2++;
        }
        if (set8 == 2)
        {
            TrumpImage10.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage16.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage10.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage16.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set8 = 0;
            count2++;
        }
        if (set9 == 2)
        {
            TrumpImage11.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage18.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage11.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage18.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set9 = 0;
            count2++;
        }
        if (set10 == 2)
        {
            TrumpImage14.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            TrumpImage19.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage14.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            _TrumpImage19.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            set10 = 0;
            count2++;
        }
    }

    public void Clear()
    {
        ClearImage.SetActive(true);
    }

    public void OnClickStartButton()
    {
        TitleImage.SetActive(false);
    }
}
