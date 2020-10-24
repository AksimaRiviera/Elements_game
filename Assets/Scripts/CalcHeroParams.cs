using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CalcHeroParams : MonoBehaviour
{
    [SerializeField] Text RCount, BCount, ICount, WCount, CPoints;
    [SerializeField] InputField EnterName;

    internal int _rCount, _bCount, _iCount, _wCount, _CharPoints;

    private void Start()
    {
        _CharPoints = 40;
        CPoints.text = _CharPoints.ToString();
    }

    public void AddChar(HeroCard hero)
    {
        if (EnterName.text == null)
        {
            hero._heroName = "N/A";
        }
        else
        {
            hero._heroName = EnterName.text;
        }
        hero.AddingCharacteristics(_rCount, _bCount, _iCount, _wCount);
        CalcParams(hero);
        hero.InfoParams();
        Clear();
    }

    public void RecData(HeroCard hero)
    {
        string book = $"/Users/aksima/Desktop/{hero._heroName}.txt";
        FileStream ImpPen = new FileStream(book, FileMode.Create, FileAccess.Write);
        StreamWriter ImpAccount = new StreamWriter(ImpPen);
        ImpAccount.WriteLine($"Имя:\t{hero._heroName}");
        ImpAccount.WriteLine();
        ImpAccount.WriteLine($"Рефлексы:\t{hero._reflex}");
        ImpAccount.WriteLine($"Тело:\t{hero._body}");
        ImpAccount.WriteLine($"Интеллект:\t{hero._intellegence}");
        ImpAccount.WriteLine($"Мудрость:\t{hero._wisdom}");
        ImpAccount.WriteLine();
        ImpAccount.WriteLine($"Здоровье:\t{hero._hitPoints}");
        ImpAccount.WriteLine($"Мана:\t{hero._manaPoints}");
        ImpAccount.WriteLine($"Магическая броня:\t{hero._magicalAC}");
        ImpAccount.WriteLine($"Восстановление (здоровье/раунд):\t{hero._recoveryHP}");
        ImpAccount.WriteLine($"Восстановление (мана/раунд):\t{hero._recoveryMP}");
        ImpAccount.Close();
    }

    public void CalcParams(HeroCard heroCard)
    {
        heroCard._hitPoints = heroCard._body * 5f;
        heroCard._manaPoints = heroCard._wisdom * 7f;
        heroCard._magicalAC = heroCard._wisdom * 1.1f;
        heroCard._recoveryHP = heroCard._body * 0.15f;
        heroCard._recoveryMP = heroCard._wisdom * 0.2f;
    }

    //public void AddReflex(HeroCard hero)
    //{
    //    if (_CharPoints != 0)
    //    {
    //        hero._reflex++;
    //        _CharPoints--;
    //        CPoints.text = _CharPoints.ToString();
    //    }
    //}

    //public void AddBody(HeroCard hero)
    //{
    //    if (_CharPoints != 0)
    //    {
    //        hero._body++;
    //        _CharPoints--;
    //        CPoints.text = _CharPoints.ToString();
    //    }
    //}

    //public void AddIntellegence(HeroCard hero)
    //{
    //    if (_CharPoints != 0)
    //    {
    //        hero._intellegence++;
    //        _CharPoints--;
    //        CPoints.text = _CharPoints.ToString();
    //    }
    //}

    //public void AddWisdom(HeroCard hero)
    //{
    //    if (_CharPoints != 0)
    //    {
    //        hero._wisdom++;
    //        _CharPoints--;
    //        CPoints.text = _CharPoints.ToString();
    //    }
    //}

    public void AddReflex_alt()
    {
        if (_CharPoints != 0)
        {
            _rCount++;
            RCount.text = _rCount.ToString();
            _CharPoints--;
            CPoints.text = _CharPoints.ToString();
        }
    }

    public void AddBody_alt()
    {
        if (_CharPoints != 0)
        {
            _bCount++;
            BCount.text = _bCount.ToString();
            _CharPoints--;
            CPoints.text = _CharPoints.ToString();
        }
    }

    public void AddIntellegence_alt()
    {
        if (_CharPoints != 0)
        {
            _iCount++;
            ICount.text = _iCount.ToString();
            _CharPoints--;
            CPoints.text = _CharPoints.ToString();
        }
    }

    public void AddWisdom_alt()
    {
        if (_CharPoints != 0)
        {
            _wCount++;
            WCount.text = _wCount.ToString();
            _CharPoints--;
            CPoints.text = _CharPoints.ToString();
        }
    }

    private void Clear()
    {
        _rCount = 0;
        _bCount = 0;
        _iCount = 0;
        _wCount = 0;
        RCount.text = _rCount.ToString();
        BCount.text = _bCount.ToString();
        ICount.text = _iCount.ToString();
        WCount.text = _wCount.ToString();
    }
}

