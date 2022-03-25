﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Guid = System.Guid;

namespace Domain
{
    /// <summary>
    /// Базовый класс всех DDD сущностей.
    /// </summary>
    /// <typeparam name="TId">Тип идентификатора</typeparam>
    public class Entity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        
    }
}