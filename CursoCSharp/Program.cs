using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //FUNDAMENTOS
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Converter - Fundamentos", Convercoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operações Relacionais - Fundamentos", OperacoesRelacionais.Executar},
                {"Operações Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
                
                //ESTRUTURAS DE CONTROLE
                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar},
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE/IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura SWITCH - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura WHILE - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura DO WHILE - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura FOREACH - Estruturas de Controle", EstruturaForeach.Executar},
                {"Estrutura BREAK - Estruturas de Controle", EstruturaBreak.Executar},
                {"Estrutura CONTINUE - Estruturas de Controle", EstruturaContinue.Executar},

                //CLASSES E METODOS
                {"MEMBROS - Classes e Métodos", Membros.Executar},
                {"CONSTRUTORES - Classes e Métodos", Construtores.Executar},
                {"METODOS COM RETORNO - Classes e Métodos", MetodosComRetorno.Executar},
                {"METODOS ESTATICOS - Classes e Métodos", MetodosEstaticos.Executar},
                {"ATRIBUTOS ESTATICOS - Classes e Métodos", AtributosEstaticos.Executar},
                {"DESAFIO ATRIBUTO - Classes e Métodos", DesafioAtributo.Executar},
                {"PARAMS - Classes e Métodos", Params.Executar},
                {"PARAMETROS NOMEADOS - Classes e Métodos", ParametrosNomeados.Executar},
                {"GET E SET - Classes e Métodos", GetSet.Executar},
                {"PROPS - Classes e Métodos", Props.Executar},
                {"READONLY - Classes e Métodos", Readonly.Executar},
                {"EXEMPLO ENUM - Classes e Métodos", ExemploEnum.Executar},
                {"STRUCT - Classes e Métodos", ExemploStruct.Executar},
                {"STRUCT VS CLASSE - Classes e Métodos", StructVsClasse.Executar},
                {"VALOR VS REFERENCIA - Classes e Métodos", ValorVsReferencia.Executar},
                {"PARAMETROS POR REFERENCIA - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"PARAMETRO PADRÃO - Classes e Métodos", ParametroPadrao.Executar},

                //COLEÇÕES
                {"ARRAY - Coleções", Colecoes.Array.Executar},
                {"LIST - Coleções", ColecoesList.Executar},
                {"ARRAYLIST - Coleções", ColecoesArrayList.Executar},
                {"SET - Coleções", ColecoesSet.Executar},
                {"QUEUE - Coleções", ColecoesQueue.Executar},
                {"IGUALDADE - Coleções", Igualdade.Executar},
                {"STACK - Coleções", ColecaoStack.Executar},
                {"DICTIONARY - Coleções", ColecoesDictionary.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}