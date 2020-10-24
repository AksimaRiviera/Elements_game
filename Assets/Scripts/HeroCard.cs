using System;
using UnityEngine;
using UnityEngine.UI;

public class HeroCard : MonoBehaviour, IHeroCard
{
    [SerializeField]
    Text _refInfo, _bodInfo,
         _intInfo, _wisInfo,
         _hitPointsInfo, _manaPointsInfo,
         _macInfo, _recHPInfo, _recMPInfo,
         _heroNameInfo;

    string IHeroCard.PlayerID => _playerID;

    string IHeroCard.HeroName => _heroName;

    int IHeroCard.Reflex { get => _reflex; set => throw new NotImplementedException(); }
    int IHeroCard.Body { get => _body; set => throw new NotImplementedException(); }
    int IHeroCard.Intellegence { get => _intellegence; set => throw new NotImplementedException(); }
    int IHeroCard.Wisdom { get => _wisdom; set => throw new NotImplementedException(); }
    int IHeroCard.Level { get => _level; set => throw new NotImplementedException(); }
    int IHeroCard.Money { get => _money; set => throw new NotImplementedException(); }

    float IHeroCard.Expirience { get => _expirience; set => throw new NotImplementedException(); }
    float IHeroCard.HitPoints { get => _hitPoints; set => throw new NotImplementedException(); }
    float IHeroCard.ManaPoints { get => _manaPoints; set => throw new NotImplementedException(); }
    float IHeroCard.MagicalArmorClass { get => _magicalAC; set => throw new NotImplementedException(); }
    float IHeroCard.RecoveryHitPoints { get => _recoveryHP; set => throw new NotImplementedException(); }
    float IHeroCard.RecoveryManaPoints { get => _recoveryMP; set => throw new NotImplementedException(); }

    private string _playerID;

    public string _heroName;

    internal int _reflex;
    internal int _body;
    internal int _intellegence;
    internal int _wisdom;
    internal int _level;
    internal int _money;

    internal float _expirience;
    internal float _hitPoints;
    internal float _manaPoints;
    internal float _magicalAC;
    internal float _recoveryHP;
    internal float _recoveryMP;

    private int AddReflex(CalcHeroParams calc)
    {
        return _reflex += calc._rCount;
    }

    public string TakeReflex()
    {
        string r = _reflex.ToString();
        return r;
    }

    public string TakeBody()
    {
        string b = _body.ToString();
        return b;
    }

    public string TakeIntellegence()
    {
        string i = _intellegence.ToString();
        return i;
    }

    public string TakeWisdom()
    {
        string w = _wisdom.ToString();
        return w;
    }

    public void AddingCharacteristics(int r, int b, int i, int w)
    {
        _reflex += r;
        _body += b;
        _intellegence += i;
        _wisdom += w;

        _refInfo.text = _reflex.ToString();
        _bodInfo.text = _body.ToString();
        _intInfo.text = _intellegence.ToString();
        _wisInfo.text = _wisdom.ToString();
    }

    public void InfoParams()
    {
        _hitPointsInfo.text = _hitPoints.ToString();
        _manaPointsInfo.text = _manaPoints.ToString();
        _macInfo.text = _magicalAC.ToString();
        _recHPInfo.text = _recoveryHP.ToString();
        _recMPInfo.text = _recoveryMP.ToString();
        _heroNameInfo.text = _heroName.ToString();
    }
}
