﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceReact.Dominio.Interfaces.Infra
{
    public interface IConnectionHandler
    {
        NpgsqlConnection Create(string connectionString = null);
    }
}
