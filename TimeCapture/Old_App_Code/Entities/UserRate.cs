﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CompanyRate
/// </summary>
public class UserRateEntity
{
	private int _RateID;
    private string _UserID;
    private string _ValidFrom;
    private double _DefaultOnsite;
    private double _DefaultOffsite;
    private double _ProjectOnsite;
    private double _ProjectOffsite;
    private double _MiscOnsite;
    private double _MiscOffsite;
    private bool _Override;
    private bool _IsRoundingRecord;

    public int RateID
    {
        get
        {
            return _RateID;
        }

        set
        {
            _RateID = value;
        }
    }

    public string UserID
    {
        get
        {
            return _UserID;
        }

        set
        {
             _UserID = value;
        }
    }

    public string ValidFrom
    {
        get
        {
            return _ValidFrom;
        }

        set
        {
            _ValidFrom = value;
        }
    }

    public double DefaultOffsite
    {
        get
        {
            return _DefaultOffsite;
        }

        set
        {
            _DefaultOffsite = value;
        }
    }

    public double DefaultOnsite
    {
        get
        {
            return _DefaultOnsite;
        }

        set
        {
            _DefaultOnsite = value;
        }
    }

    public double ProjectOnsite
    {
        get
        {
            return _ProjectOnsite;
        }

        set
        {
            _ProjectOnsite = value;
        }
    }

    public double ProjectOffsite
    {
        get
        {
            return _ProjectOffsite;
        }

        set
        {
            _ProjectOffsite = value;
        }
    }

    public double MiscOnsite
    {
        get
        {
            return _MiscOnsite;
        }

        set
        {
            _MiscOnsite = value;
        }
    }

    public double MiscOffsite
    {
        get
        {
            return _MiscOffsite;
        }

        set
        {
            _MiscOffsite = value;
        }
    }

    public bool Override
    {
        get
        {
            return _Override;
        }

        set
        {
            _Override = value;
        }
    }

    public bool IsRoundingRecord
    {
        get
        {
            return _IsRoundingRecord;
        }

        set
        {
            _IsRoundingRecord = value;
        }
    }
}