﻿using Avaloina_3_1.Models;

namespace Avaloina_3_1;

public class Service
{
    private static PostgresContext? _db;

    public static PostgresContext GetDbContext()
    {
        if (_db == null)
        {
            _db = new PostgresContext();
        }

        return _db;
    }
}