using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdBanner : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // アプリID、 これはテスト用
        string appId = "ca-app-pub-3940256099942544~3347511713";
        // Android
        //string appId = "ca-app-pub-2945918043757109~2530513580";
        // iOS
        //string appId = "ca-app-pub-2945918043757109~1908746804";

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        RequestBanner();
    }
    private void RequestBanner()
    {

        // 広告ユニットID これはテスト用
        string adUnitId = "ca-app-pub-3940256099942544/6300978111";
        // Android
        //string adUnitId = "ca-app-pub-2945918043757109/6387542702";
        // iOS
        //string adUnitId = "ca-app-pub-2945918043757109/8080113926";

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
