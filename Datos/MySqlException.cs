﻿// ***********************************************************************
// Assembly         : Datos
// Author           : USUARIO
// Created          : 02-20-2022
//
// Last Modified By : USUARIO
// Last Modified On : 02-20-2022
// ***********************************************************************
// <copyright file="Conexion.cs" company="">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.Serialization;

namespace Datos {
  [Serializable]
  internal class MySqlException:Exception {
    public MySqlException() {
    }

    public MySqlException(string message) : base(message) {
    }

    public MySqlException(string message,Exception innerException) : base(message,innerException) {
    }

    protected MySqlException(SerializationInfo info,StreamingContext context) : base(info,context) {
    }
  }
}