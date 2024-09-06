﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MEC;

public class AdsManager : Singleton<AdsManager>
{
    #region Admobs

    [Header ("CONFIG")] [SerializeField] private string _AppId;
    [SerializeField]                     private string _BannerId;
    [SerializeField]                     private string _RewardVideoId;

    #endregion

    [Header ("Action")] public bool IsRewardVideoAvailable;
    public                     bool IsBannerAvailable;

    [Header ("Config")] [SerializeField] private bool IsAutoReloadAgain;

    public System.Action OnCompletedRewardVideo;
    public System.Action OnFailedRewardVideo;

    public System.Action OnFailedFullScreen;
    public System.Action OnCompletedFullScreen;

    private bool IsCompletedTheRewards;
    private bool IsRewardClosed;
    private bool IsRewardValid;

    private bool IsRemoveAds;

    private bool IsWatchedRewardAds;
    private bool IsFirstTimeLoadBanner;

    private CoroutineHandle handleLoadAds;

    private void Init ()
    {
        // =============================== INIT THE AD ================================ //


    }

    public void RefreshRemoveAds ()
    {
        IsRemoveAds = PlayerData.IsRemoveAds;

        if (IsRemoveAds)
        {
            HideBanner ();
        }
    }

    private void RegisterEvent ()
    {
        #if UNITY_EDITOR
        IsRewardVideoAvailable = true;
        IsBannerAvailable      = true;
        return;
        #endif

        RefreshRewardVideo ();
        RefreshBanner ();
    }

    #region System

    protected override void Awake ()
    {
        base.Awake ();

        Init ();

        RegisterEvent ();
    }
    
    private IEnumerator<float> _LoadAds ()
    {
        while (IsWatchedRewardAds == false)
        {
            yield return Timing.WaitForOneFrame;
        }
        
        if (IsWatchedRewardAds)
        {
            IsWatchedRewardAds = false;

            yield return Timing.WaitUntilDone (Timing.RunCoroutine (_ReloadRewardAds ()));
        }
    }

    private IEnumerator<float> _ReloadRewardAds ()
    {
        yield return Timing.WaitForOneFrame;

        IsRewardVideoAvailable = false;

        if (IsRewardClosed && IsRewardValid)
        {
            DoCompletedRewardVideo ();

            IsRewardClosed = false;
            IsRewardValid  = false;
        }
        else
        {
            DoFailedRewardVideo ();

            IsRewardClosed = false;
            IsRewardValid  = false;
        }

        if (IsAutoReloadAgain)
            RefreshRewardVideo ();
    }

    #endregion


    private void DoFailedFullScreen ()
    {
        if (OnFailedFullScreen != null)
        {
            OnFailedFullScreen ();
            OnFailedFullScreen = null;
        }
    }

    private void DoCompletedFullScreen ()
    {
        if (OnCompletedFullScreen != null)
        {
            OnCompletedFullScreen ();
            OnCompletedFullScreen = null;
        }
    }

    private void DoFailedRewardVideo ()
    {
        if (OnFailedRewardVideo != null)
        {
            OnFailedRewardVideo ();
            OnFailedRewardVideo = null;
        }

        LogGame.Log ("[Ad Manager] Reward Video Is Failed!");
    }

    private void DoCompletedRewardVideo ()
    {
        if (OnCompletedRewardVideo != null)
        {
            OnCompletedRewardVideo ();
            OnCompletedRewardVideo = null;
        }

        LogGame.Log ("[Ad Manager] Reward Video Is Completed!");
    }

    public void RegisterEvent (System.Action OnCompleted, System.Action OnFailed)
    {
        OnCompletedRewardVideo = OnCompleted;
        OnFailedRewardVideo    = OnFailed;
    }

    public void RegisterEventFullScreen (System.Action OnCompleted, System.Action OnFailed)
    {
        OnFailedFullScreen    = OnFailed;
        OnCompletedFullScreen = OnCompleted;
    }

    public void ShowRewardVideo ()
    {
        #if UNITY_EDITOR || UNITY_STANDALONE

        DoCompletedRewardVideo ();

        return;

        #endif
        
    }

    public void ShowBanner ()
    {
        if (IsRemoveAds)
        {
            return;
        }

    }

    public void HideBanner ()
    {
    }

    public void RefreshRewardVideo ()
    {
        if (IsRewardVideoAvailable) return;

    }

    public void RefreshBanner ()
    {
        if (IsRemoveAds)
            return;

        if (IsBannerAvailable) return;

    
    }
}