﻿namespace Domain.Entities;

public abstract class BaseEntity<T>
{
    [Key, Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public T? Id { get; set; }
}
