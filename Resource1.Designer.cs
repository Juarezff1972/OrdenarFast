﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdenarFast {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OrdenarFast.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///constante Inteiro NUMERO_DE_BALDES = 128;
        ///
        ///Função Inteiro MaximoDigitos()
        ///inicio
        ///	Inteiro max = int.MinValue;
        ///	Inteiro temp = 0;
        ///	para (Inteiro i = 0; i &lt; vetor.Tamanho; i++)
        ///	inicio
        ///		temp = (Inteiro)(Math.Log(vetor[i].Valor) / Math.Log(NUMERO_DE_BALDES)) + 1;
        ///		Se (temp &gt; max)
        ///			max = temp;
        ///	fim
        ///	Retorne_Função max;
        ///fim
        ///
        ///Função Inteiro Digitos(Inteiro i, Inteiro d)
        ///inicio
        ///	Retorne_Função (i / d) % NUMERO_DE_BALDES;
        ///fim
        ///
        ///Procedimento AmericanSort(Inteiro inicio, Inteiro tam, Inteiro  [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string AmericanSortString {
            get {
                return ResourceManager.GetString("AmericanSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento BinaryInsertionSort()
        ///inicio
        ///	para (Inteiro i = 1; i &lt; vetor.Tamanho; ++i)
        ///	inicio
        ///		Inteiro chave = vetor[i].Valor;
        ///
        ///		Inteiro baixo = 0, alto = i;
        ///		Faça Enquanto (baixo &lt; alto)
        ///		inicio
        ///			Inteiro meio = (baixo + alto) / 2;
        ///			Se (chave &lt;= vetor[meio].Valor)
        ///			inicio
        ///				alto = meio;
        ///			fim
        ///			Senão
        ///			inicio
        ///				baixo = meio + 1;
        ///			fim
        ///		fim
        ///		Inteiro j = i - 1;
        ///		Faça Enquanto (j &gt;= baixo)
        ///		inicio
        ///			Troca(j, j + 1);
        ///			j--;
        ///		fim
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string BinaryInsertionSortString {
            get {
                return ResourceManager.GetString("BinaryInsertionSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento BitonicSort()
        ///inicio
        ///	BitonicSort(0, vetor.Tamanho, CRESCENTE);
        ///fim
        ///
        ///Procedimento Bitonic_compare(Inteiro i, Inteiro j, Booleano dir)
        ///inicio
        ///	Se (dir == (vetor[i].ComparaCom(vetor[j]) == 1))
        ///	inicio
        ///		Troca(i, j);
        ///	fim
        ///fim
        ///
        ///Procedimento BitonicMerge(Inteiro baixo, Inteiro n, Booleano dir)
        ///inicio
        ///	Se (n &gt; 1)
        ///	inicio
        ///		Inteiro m = MaiorPotenciaDeDoisMenorQue(n);
        ///		para (Inteiro i = baixo; i &lt; baixo + n - m; i++)
        ///		inicio
        ///			Bitonic_compare(i, i + m, dir);
        ///		fim
        ///
        ///		Bitonic [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string BitonicSortString {
            get {
                return ResourceManager.GetString("BitonicSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento BubbleSort2()
        ///inicio
        ///	Inteiro i;
        ///	Inteiro j;
        ///	Inteiro max;
        ///	Inteiro maxidx = 0;
        ///	para (i = vetor.Tamanho - 1; i &gt;= 0; i--)
        ///	inicio
        ///		max = 0;
        ///		para (j = 0; j &lt; i; j++)
        ///		inicio
        ///			Se (max &lt; vetor[j].Valor)
        ///			inicio
        ///				maxidx = j;
        ///			fim
        ///		fim
        ///		Se (vetor[i].ComparaCom(vetor[maxidx]) == -1)
        ///		inicio
        ///			Troca(i, maxidx);
        ///		fim
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string BubbleSort2String {
            get {
                return ResourceManager.GetString("BubbleSort2String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento BubbleSort3()
        ///inicio
        ///	Inteiro i;
        ///	Inteiro max;
        ///	Inteiro maxidx = 0;
        ///	Inteiro minidx = vetor.Tamanho - 1;
        ///	Inteiro min;
        ///	Inteiro inicio = 0;
        ///	Inteiro final = vetor.Tamanho;
        ///	Faça Enquanto (inicio &lt; final)
        ///	inicio
        ///		max = 0;
        ///		min = vetor.Max().Valor + 1;
        ///		para (i = inicio; i &lt; final; i++)
        ///		inicio
        ///			Se (max &lt; vetor[i].Valor)
        ///			inicio
        ///				max = vetor[i].Valor;
        ///				maxidx = i;
        ///			fim
        ///			Se (min &gt; vetor[i].Valor)
        ///			inicio
        ///				min = vetor[i].Valor;
        ///				minidx = i;
        ///			fi [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string BubbleSort3String {
            get {
                return ResourceManager.GetString("BubbleSort3String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento BubbleSort()
        ///inicio
        ///	para (Inteiro i = 0; i &lt; vetor.Tamanho - 1; ++i)
        ///	inicio
        ///		para (Inteiro j = 0; j &lt; vetor.Tamanho - 1 - i; ++j)
        ///		inicio
        ///			Se (vetor[j].ComparaCom(vetor[j + 1]) == 1)
        ///			inicio
        ///				Troca(j, j + 1);
        ///			fim
        ///		fim
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string BubbleSortString {
            get {
                return ResourceManager.GetString("BubbleSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento CocktailShakerSort()
        ///inicio
        ///	Inteiro baixo = 0;
        ///	Inteiro alto = vetor.Tamanho - 1;
        ///	Inteiro mov = baixo;
        ///
        ///	Faça Enquanto (baixo &lt; alto)
        ///	inicio
        ///		para (Inteiro i = alto; i &gt; baixo; --i)
        ///		inicio
        ///			Se (vetor[i - 1].ComparaCom(vetor[i]) == 1)
        ///			inicio
        ///				Troca(i - 1, i);
        ///				mov = i;
        ///			fim
        ///		fim
        ///		baixo = mov;
        ///
        ///		para (Inteiro i = baixo; i &lt; alto; ++i)
        ///		inicio
        ///			Se (vetor[i].ComparaCom(vetor[i + 1]) == 1)
        ///			inicio
        ///				Troca(i, i + 1);
        ///				mov = i;
        ///			fim
        ///		fim
        ///	 [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string CocktailShakerSortString {
            get {
                return ResourceManager.GetString("CocktailShakerSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento CombSort()
        ///inicio
        ///	constante Dupbaixo encolhe = 1.3;
        ///
        ///	Booleano Trocado = FALSO;
        ///	Inteiro fenda = vetor.Tamanho;
        ///	Faça Enquanto ((fenda &gt; 1) || Trocado)
        ///	inicio
        ///		Se (fenda &gt; 1)
        ///		inicio
        ///			fenda = (Inteiro)((PontoFlutuante)fenda / encolhe);
        ///		fim
        ///
        ///		Trocado = FALSO;
        ///
        ///		para (Inteiro i = 0; fenda + i &lt; vetor.Tamanho; ++i)
        ///		inicio
        ///			piv1.Value = i + fenda + 1;
        ///			Se (vetor[i].ComparaCom(vetor[i + fenda]) == 1)
        ///			inicio
        ///				Troca(i, i + fenda);
        ///				Trocado = VERDADEIRO;        /// [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string CombSortString {
            get {
                return ResourceManager.GetString("CombSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento CountingSort()
        ///inicio
        ///	Inteiro max = vetor.Tamanho - 1;
        ///	Inteiro mc = vetor.Max().Valor;
        ///	Longo[] cnt = new Longo[mc + 1];
        ///	Inteiro[] b = new Inteiro[max + 1];
        ///	Longo idx;
        ///
        ///	Inteiro j;
        ///
        ///	para (j = 0; j &lt;= max; j++)
        ///	inicio
        ///		Inteiro l = vetor[j].Valor;
        ///		cnt[l]++;
        ///		b[j] = vetor[j].Valor;
        ///	fim
        ///	para (Inteiro i = 1; i &lt;= mc; i++)
        ///	inicio
        ///		cnt[i] = cnt[i] + cnt[i - 1];
        ///	fim
        ///	para (j = max; j &gt;= 0; j--)
        ///	inicio
        ///		idx = vetor[j].Valor;
        ///		b[cnt[idx] - 1] = vetor[j].Valor;
        /// [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string CountingSortString {
            get {
                return ResourceManager.GetString("CountingSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento CycleSort()
        ///inicio
        ///	Inteiro inicio_ciclo;
        ///	Inteiro tmp;
        ///	para (inicio_ciclo = 0; inicio_ciclo &lt; vetor.Tamanho - 1; inicio_ciclo++)
        ///	inicio
        ///		Inteiro item = vetor[inicio_ciclo].Valor;
        ///		Inteiro pos = inicio_ciclo;
        ///
        ///		para (Inteiro i = inicio_ciclo + 1; i &lt; vetor.Tamanho; i++)
        ///		inicio
        ///			Se (vetor[i].Valor &lt; item)
        ///			inicio
        ///				pos++;
        ///			fim
        ///		fim
        ///
        ///		Se (pos != inicio_ciclo)
        ///		inicio
        ///			Faça Enquanto (item == vetor[pos].Valor)
        ///			inicio
        ///				pos++;
        ///			fim
        ///
        ///			tmp = vetor [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string CycleSortString {
            get {
                return ResourceManager.GetString("CycleSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento DiamondSort()
        ///inicio
        ///	Inteiro n = 1;
        ///	para (; n &lt; vetor.Tamanho; n *= 2) ;
        ///
        ///	Inteiro m = 4;
        ///	para (; m &lt;= n; m *= 2)
        ///	inicio
        ///		para (Inteiro k = 0; k &lt; m / 2; k++)
        ///		inicio
        ///			Inteiro cnt = k &lt;= m / 4 ? k : m / 2 - k;
        ///			para (Inteiro j = 0; j &lt; vetor.Tamanho; j += m)
        ///			inicio
        ///				Se (j + cnt + 1 &lt; vetor.Tamanho)
        ///				inicio
        ///					para (Inteiro i = j + cnt; i + 1 &lt; Math.Min(vetor.Tamanho, j + m - cnt); i += 2)
        ///					inicio
        ///						Se (vetor[i].Valor &gt; vetor[i + 1].Valor)
        ///						i [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string DiamondSortString {
            get {
                return ResourceManager.GetString("DiamondSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento FlashSort(Inteiro comprimento)
        ///inicio
        ///
        ///	Inteiro m = (Inteiro)((0.2 * comprimento) + 2);
        ///	Inteiro min, max, maxIndex;
        ///	min = max = vetor[0].Valor;
        ///	maxIndex = 0;
        ///
        ///
        ///	para (Inteiro i = 1; i &lt; comprimento - 1; i += 2)
        ///	inicio
        ///		Inteiro small;
        ///		Inteiro big;
        ///		Inteiro bigIndex;
        ///
        ///		Se (vetor[i].Valor &lt; vetor[i + 1].Valor)
        ///		inicio
        ///			small = vetor[i].Valor;
        ///			big = vetor[i + 1].Valor;
        ///			bigIndex = i + 1;
        ///		fim
        ///		Senão
        ///		inicio
        ///			big = vetor[i].Valor;
        ///			bigIndex = i;
        ///			 [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string FlashSortString {
            get {
                return ResourceManager.GetString("FlashSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento GnomeSort()
        ///inicio
        ///	para (Inteiro i = 1; i &lt; vetor.Tamanho;)
        ///	inicio
        ///		Se (vetor[i].ComparaCom(vetor[i - 1]) &gt;= 0) //Se for igual
        ///		inicio
        ///			++i;
        ///		fim
        ///		Senão
        ///		inicio
        ///			Troca(i, i - 1);
        ///			Se (i &gt; 1)
        ///			inicio
        ///				--i;
        ///			fim
        ///		fim
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string GnomeSortString {
            get {
                return ResourceManager.GetString("GnomeSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento GravitySort()
        ///inicio
        ///	Inteiro max = vetor.Max().Valor;
        ///	Array[] abacus;
        ///	Inteiro i;
        ///	Inteiro j;
        ///	Inteiro posicaoqueda;
        ///	Inteiro contagem;
        ///	Inteiro x;
        ///	Inteiro y;
        ///
        ///	abacus = new Array[vetor.Tamanho];
        ///	para (i = 0; i &lt; abacus.Tamanho; i++)
        ///	inicio
        ///		abacus[i] = new Inteiro[max];
        ///	fim
        ///	para (i = 0; i &lt; vetor.Tamanho; i++)
        ///	inicio
        ///		para (j = 0; j &lt; vetor[i].Valor; j++)
        ///		inicio
        ///			abacus[i].SetValue(1, abacus[0].Tamanho - j - 1);
        ///		fim
        ///	fim
        ///	para (i = 0; i &lt; abacus[0].Tama [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string GravitySortString {
            get {
                return ResourceManager.GetString("GravitySortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento HeapSort()
        ///inicio
        ///	Inteiro n = vetor.Tamanho, i = n / 2;
        ///	Duplo cores;
        ///
        ///	Faça Enquanto (VERDADEIRO)
        ///	inicio
        ///		Se (i &gt; 0)
        ///		inicio
        ///			i--;
        ///		fim
        ///		Senão
        ///		inicio
        ///			n--;
        ///			Se (n == 0)
        ///			inicio
        ///				Fim_Do_Procedimento;
        ///			fim
        ///
        ///			Troca(0, n);
        ///		fim
        ///
        ///		Inteiro noPai = i;
        ///		Inteiro noFilho = i * 2 + 1;
        ///
        ///		Faça Enquanto (noFilho &lt; n)
        ///		inicio
        ///			Se (noFilho + 1 &lt; n &amp;&amp; (vetor[noFilho + 1].ComparaCom(vetor[noFilho]) == 1))
        ///			inicio
        ///				noFilho++;
        ///			fim
        ///			Se (vetor [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string HeapSortString {
            get {
                return ResourceManager.GetString("HeapSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento InsertSort2()
        ///inicio
        ///	para (Inteiro i = 1; i &lt; vetor.Tamanho; ++i)
        ///	inicio
        ///		Inteiro tmp, chave = vetor[i].Valor;
        ///		Inteiro j = i - 1;
        ///		Faça Enquanto (j &gt;= 0 &amp;&amp; (tmp = vetor[j].Valor) &gt; chave)
        ///		inicio
        ///			vetor[j + 1].Valor = tmp;
        ///			j--;
        ///		fim
        ///		vetor[j + 1].Valor = chave;
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string InsertSort2String {
            get {
                return ResourceManager.GetString("InsertSort2String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento InsertSort()
        ///inicio
        ///	para (Inteiro i = 1; i &lt; vetor.Tamanho; ++i)
        ///	inicio
        ///		Inteiro chave = vetor[i].Valor;
        ///		Inteiro j = i - 1;
        ///		Faça Enquanto (j &gt;= 0 &amp;&amp; vetor[j].Valor &gt; chave)
        ///		inicio
        ///			Troca(j, j + 1);
        ///			j--;
        ///		fim
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string InsertSortString {
            get {
                return ResourceManager.GetString("InsertSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento Merge(Inteiro baixo, Inteiro meio, Inteiro alto)
        ///inicio
        ///	Inteiro[] outA;
        ///
        ///	outA = new Inteiro[alto - baixo];
        ///	Inteiro i = baixo; Inteiro j = meio; Inteiro o = 0; 
        ///	Faça Enquanto (i &lt; meio &amp;&amp; j &lt; alto)
        ///	inicio
        ///		Inteiro ai = vetor[i].Valor;
        ///		Inteiro aj = vetor[j].Valor;
        ///		Se (ai &lt; aj)
        ///		inicio
        ///			++i;
        ///			outA[o++] = ai;
        ///		fim
        ///		Senão
        ///		inicio
        ///			++j;
        ///			outA[o++] = aj;
        ///		fim
        ///	fim
        ///
        ///	Faça Enquanto (i &lt; meio)
        ///	inicio
        ///		outA[o++] = vetor[i++].Valor;
        ///	fim
        ///
        ///	Faça Enquanto [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string MergeSortString {
            get {
                return ResourceManager.GetString("MergeSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento OddEvenSort()
        ///inicio
        ///	Booleano ordenado = FALSO;
        ///	Faça Enquanto (!ordenado)
        ///	inicio
        ///		ordenado = VERDADEIRO;
        ///
        ///		para (Inteiro i = 1; i &lt; vetor.Tamanho - 1; i += 2)
        ///		inicio
        ///			Se (vetor[i].ComparaCom(vetor[i + 1]) == 1)
        ///			inicio
        ///				Troca(i, i + 1);
        ///				ordenado = FALSO;
        ///			fim
        ///			vetor[i].SetColorIDX(1);
        ///		fim
        ///
        ///		para (Inteiro i = 0; i &lt; vetor.Tamanho - 1; i += 2)
        ///		inicio
        ///			Se (vetor[i].ComparaCom(vetor[i + 1]) == 1)
        ///			inicio
        ///				Troca(i, i + 1);
        ///				ordenado = FALS [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string OddEvenSortString {
            get {
                return ResourceManager.GetString("OddEvenSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento Virar(Inteiro k)
        ///inicio
        ///	Inteiro esquerda = 0;
        ///	Faça Enquanto (esquerda &lt; k)
        ///	inicio
        ///		Troca(k, esquerda);
        ///		k--;
        ///		esquerda++;
        ///	fim
        ///fim
        ///
        ///Função Inteiro MaxIndex(Inteiro k)
        ///inicio
        ///	Inteiro index = 0;
        ///	para (Inteiro i = 0; i &lt; k; i++)
        ///	inicio
        ///		Se (vetor[i].ComparaCom(vetor[index]) == 1)
        ///		inicio
        ///			index = i;
        ///		fim
        ///	fim
        ///	Retorne_Função index;
        ///fim
        ///
        ///Procedimento PancakeSort(Inteiro n)
        ///inicio
        ///	Inteiro maxdex;
        ///	Faça Enquanto (n &gt; 1)
        ///	inicio
        ///		maxdex = MaxIndex(n);
        ///		 [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string PancakeSortString {
            get {
                return ResourceManager.GetString("PancakeSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento pigeonholeSort()
        ///inicio
        ///	Inteiro min = vetor[0].Valor;
        ///	Inteiro max = vetor[0].Valor;
        ///	Inteiro range, i, j, index;
        ///	Inteiro n = vetor.Tamanho;
        ///
        ///	para (Inteiro a = 0; a &lt; n; a++)
        ///	inicio
        ///		Se (vetor[a].Valor &gt; max)
        ///		inicio
        ///			max = vetor[a].Valor;
        ///		fim
        ///		Se (vetor[a].Valor &lt; min)
        ///		inicio
        ///			min = vetor[a].Valor;
        ///		fim
        ///	fim
        ///
        ///	range = max - min + 1;
        ///	Inteiro[] pigeonHoles = new Inteiro[range];
        ///
        ///	para (i = 0; i &lt; n; i++)
        ///	inicio
        ///		pigeonHoles[vetor[i].Valor - min]++;
        ///	 [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string PigeonHoleSortString {
            get {
                return ResourceManager.GetString("PigeonHoleSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento SetQuickSortPivot(string q)
        ///inicio
        ///	g_quicksort_pivot = q;
        ///fim
        ///
        ///Procedimento QuickSortDualPivot()
        ///inicio
        ///	QuickSortDualPivotYaroslavskiy(0, vetor.Tamanho - 1);
        ///fim
        ///
        ///Procedimento QuickSortLL()
        ///inicio
        ///	QuickSortLL(0, vetor.Tamanho);
        ///fim
        ///
        ///Procedimento QuickSortLR()
        ///inicio
        ///	QuickSortLR(0, vetor.Tamanho - 1);
        ///fim
        ///
        ///Procedimento QuickSortTernaryLR()
        ///inicio
        ///	QuickSortTernaryLR(0, vetor.Tamanho - 1);
        ///fim
        ///
        ///Procedimento QuickSortDualPivotYaroslavskiy(Inteiro esquerda, Inteiro di [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string QuickSortString {
            get {
                return ResourceManager.GetString("QuickSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento RadixSortLSD()
        ///inicio
        ///	constante Inteiro RADIX = 10;
        ///
        ///	uInteiro pmax = (uInteiro)Math.Ceiling(Math.Log(vetor.Max().Valor + 1) / Math.Log(RADIX));
        ///	para (uInteiro p1 = 0; p1 &lt; pmax; ++p1)
        ///	inicio
        ///		Inteiro base1 = (Inteiro)Potencia(RADIX, p1);
        ///
        ///		Inteiro[] contagem = new Inteiro[RADIX];
        ///		Inteiro[] copia = new Inteiro[vetor.Tamanho];
        ///
        ///		para (Inteiro i = 0; i &lt; vetor.Tamanho; ++i)
        ///		inicio
        ///			copia[i] = vetor[i].Valor;
        ///			Inteiro r = copia[i] / base1 % RADIX;
        ///			contagem[r]++;        /// [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string RadixSortLSDString {
            get {
                return ResourceManager.GetString("RadixSortLSDString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento RadixSortMSD(Inteiro baixo, Inteiro alto, Inteiro profundidade)
        ///inicio
        ///	constante uInteiro RADIX = 10;
        ///
        ///	uInteiro pmax = (uInteiro)ArredondaPraBaixo(Math.Log(vetor.Max().Valor + 1) / Math.Log(RADIX));
        ///	uInteiro base1 = (uInteiro)Potencia(RADIX, pmax - profundidade);
        ///
        ///	Inteiro[] contagem = new Inteiro[RADIX];
        ///
        ///	para (Inteiro i = baixo; i &lt; alto; ++i)
        ///	inicio
        ///		uInteiro r = (uInteiro)vetor[i].Valor / base1 % RADIX;
        ///		piv1.Value = i + 1;
        ///		contagem[r]++;
        ///	fim
        ///
        ///	Inteiro[] bkt = ne [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string RadixSortMSDString {
            get {
                return ResourceManager.GetString("RadixSortMSDString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento SandpaperSort()
        ///inicio
        ///	para (Inteiro i = 0; i &lt; vetor.Tamanho - 1; i++)
        ///	inicio
        ///		para (Inteiro j = i + 1; j &lt; vetor.Tamanho; j++)
        ///		inicio
        ///			Se (vetor[i].Valor &gt; vetor[j].Valor)
        ///			inicio
        ///				Troca(i, j);
        ///			fim
        ///		fim
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string SandpaperSortString {
            get {
                return ResourceManager.GetString("SandpaperSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento SelectionSort()
        ///inicio
        ///	para (Inteiro i = 0; i &lt; vetor.Tamanho - 1; ++i)
        ///	inicio
        ///		Inteiro jMin = i;
        ///		para (Inteiro j = i + 1; j &lt; vetor.Tamanho; ++j)
        ///		inicio
        ///			piv2.Value = j + 1;
        ///			Se (vetor[j].ComparaCom(vetor[jMin]) == -1)
        ///			inicio
        ///				jMin = j;
        ///			fim
        ///		fim
        ///
        ///		Troca(i, jMin);
        ///
        ///		Se (i &gt; 0)
        ///		inicio
        ///			vetor[i - 1].SetColorIDX(3);
        ///		fim
        ///
        ///		piv1.Value = i + 1;
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string SelectionSortString {
            get {
                return ResourceManager.GetString("SelectionSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento ShellSort()
        ///inicio
        ///	Inteiro[] incs = [1391376, 463792, 198768, 86961, 33936, 13776, 4592, 1968, 861, 336, 112, 48, 21, 7, 3, 1];
        ///	para (Inteiro k = 0; k &lt; 16; k++)
        ///	inicio
        ///		para (Inteiro h = incs[k], i = h; i &lt; vetor.Tamanho; i++)
        ///		inicio
        ///			Inteiro v = vetor[i].Valor;
        ///			Inteiro j = i;
        ///			Faça Enquanto (j &gt;= h &amp;&amp; vetor[j - h].Valor &gt; v)
        ///			inicio
        ///				vetor[j].Valor = vetor[j - h].Valor;
        ///				j -= h;
        ///			fim
        ///			vetor[j].Valor = v;
        ///		fim
        ///	fim
        ///fim
        ///.
        /// </summary>
        internal static string ShellSortString {
            get {
                return ResourceManager.GetString("ShellSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento SimplisticGravitySort()
        ///inicio
        ///	Inteiro[] aux;
        ///	Inteiro min = vetor[0].Valor;
        ///	Inteiro max = min;
        ///	Inteiro pointer;
        ///	Inteiro index;
        ///	Inteiro fator = vetor.Tamanho / 10;
        ///	para (Inteiro mainPointer = 1; mainPointer &lt; vetor.Tamanho; mainPointer++)
        ///	inicio
        ///		min = Math.Min(vetor[mainPointer].Valor, min);
        ///		max = Math.Max(vetor[mainPointer].Valor, max);
        ///	fim
        ///	aux = novo Inteiro[max - min];
        ///	para (Inteiro mainPointer = 0; mainPointer &lt; vetor.Tamanho; mainPointer++)
        ///	inicio
        ///		index = [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string SimplisticGravitySortString {
            get {
                return ResourceManager.GetString("SimplisticGravitySortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Procedimento SlowSort(Inteiro i, Inteiro j)
        ///inicio
        ///	Se (i &gt;= j)
        ///	inicio
        ///		Fim_Do_Procedimento;
        ///	fim
        ///
        ///	Inteiro m = (i + j) / 2;
        ///
        ///	piv1.Value = m + 1;
        ///
        ///	SlowSort(i, m);
        ///	SlowSort(m + 1, j);
        ///
        ///	Se (vetor[m].ComparaCom(vetor[j]) == 1)
        ///	inicio
        ///		Troca(m, j);
        ///	fim
        ///
        ///	SlowSort(i, j - 1);
        ///fim
        ///Procedimento SlowSort()
        ///inicio
        ///	SlowSort(0, vetor.Tamanho - 1);
        ///fim
        ///.
        /// </summary>
        internal static string SlowSortString {
            get {
                return ResourceManager.GetString("SlowSortString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a 
        ///Inteiro[] tmp;
        ///
        ///Função Inteiro vencedor(Inteiro pos1, Inteiro pos2)
        ///inicio
        ///	Inteiro u = pos1 &gt;= vetor.Tamanho ? pos1 : tmp[pos1];
        ///	Inteiro v = pos2 &gt;= vetor.Tamanho ? pos2 : tmp[pos2];
        ///	Se (tmp[u] &lt;= tmp[v]) Retorne_Função u;
        ///	Retorne_Função v;
        ///fim
        ///
        ///Procedimento criaArvore(ref Inteiro valor)
        ///inicio
        ///	para (Inteiro i = 0; i &lt; vetor.Tamanho; i++) tmp[vetor.Tamanho + i] = vetor[i].Valor;
        ///	para (Inteiro i = 2 * vetor.Tamanho - 1; i &gt; 1; i -= 2)
        ///	inicio
        ///		Inteiro k = i / 2;
        ///		Inteiro j = i - 1;        /// [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string TournamentSortString {
            get {
                return ResourceManager.GetString("TournamentSortString", resourceCulture);
            }
        }
    }
}
