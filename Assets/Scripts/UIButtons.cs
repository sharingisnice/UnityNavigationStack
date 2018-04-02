//Welcome to easy Stack Navigation Style Movement across panels or canvases.
//All you need to do is simply adding DoTween(free or paid) from AssetStore to your project.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
	List<Transform> pageStack = new List<Transform>();

    public Transform panel1;
    public Transform panel2;
    public Transform panel3;

    public Transform posRight;
    public Transform posCenter;
    public Transform posLeft;

    public void button1()
    {
		MoveToNextPage(panel1,panel2);

		//In case you just want to move to some page basicaly, you may use the code below.
        // panel2.DOMove(posCenter.position, 0.3f).SetEase(Ease.OutCirc);
        // panel1.DOMove(posLeft.position, 0.3f).SetEase(Ease.InCirc);
    }

    public void button2()
    {
		MoveToPreviousPage(panel2);

        // panel2.DOMove(posRight.position, 0.3f).SetEase(Ease.InCirc);
        // panel1.DOMove(posCenter.position, 0.3f).SetEase(Ease.OutCirc);
    }



	public void MoveToNextPage(Transform fromThisPage, Transform toThisPage){
        toThisPage.DOMove(posCenter.position, 0.3f).SetEase(Ease.OutCirc);
        fromThisPage.DOMove(posLeft.position, 0.3f).SetEase(Ease.InCirc);
		pageStack.Add(fromThisPage);
	}

	public void MoveToPreviousPage(Transform fromThisPage){
		fromThisPage.DOMove(posRight.position,0.3f).SetEase(Ease.InCirc);
		pageStack[pageStack.Count-1].DOMove(posCenter.position, 0.3f).SetEase(Ease.OutCirc);
		pageStack.RemoveAt(pageStack.Count-1);
	}

}
