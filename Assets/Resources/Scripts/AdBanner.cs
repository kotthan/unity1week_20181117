using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdBanner : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
#if UNITY_ANDROID
        // Android
        string appId = "ca-app-pub-2945918043757109~2530513580";
#elif UNITY_IOS
        // iOS
        string appId = "ca-app-pub-2945918043757109~1908746804";
#else
        string appId = "unexpected_platform";
#endif
        // アプリID、 これはテスト用
        //string appId = "ca-app-pub-3940256099942544~3347511713";

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        RequestBanner();
    }
    private void RequestBanner()
    {
#if UNITY_EDITOR
        string adUnitId = "unused";
#elif UNITY_ANDROID
        // Android
        string adUnitId = "ca-app-pub-2945918043757109/6387542702";
#elif UNITY_IOS
        // iOS
        string adUnitId = "ca-app-pub-2945918043757109/8080113926";
#else
        string adUnitId = "unexpected_platform";
#endif
        // 広告ユニットID これはテスト用
        //string adUnitId = "ca-app-pub-3940256099942544/6300978111";

        AdSize size = new AdSize(210, 50); //640
        // Create a 320x50 banner at the top of the screen.
        BannerView bannerView = new BannerView(adUnitId, size, AdPosition.TopRight);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);

    }


    // Update is called once per frame
    void Update()
    {

    }
}
