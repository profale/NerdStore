using System;
using NerdStore.Core.DomainObjects;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            //Arrange & Act & Assert

            //Criando a entidade Produto e validando o nome
            var ex = Assert.Throws<DomainException>(() => new Produto(string.Empty, "Descricao", false, 100,
                DateTime.UtcNow, "Imagem", Guid.NewGuid(), new Dimensoes(1, 1, 1)));
            Assert.Equal("O campo Nome do produto não pode ser vazio", ex.Message);

            //Criando a entidade Produto e validando a descricao
            ex = Assert.Throws<DomainException>(() => new Produto("Produto1", string.Empty, false, 100,
                DateTime.UtcNow, "Imagem", Guid.NewGuid(), new Dimensoes(1, 1, 1)));

            Assert.Equal("O campo Descrição do produto não pode ser vazio", ex.Message);

            //Criando a entidade Produto e validando o valor
            ex = Assert.Throws<DomainException>(() => new Produto("Produto Teste Valor", "Descricao Teste Valor", false, 0, DateTime.UtcNow , "Imagem", Guid.NewGuid(), new Dimensoes(1, 1, 1)));

            Assert.Equal("O campo Valor do produto não pode ser menor igual a 0", ex.Message);

            //Criando a entidade Produto e validando a Categoria
            ex = Assert.Throws<DomainException>(() => new Produto("Produto Teste Categoria",
                "Descricao Teste Categoria", false, 100, DateTime.UtcNow, "Imagem", Guid.Empty,
                new Dimensoes(1, 1, 1)));
            Assert.Equal("O campo CategoriaId não pode estar vazio", ex.Message);

            //Criando a entidade Produto e validando a Imagem
            ex = Assert.Throws<DomainException>(() => new Produto("Produto Teste Imagem", "Descricao Teste Imagem",
                false, 100, DateTime.UtcNow, string.Empty, Guid.NewGuid(), new Dimensoes(1, 1, 1)));

            Assert.Equal("O campo Imagem do produto não pode estar vazio", ex.Message);

            //Criando a entidade Produto e validando a Dimensao
            ex = Assert.Throws<DomainException>(() => new Produto("Produto Teste Dimensão", "Descricao Teste Dimensão",
                false, 100, DateTime.UtcNow, string.Empty, Guid.NewGuid(), new Dimensoes(0, 1, 1)));

            Assert.Equal("O campo Altura não pode ser menor ou igual a 0", ex.Message);
        }
    }
}
