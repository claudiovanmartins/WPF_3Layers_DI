//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produtos
    {
        public int Codigo { get; set; }
        public string Produto { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> cdTipoProduto { get; set; }
        public Nullable<int> cdCF { get; set; }
        public Nullable<decimal> PesoBruto { get; set; }
        public Nullable<decimal> PesoLiquido { get; set; }
        public string CodigoBarra { get; set; }
        public Nullable<int> cdUnidade { get; set; }
        public string Status { get; set; }
        public Nullable<int> cdComprador { get; set; }
        public Nullable<int> cdLocalizacao { get; set; }
        public Nullable<decimal> EstoqueFisico { get; set; }
        public string OrigemProduto { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<System.DateTime> DataUltCompra { get; set; }
        public Nullable<System.DateTime> DataUltRecebimento { get; set; }
        public Nullable<decimal> QtdeInventario { get; set; }
        public string InventarioAtualizado { get; set; }
        public Nullable<int> LinhaProduto { get; set; }
        public Nullable<int> FamiliaProduto { get; set; }
        public Nullable<decimal> CustoMedio { get; set; }
        public Nullable<decimal> EstoqueMinimo { get; set; }
        public Nullable<decimal> PontoPedido { get; set; }
        public Nullable<decimal> MaiorPrecoCompra { get; set; }
        public string Referencia { get; set; }
        public Nullable<decimal> Comissao { get; set; }
        public Nullable<decimal> CustoTotalMarkup { get; set; }
        public Nullable<decimal> Espessura { get; set; }
        public Nullable<decimal> LarguraProduto { get; set; }
        public Nullable<decimal> Comprimento { get; set; }
        public Nullable<decimal> PesoProduto { get; set; }
        public Nullable<decimal> DiamInterno { get; set; }
        public Nullable<decimal> DiamExterno { get; set; }
        public string Obs1 { get; set; }
        public string Obs2 { get; set; }
        public string Obs3 { get; set; }
        public string Obs4 { get; set; }
        public string Obs5 { get; set; }
        public Nullable<decimal> Mk01 { get; set; }
        public Nullable<decimal> Mk02 { get; set; }
        public Nullable<decimal> Mk03 { get; set; }
        public Nullable<decimal> Mk04 { get; set; }
        public Nullable<decimal> Mk05 { get; set; }
        public Nullable<decimal> Pb01 { get; set; }
        public Nullable<decimal> Pb02 { get; set; }
        public Nullable<decimal> Pb03 { get; set; }
        public Nullable<decimal> Pb04 { get; set; }
        public Nullable<decimal> Pb05 { get; set; }
        public Nullable<decimal> CustoFabricacao { get; set; }
        public string BaixaEstoque { get; set; }
        public Nullable<decimal> CustoGeralMarkup { get; set; }
        public string CodigoProdutoPai { get; set; }
        public string Componente { get; set; }
        public Nullable<decimal> CodigoBarraInterno { get; set; }
        public string BaixaEstoqueOS { get; set; }
        public string UtilizacaoProduto { get; set; }
        public string ProdutoImportado { get; set; }
        public string BaixaEstoqueIntermediario { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> UltimoOrcamento { get; set; }
        public Nullable<System.DateTime> UltimaMovimentacao { get; set; }
        public string AtualizaEstoque { get; set; }
        public Nullable<decimal> CodigoBarraPCP { get; set; }
        public Nullable<decimal> UltimoPrecoCompra { get; set; }
        public Nullable<decimal> PontoPedidoCompra { get; set; }
        public Nullable<decimal> QtdeOCAuto { get; set; }
        public string EspecificacaoProduto { get; set; }
        public string NrDesenho { get; set; }
        public Nullable<decimal> Largura { get; set; }
        public Nullable<decimal> PesoEspecifico { get; set; }
        public Nullable<decimal> CustoReposicao { get; set; }
        public Nullable<int> TipoImposto { get; set; }
        public Nullable<int> CodigoTamanhoBarril { get; set; }
        public Nullable<decimal> VlrComodato { get; set; }
        public Nullable<int> CodigoSaborChop { get; set; }
        public string CodigoBarraVenda { get; set; }
        public string CodigoSistemaRede { get; set; }
        public Nullable<decimal> QtdeLitros { get; set; }
        public Nullable<System.DateTime> DataUltimoInventario { get; set; }
    }
}
