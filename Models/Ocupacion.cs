using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class Ocupacion
{
    [Key]
    public int OcupacionID { get; set; }
    public string? Descripcion { get; set; }
    public double Salario { get; set; }
}