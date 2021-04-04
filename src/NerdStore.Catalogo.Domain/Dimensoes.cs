﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Validacoes.ValidarSeMenorIgualMinimo(altura, 1, "O campo Altura não pode ser menor ou igual a 1");
            Validacoes.ValidarSeMenorIgualMinimo(largura, 1, "O campo Largura não pode ser menor ou igual a 1");
            Validacoes.ValidarSeMenorIgualMinimo(profundidade, 1, "O campo Profundidade não pode ser menor ou igual a 1");

            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }

        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }
        public override string ToString()
        {
            return $"L: {Largura} x A: {Altura} x P: {Profundidade}";
        }

        public void Valid()
        {

        }
    }
}
