﻿using System;
using System.Collections.Generic;

namespace Avaloina_3_1.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Birthdate { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? IdRole { get; set; }

    public virtual Role? IdRoleNavigation { get; set; }
}
