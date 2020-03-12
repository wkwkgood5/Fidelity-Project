using UnityEngine;

public class LeapCubeController : MonoBehaviour
{
    Leap.Unity.Interaction.InteractionBehaviour interactionBehaviour;
    void Start()
    {
        interactionBehaviour = GetComponent<Leap.Unity.Interaction.InteractionBehaviour>();

        // 悬停事件
        interactionBehaviour.OnHoverBegin = () => {
            Debug.Log("刚开始悬停...");
        };
        interactionBehaviour.OnHoverStay = () => {
            //Debug.Log("悬停保持中...");
        };
        interactionBehaviour.OnHoverEnd = () => {
            Debug.Log("悬停结束");
        };

        // 抓取事件
        interactionBehaviour.OnGraspBegin = () => {
            Debug.Log("抓取开始...");
        };
        interactionBehaviour.OnGraspStay = () => {
            // Debug.Log("抓取保持...");
        };
        interactionBehaviour.OnGraspEnd = () => {
            Debug.Log("抓取结束...");
        };

        // 触击事件
        interactionBehaviour.OnContactBegin = () => {
            Debug.Log("开始触击..");
        };
        interactionBehaviour.OnContactStay = () => {
            // Debug.Log("保持触击..");
        };
        interactionBehaviour.OnContactEnd = () => {
            Debug.Log("触击结束");
        };
    }
}