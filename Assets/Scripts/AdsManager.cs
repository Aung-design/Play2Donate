using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

//public class AdsManager : MonoBehaviour, IUnityAdsListener
public class AdsManager : MonoBehaviour
{
    public static AdsManager instance;

    string gameID = "4276371";
    
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }  
    }

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID);

        //Advertisement.AddListener(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady("Interstitial_Android"))
        {
            Advertisement.Show("Interstitial_Android");
        }
    }

    //public void ShowRewaredAd()
    //{
    //    if (Advertisement.IsReady("Rewarded_Android"))
    //    {
    //        Advertisement.Show("Rewarded_Android");
    //    }
    //}

    //public void OnUnityAdsReady(string placementId)
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void OnUnityAdsDidError(string message)
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void OnUnityAdsDidStart(string placementId)
    //{
    //    throw new System.NotImplementedException();
    //} 

    //public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    //{
    //    if(showResult == ShowResult.Finished)
    //    {
    //        //Reward the User
    //        print("you are rewarded");

    //    }

    //    GameManager.instance.ReloadLevel();
    //}

    
}
