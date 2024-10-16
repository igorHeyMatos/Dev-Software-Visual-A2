using System;

namespace RafaelMarchelloVilla.Models;

public class Folha
{
    public int FolhaId { get; set; }
    public int Valor { get; set; }
    public int Quantidade { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public int FuncionarioId { get; set; }
}