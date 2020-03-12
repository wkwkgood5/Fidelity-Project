using UnityEngine;
using System.Collections;
using System;
public class PanelManager : MonoBehaviour {
    public PanelInstance[] Pages;
    public PanelInstance currentPanel;
    void Start()
    {
        for(int i = 0; i < Pages.Length; i++)
        {
            Pages[i].gameObject.AddComponent<PanelInstance>();
        }
    }
 
    void Awake()
    {
        if (Pages.Length <= 0)
        {
            return;
        }
        OpenPanel(Pages[0]);
    }
 
    //打开面板
    public void OpenPanel(PanelInstance page)
    {
        if (page == null)
        {
            return;
        }
        page.PanelBefore = currentPanel;
        currentPanel = page;
        CloseAllPanels();
        Animator anim = page.GetComponent<Animator>();
        if (anim && anim.isActiveAndEnabled)
        {
            anim.SetBool("Open", true);
        }
        page.gameObject.SetActive(true);
        Debug.Log("面板"+page.gameObject.name+"已经打开");
    }
    //通过名字打开面板
    public void OpenPanelByName(string name)
    {
        PanelInstance page = null;
        for (int i = 0; i < Pages.Length; i++)
        {
            if (Pages[i].name == name)
            {
                page = Pages[i];
                break;   
            }
        }
        if (page == null)
        {
            return;
        }
        page.PanelBefore = currentPanel;
        currentPanel = page;
        CloseAllPanels();
        Animator anim = page.GetComponent<Animator>();
        if (anim && anim.isActiveAndEnabled)
            {
                anim.SetBool("Open", true);
            }
        page.gameObject.SetActive(true);
    }
    //关闭所有面板
    public void CloseAllPanels()
    {
        if (Pages.Length <= 0)
        {
            return;
        }
        for(int i = 0; i < Pages.Length; i++)
        {
            Animator anim = Pages[i].gameObject.GetComponent<Animator>();
            if (anim && anim.isActiveAndEnabled)
            {
                anim.SetBool("Open", false);
            }
            if (Pages[i].isActiveAndEnabled)
            {
                StartCoroutine(DisablePanelDeleyed(Pages[i]));
            }
        }
    }
 
    //禁用面板
 
    public IEnumerator DisablePanelDeleyed(PanelInstance page)
    {
        bool closedStateReached = false;
        bool wantToClose = true;
        Animator anim = page.gameObject.GetComponent<Animator>();
        if (anim && anim.enabled)
        {
            while (!closedStateReached && wantToClose)
            {
                if (anim.isActiveAndEnabled && !anim.IsInTransition(0))
                {
 
                    closedStateReached = anim.GetCurrentAnimatorStateInfo(0).IsName("Closing");
                }
                yield return new WaitForEndOfFrame();
            }
            if (wantToClose)
            {
                anim.gameObject.SetActive(false);
            }
        }
        else
        {
            page.gameObject.SetActive(false);
        }
 
    }
 
}