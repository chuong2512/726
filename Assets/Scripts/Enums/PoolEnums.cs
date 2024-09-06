﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PoolEnums
{
    public enum PoolId
    {
        None                  = 0,
        BaseItemMoving        = 1,
        BaseItemGrid          = 2,
        BaseItemBox           = 3,
        FxRaiseGold           = 4,
        FxExplode_Firework    = 5,
        FxSunshine            = 6,
        FxItem_Diamond        = 7,
        FxStarExp             = 8,
        FxItem_Coins          = 9,
        FxUIDisplaySpeedUp    = 10,
        Mission_Layout        = 11,
        Reward_Layout         = 12,
        FxTapUpgrade          = 13,
        InteractEquipmentView = 14,
        FxUIRaiseGold         = 15,
        FxTapBox              = 16,
        FxTapDiamonds         = 17,
        InteractBoostView     = 18,
        FxTapCoins            = 19,
        FxTapFlower           = 20,
        FxLevelUp             = 21,
        FxTapButton           = 22,
        FxLevelUpItem         = 23,
        Bullet_1              = 24,
        Enemy                 = 25,
        Muzzle                = 26,
        FxTextDamage          = 27,
        FxExplodeNormalBullet = 28,
        Enemy_1               = 29,
        Enemy_2               = 30,
        Enemy_3               = 31,
        Enemy_4               = 32,
        Enemy_5               = 33,
        Enemy_6               = 34,
        Enemy_7               = 35,
        Enemy_8               = 36,
        FxVirusExplode        = 37,
        Item_1                = 38,
        Item_2                = 39,
        Item_3                = 40,
        Item_4                = 41,
        Item_5                = 42,
        Item_6                = 43,
        Item_7                = 44,
        Item_8                = 45,
        Item_9                = 46,
        Item_10               = 47,
        Item_11               = 48,
        Item_12               = 49,
        Item_13               = 50,
        Item_14               = 51,
        Item_15               = 52,
        Item_16               = 53,
        Item_17               = 54,
        Item_18               = 55,
        Item_19               = 56,
        Item_20               = 57,
        Item_21               = 58,
        Item_22               = 59,
        Item_23               = 60,
        Item_24               = 61,
        Item_25               = 62,
        Item_26               = 63,
        Item_27               = 64,
        Item_28               = 65,
        Item_29               = 66,
        Item_30               = 67,
        Rock_Enemy_1          = 68,
        Rock_Enemy_2          = 69,
        Rock_Enemy_3          = 70,
        Boss_1                = 71,
        Boss_2                = 72,
        FxExplodeRocketBullet = 73,
        Bullet_2              = 74,
        Bullet_3              = 75,
        Bullet_4              = 76,
        Bullet_5              = 77,
        Bullet_6              = 78,
        Bullet_7              = 79,
        Bullet_8              = 80,
        Bullet_9              = 81,
        Bullet_10             = 82,
        Bullet_11             = 83,
        Bullet_12             = 84,
        Bullet_13             = 85,
        Bullet_14             = 86,
        Bullet_15             = 87,
        Bullet_16             = 88,
        Bullet_17             = 89,
        Bullet_18             = 90,
        Bullet_19             = 91,
        Bullet_20             = 92,
        Bullet_21             = 93,
        Bullet_22             = 94,
        Bullet_23             = 95,
        Bullet_24             = 96,
        Bullet_25             = 97,
        Bullet_26             = 98,
        Bullet_27             = 99,
        Bullet_28             = 100,
        Bullet_29             = 101,
        Bullet_30             = 102,
        Boss_3                = 103,
        TrapEnemy_1           = 104,
        TrapEnemy_2           = 105,
        TrapEnemy_3           = 106,
        TrapEnemy_4           = 107,
        TrapEnemy_5           = 108,
        TrapEnemy_6           = 109,
        TrapEnemy_7           = 110,
        TrapEnemy_8           = 111,
        TrapEnemy_9           = 112,
        TrapEnemy_10          = 113,
        FxTrapExplode         = 114,
        TrapEnemy_11          = 115,
        TrapEnemy_12          = 116,
        TrapEnemy_13          = 117,
        TrapEnemy_14          = 118,
        FxRocketExplode       = 119,
        FxTextCritDamage      = 120,
    }

    public readonly static string[] PoolKey =
    {
        "0",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
        "25",
        "26",
        "27",
        "28",
        "29",
        "30",
        "31",
        "32",
        "33",
        "34",
        "35",
        "36",
        "37",
        "38",
        "39",
        "40",
        "41",
        "42",
        "43",
        "44",
        "45",
        "46",
        "47",
        "48",
        "49",
        "50",
        "51",
        "52",
        "53",
        "54",
        "55",
        "56",
        "57",
        "58",
        "59",
        "60",
        "61",
        "62",
        "63",
        "64",
        "65",
        "66",
        "67",
        "68",
        "69",
        "70",
        "71",
        "72",
        "73",
        "74",
        "75",
        "76",
        "77",
        "78",
        "79",
        "80",
        "81",
        "82",
        "83",
        "84",
        "85",
        "86",
        "87",
        "88",
        "89",
        "90",
        "91",
        "92",
        "93",
        "94",
        "95",
        "96",
        "97",
        "98",
        "99",
        "100",
        "101",
        "102",
        "103",
        "104",
        "105",
        "106",
        "107",
        "108",
        "109",
        "110",
        "111",
        "112",
        "113",
        "114",
        "115",
        "116",
        "117",
        "118",
        "119",
        "120",
    };

    public static string GetPoolKey (PoolId id)
    {
        return PoolKey[(int) id];
    }
}