using System;
using System.IO;
using System.Text;
namespace Exemplo2Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 x;
            try
            {
                /*Agora o instanciamento do objeto mudou, tem três parâmetros:
                 * 1º caminho do arquivo, 2º true -> quer dizer que o arquivo é aberto no modo de anexação, ou seja, 
                 * vai sempre adicionando mais caracteres. Se for false, ele vai escrever por cima (como o exemplo anterior)
                 * e 3º  de modo que codifica o arquivo no formato StreamWriter Unicode. Você também pode especificar os seguintes métodos de codificação para o
                 * terceiro parâmetro: 
                 * ASC11, Unicode, UTF7, UTF8 */
                //StreamWriter sw = new StreamWriter("C:\\Teste\\Teste1.txt", true, Encoding.ASCII);
                StreamWriter sw = new StreamWriter("C:\\Teste\\Teste1.txt", true, Encoding.UTF8);

                //Escreve de 0 a 9 na mesma linha:
                for (x = 0; x < 10; x++)
                {
                    sw.WriteLine(x);
                }
                sw.WriteLine("E posso escrever texto também");

                //Fecha o arquivo
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o bloco finally.");
            }
        }
    }
}
