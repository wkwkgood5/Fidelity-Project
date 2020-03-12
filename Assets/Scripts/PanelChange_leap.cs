using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class PanelChange_leap : MonoBehaviour {
 
   //这里存放所有你想要显示的面板
   public GameObject[] panels;
   //当前显示面板的索引值  如果为-1则是关闭所有面板
   public int current_Index;
   //是否切换了面板  如果你点击了按钮那就是要切换，没有点击就是不切换
   //默认值为false
   public bool isChange = false;
   private int MainMenu;

   public GameObject TimeText;
   private int TotalTime_practice=60;
   private int TotalTime_reset=60;
   private int TotalTime_play=60;
 
 
   public void Exit(){
   		foreach(GameObject i in panels)
       	{
            //关闭显示
            i.SetActive(false);
       	}
   }

   //这个函数就是这个代码的核心控制 在updata中每帧执行
   public void Display()
   {
       //如果切换了才执行，没有切换就不执行直接return就可以结束函数的运行
       if(!isChange)
       {
            return;
       }
       //切换完了就把它的值 = false  这样你点击按钮只会触发一次
       isChange = false;
       //首先关闭所有显示的面板 这里使用foreach循环遍历所有的面板
	   panels[8].SetActive(true);
       for (int i =9 ; i < panels.Length; i++)
       {
            //关闭显示
            panels[i].SetActive(false);
       }
       //这里处理current_Index为-1的情况  为-1就不在显示面板了直接return结束；
       if(current_Index == -1)
       {
            return;
       }
       //打开当前面板
       panels[current_Index].SetActive(true);
	   panels[current_Index-1].SetActive(false);
   }

	// public void RestartPractice(){

	// 	//SceneManager.LoadScene ("XBox_practice");
	// 	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	// 	//AsyncOperation  NextScene=SceneManager.LoadSceneAsync("XBox_practice",LoadSceneMode.Additive);
	// 	// foreach(GameObject i in panels)
 //  //      	{
 //  //           //关闭显示
 //  //           i.SetActive(false);
 //  //      	}
	// }

	public void ExitPractice(){
		panels[2].SetActive(true);
	}

	public void OpenFrame7(){
        panels[4].SetActive(true);
	}

	public void OpenFrame8(){
        panels[5].SetActive(true);
	}

	public void OpenFrame13(){
        panels[8].SetActive(true);
	}

	public void OpenFrame14(){
        panels[9].SetActive(true);
	}

 
   //当按钮点击的时候调用这个方法就行了 
   public void SelectPanel(int index)
   {
       isChange = true;
       current_Index = index;
   }


	public void Counttime1(){
		
		StopCoroutine("CountDown3");
		StopCoroutine("CountDown2");
		StopCoroutine("CountDown1");
		TotalTime_practice=60;
		StartCoroutine("CountDown1");
		
	}

	IEnumerator CountDown1()
	{
	    while (TotalTime_practice >=0)
	    {
	        TimeText.GetComponent<Text>().text = "Time: "+TotalTime_practice.ToString()+"s";
	        yield return new WaitForSeconds(1);
	        TotalTime_practice--;

	    }
	    panels[2].SetActive(true);
	}

	public void Counttime2(){
		StopCoroutine("CountDown1");
		StopCoroutine("CountDown2");
		StopCoroutine("CountDown3");
		TotalTime_reset=60;
		StartCoroutine("CountDown2");
	}

	IEnumerator CountDown2()
	{
	    while (TotalTime_reset >=0)
	    {
	        TimeText.GetComponent<Text>().text = "Time: "+TotalTime_reset.ToString()+"s";
	        yield return new WaitForSeconds(1);
	        TotalTime_reset--;
	    }
	    panels[2].SetActive(true);
	}

	public void Counttime3(){
		StopCoroutine("CountDown1");
		StopCoroutine("CountDown2");
		StopCoroutine("CountDown3");
		TotalTime_play=60;
		StartCoroutine("CountDown3");
	}

	IEnumerator CountDown3()
	{
	    while (TotalTime_play >=0)
	    {
	        TimeText.GetComponent<Text>().text = "Time: "+TotalTime_play.ToString()+"s";
	        yield return new WaitForSeconds(1);
	        TotalTime_play--;
	    }
	    switch(MainMenu){
	    	case 0:
		    	panels[3].SetActive(true);
		    	MainMenu++;
		    	break;
		    case 1:
		    	panels[7].SetActive(true);
		    	MainMenu++;
		    	break;
		    case 2:
		    	panels[11].SetActive(true);
		    	MainMenu++;
		    	break;	
	    }    
	}
 
    // Use this for initialization
    void Start () {
       
    }
   
    // Update is called once per frame
    void Update () {
       Display();
    }
}
