using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CloneTermooo
{
    public partial class Termo : Window
    {
        // Variável do tipo random que irá fazer o sorteio da palavra dentro do arquivo
        Random rnd = new Random();

        // Variável parâmetro para última letra do botão
        int contarLetrasBotoes = 0;
        // Posição da letra
        int letterIndex;
        // Posição da palavra
        int wordIndex;
        // Variável onde fica a palavra correta do game
        string palavraCerta = "";
        // Variável onde fica a palavra digitada pelo usuário
        string palavraDigitada = "";
        // Diretório das palavras
        string caminho = $"{Environment.CurrentDirectory}\\words5letters.txt";
        // Variável que irá receber o nome do botão
        string nomeBotao = "";
        // Lista com as palavras lidas no arquivo
        List<string> listaPalavras = new List<string>();

        // Variáveis das cores
        SolidColorBrush corRight = new SolidColorBrush(Color.FromArgb(255, 58, 163, 148));
        SolidColorBrush corAlmost = new SolidColorBrush(Color.FromArgb(255, 211, 173, 105));
        SolidColorBrush corNaoTem = new SolidColorBrush(Color.FromArgb(255, 49, 42, 44));
        SolidColorBrush corReset = new SolidColorBrush(Color.FromArgb(255, 110, 92, 98));
        SolidColorBrush corBordaReset = new SolidColorBrush(Color.FromArgb(255, 76, 67, 71));
        SolidColorBrush corParaReiniciar = new SolidColorBrush(Color.FromArgb(255, 97, 84, 88));
        LinearGradientBrush corRightAndAlmost = new LinearGradientBrush(Color.FromArgb(255, 211, 173, 105), Color.FromArgb(255, 58, 163, 148), new Point(0.5, 0), new Point(0.5, 1));

        public Termo()
        {
            InitializeComponent();
            ReiniciarJogo();
            SortearPalavra();
        }

        private void DigitarLetra(object sender, RoutedEventArgs e)
        {
            // Identifico qual botão foi apertado
            nomeBotao = ((Button)sender).Name;
            foreach (char c in nomeBotao)
            {
                contarLetrasBotoes++;
                // Verifica se já chegou na última letra do nome do botão, que é a letra correspondenete a cada um
                if (contarLetrasBotoes == 4)
                {
                    // Lógica para adicionar letras na primeira linha (A)
                    if (wordIndex == 0)
                    {
                        // Condição para saber em qual posição a letra deve se digitada
                        if (letterIndex == 0)
                        {
                            // Preenche o campo de texto com a ultima(4º) letra do nome do botão
                            txtCampoA1.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 1)
                        {
                            txtCampoA2.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 2)
                        {
                            txtCampoA3.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 3)
                        {
                            txtCampoA4.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 4)
                        {
                            txtCampoA5.Text = c.ToString();
                            letterIndex++;
                        }
                        break;
                    }
                    // Lógica para adicionar letras na segunda linha (B)
                    else if (wordIndex == 1)
                    {
                        if (letterIndex == 0)
                        {
                            txtCampoB1.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 1)
                        {
                            txtCampoB2.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 2)
                        {
                            txtCampoB3.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 3)
                        {
                            txtCampoB4.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 4)
                        {
                            txtCampoB5.Text = c.ToString();
                            letterIndex++;
                        }
                        break;
                    }
                    // Lógica para adicionar letras na terceira linha (C)
                    else if (wordIndex == 2)
                    {
                        if (letterIndex == 0)
                        {
                            txtCampoC1.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 1)
                        {
                            txtCampoC2.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 2)
                        {
                            txtCampoC3.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 3)
                        {
                            txtCampoC4.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 4)
                        {
                            txtCampoC5.Text = c.ToString();
                            letterIndex++;
                        }
                        break;
                    }
                    // Lógica para adicionar letras na quarta linha (D)
                    else if (wordIndex == 3)
                    {
                        if (letterIndex == 0)
                        {
                            txtCampoD1.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 1)
                        {
                            txtCampoD2.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 2)
                        {
                            txtCampoD3.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 3)
                        {
                            txtCampoD4.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 4)
                        {
                            txtCampoD5.Text = c.ToString();
                            letterIndex++;
                        }
                        break;
                    }
                    // Lógica para adicionar letras na quinta linha (E)
                    else if (wordIndex == 4)
                    {
                        if (letterIndex == 0)
                        {
                            txtCampoE1.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 1)
                        {
                            txtCampoE2.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 2)
                        {
                            txtCampoE3.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 3)
                        {
                            txtCampoE4.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 4)
                        {
                            txtCampoE5.Text = c.ToString();
                            letterIndex++;
                        }
                        break;
                    }
                    // Lógica para adicionar letras na sexta linha (F)
                    else if (wordIndex == 5)
                    {
                        if (letterIndex == 0)
                        {
                            txtCampoF1.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 1)
                        {
                            txtCampoF2.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 2)
                        {
                            txtCampoF3.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 3)
                        {
                            txtCampoF4.Text = c.ToString();
                            letterIndex++;
                        }
                        else if (letterIndex == 4)
                        {
                            txtCampoF5.Text = c.ToString();
                            letterIndex++;
                        }
                        break;
                    }
                }
            }
            contarLetrasBotoes = 0;
        }

        private void ApagarLetra(object sender, RoutedEventArgs e)
        {
            // Lógica para apagar campos da primeira linha (A)
            if (wordIndex == 0)
            {
                if (txtCampoA5.Text != "")
                {
                    txtCampoA5.Text = "";
                    letterIndex--;
                }
                else if (txtCampoA4.Text != "")
                {
                    txtCampoA4.Text = "";
                    letterIndex--;
                }
                else if (txtCampoA3.Text != "")
                {
                    txtCampoA3.Text = "";
                    letterIndex--;
                }
                else if (txtCampoA2.Text != "")
                {
                    txtCampoA2.Text = "";
                    letterIndex--;
                }
                else if (txtCampoA1.Text != "")
                {
                    txtCampoA1.Text = "";
                    letterIndex--;
                }
            }
            // Lógica para apagar campos da segunda linha (B)
            else if (wordIndex == 1)
            {
                if (txtCampoB5.Text != "")
                {
                    txtCampoB5.Text = "";
                    letterIndex--;
                }
                else if (txtCampoB4.Text != "")
                {
                    txtCampoB4.Text = "";
                    letterIndex--;
                }
                else if (txtCampoB3.Text != "")
                {
                    txtCampoB3.Text = "";
                    letterIndex--;
                }
                else if (txtCampoB2.Text != "")
                {
                    txtCampoB2.Text = "";
                    letterIndex--;
                }
                else if (txtCampoB1.Text != "")
                {
                    txtCampoB1.Text = "";
                    letterIndex--;
                }
            }
            // Lógica para apagar campos da terceira linha (C)
            else if (wordIndex == 2)
            {
                if (txtCampoC5.Text != "")
                {
                    txtCampoC5.Text = "";
                    letterIndex--;
                }
                else if (txtCampoC4.Text != "")
                {
                    txtCampoC4.Text = "";
                    letterIndex--;
                }
                else if (txtCampoC3.Text != "")
                {
                    txtCampoC3.Text = "";
                    letterIndex--;
                }
                else if (txtCampoC2.Text != "")
                {
                    txtCampoC2.Text = "";
                    letterIndex--;
                }
                else if (txtCampoC1.Text != "")
                {
                    txtCampoC1.Text = "";
                    letterIndex--;
                }
            }
            // Lógica para apagar campos da quarta linha (D)
            else if (wordIndex == 3)
            {
                if (txtCampoD5.Text != "")
                {
                    txtCampoD5.Text = "";
                    letterIndex--;
                }
                else if (txtCampoD4.Text != "")
                {
                    txtCampoD4.Text = "";
                    letterIndex--;
                }
                else if (txtCampoD3.Text != "")
                {
                    txtCampoD3.Text = "";
                    letterIndex--;
                }
                else if (txtCampoD2.Text != "")
                {
                    txtCampoD2.Text = "";
                    letterIndex--;
                }
                else if (txtCampoD1.Text != "")
                {
                    txtCampoD1.Text = "";
                    letterIndex--;
                }
            }
            // Lógica para apagar campos da quinta linha (E)
            else if (wordIndex == 4)
            {
                if (txtCampoE5.Text != "")
                {
                    txtCampoE5.Text = "";
                    letterIndex--;
                }
                else if (txtCampoE4.Text != "")
                {
                    txtCampoE4.Text = "";
                    letterIndex--;
                }
                else if (txtCampoE3.Text != "")
                {
                    txtCampoE3.Text = "";
                    letterIndex--;
                }
                else if (txtCampoE2.Text != "")
                {
                    txtCampoE2.Text = "";
                    letterIndex--;
                }
                else if (txtCampoE1.Text != "")
                {
                    txtCampoE1.Text = "";
                    letterIndex--;
                }
            }
            // Lógica para apagar campos da sexta linha(F)
            else if (wordIndex == 5)
            {
                if (txtCampoF5.Text != "")
                {
                    txtCampoF5.Text = "";
                    letterIndex--;
                }
                else if (txtCampoF4.Text != "")
                {
                    txtCampoF4.Text = "";
                    letterIndex--;
                }
                else if (txtCampoF3.Text != "")
                {
                    txtCampoF3.Text = "";
                    letterIndex--;
                }
                else if (txtCampoF2.Text != "")
                {
                    txtCampoF2.Text = "";
                    letterIndex--;
                }
                else if (txtCampoF1.Text != "")
                {
                    txtCampoF1.Text = "";
                    letterIndex--;
                }
            }

        }

        private void ConfirmarEnter(object sender, RoutedEventArgs e)
        {
            VerificarSePalavraExiste();
            VerificarSeGanhouOuNao();
        }

        private void SortearPalavra()
        {
            bool existeArquivo = File.Exists(caminho);

            if (existeArquivo == true)
            {
                var linhas = File.ReadLines(caminho);
                foreach (string linha in linhas)
                {
                    // Adiciona a informação na lista de palavras em MAÍSCULO por conta das letras dos campos serem também
                    listaPalavras.Add(linha.ToUpper());
                }

                var valorAleatorio = rnd.Next(0, listaPalavras.Count - 1);
                var randString = listaPalavras[valorAleatorio];
                palavraCerta = randString;
            }
        }

        private void VerificarSePalavraExiste()
        {
            // Lógica para obter palavra digitada na primeira linha (A)
            if (wordIndex == 0)
            {
                palavraDigitada = txtCampoA1.Text + txtCampoA2.Text + txtCampoA3.Text + txtCampoA4.Text + txtCampoA5.Text;
            }
            // Lógica para obter palavra digitada na segunda linha (B)
            else if (wordIndex == 1)
            {
                palavraDigitada = txtCampoB1.Text + txtCampoB2.Text + txtCampoB3.Text + txtCampoB4.Text + txtCampoB5.Text;
            }
            // Lógica para obter palavra digitada na terceira linha (C)
            else if (wordIndex == 2)
            {
                palavraDigitada = txtCampoC1.Text + txtCampoC2.Text + txtCampoC3.Text + txtCampoC4.Text + txtCampoC5.Text;
            }
            // Lógica para obter palavra digitada na quarta linha (D)
            else if (wordIndex == 3)
            {
                palavraDigitada = txtCampoD1.Text + txtCampoD2.Text + txtCampoD3.Text + txtCampoD4.Text + txtCampoD5.Text;
            }
            // Lógica para obter palavra digitada na quinta linha (E)
            else if (wordIndex == 4)
            {
                palavraDigitada = txtCampoE1.Text + txtCampoE2.Text + txtCampoE3.Text + txtCampoE4.Text + txtCampoE5.Text;
            }
            // Lógica para obter palavra digitada na sexta linha (F)
            else if (wordIndex == 5)
            {
                palavraDigitada = txtCampoF1.Text + txtCampoF2.Text + txtCampoF3.Text + txtCampoF4.Text + txtCampoF5.Text;
            }

            if (listaPalavras.Contains(palavraDigitada) == false)
            {
                MessageBoxResult result = MessageBox.Show(
                "Palavra inválida!",
                "Atenção!",
                MessageBoxButton.OK,
                MessageBoxImage.Warning
            );
                palavraDigitada = "";
            }
            else
            {
                VerificarLetrasCertasOuErradas();
                wordIndex++;
                letterIndex = 0;
            }
        }

        private void VerificarSeGanhouOuNao()
        {
            if (palavraDigitada == palavraCerta)
            {
                if (wordIndex == 1)
                {
                    MessageBoxResult result = MessageBox.Show(
                        $"Você acertou a palavra com: \n {wordIndex} tentativa.",
                        "Parabéns!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                    );
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show(
                        $"Você acertou a palavra com: \n {wordIndex} tentativas.",
                        "Parabéns!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                    );
                }
                ReiniciarJogo();
            }
            else
            {
                AjustarCampos();
            }
            if (wordIndex == 6)
            {
                MessageBoxResult result = MessageBox.Show(
                        $"Não foi dessa vez! \n a palavra era: {palavraCerta}.",
                        "Ops!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                 );
                 ReiniciarJogo();
            }
        }

        private void VerificarLetrasCertasOuErradas()
        {
            // Listas que contém todas as textBoxs separadas por linha
            List<TextBox> ListaTextBoxsPrimeiraLinha = new List<TextBox>() {txtCampoA1, txtCampoA2, txtCampoA3, txtCampoA4, txtCampoA5 };
            List<TextBox> ListaTextBoxsSegundaLinha = new List<TextBox>() {txtCampoB1, txtCampoB2, txtCampoB3, txtCampoB4, txtCampoB5 };
            List<TextBox> ListaTextBoxsTerceiraLinha = new List<TextBox>() {txtCampoC1, txtCampoC2, txtCampoC3, txtCampoC4, txtCampoC5 };
            List<TextBox> ListaTextBoxsQuartaLinha = new List<TextBox>() {txtCampoD1, txtCampoD2, txtCampoD3, txtCampoD4, txtCampoD5 };
            List<TextBox> ListaTextBoxsQuintaLinha = new List<TextBox>() {txtCampoE1, txtCampoE2, txtCampoE3, txtCampoE4, txtCampoE5 };
            List<TextBox> ListaTextBoxsSextaLinha = new List<TextBox>() {txtCampoF1, txtCampoF2, txtCampoF3, txtCampoF4, txtCampoF5 };

            // Lista com os botoes presentes no layout
            List<Button> listaBotoes = new List<Button>() {btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI,
            btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ};

            // Váriavel que irá receber o nome do botão
            string auxilioAcharBotao = "";

            // Crio uma nova string com a palavra certa
            string newWord = palavraCerta;
            // Crio um vetor de caracteres que irá recer a nova string da palavra certa, pois assim consigo ver letra por letra da palavra certa
            char[] newWordArray = newWord.ToCharArray();       

            // Lista que irá armazenar as posições das letras certas de acordo com índice
            List<int> letrasCertas = new List<int>();

            int contadorLetrasIguais = 0;
            string letrasIguais = "";

            int contadorParaSaberACorDoBotao = 0;

            /*==============================================
                     LÓGICA PARA A PRIMEIRA LINHA (A)
            ===============================================*/
            if (wordIndex == 0)
            {
                // Faço um for para ter um parâmetro verificador dos caracteres
                for (int i = 0; i < 5; i++)
                {
                    // Verifico se a letra da palavra digitada é igual a letra da palavra certa
                    if (palavraDigitada[i] == palavraCerta[i])
                    {
                        // Pinta o textBox que possui a letra correta de verde, ajusto a borda e os botões
                        ListaTextBoxsPrimeiraLinha[i].Background = corRight;
                        ListaTextBoxsPrimeiraLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                        // Váriavel que irá receber o nome do botão
                        auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                        // Percorro a lista dos botões até achar o correspondente ao nome
                        foreach (Button btn in listaBotoes)
                        {
                            // Verifico se é igual ao nome
                            if (btn.Name == auxilioAcharBotao)
                            {
                                // Pinto o fundo e a borda da cor verde]
                                btn.Background = corRight;
                                btn.BorderBrush = null;
                                break;
                            }
                        }

                        // Substituo a letra que já certa por um espaço vazio, para assim não cair na lógica debaixo e ser pintada de amarelo
                        newWordArray[i] = ' ';
                        // Adiciono o índice da letra certa na lista de letras certas
                        letrasCertas.Add(i);
                    }
                }

                // A nova string de palavra certa irá receber a nova string que era o vetor de caracteres
                newWord = new string(newWordArray);

                for (int i = 0; i < 5; i++)
                {
                    // Verifico se não há alguma letra certa, se tiver não preciso fazer nada com ela, pois já foi feito no for de cima
                    if (!letrasCertas.Contains(i))
                    {
                        // Verifico se a palavra certa possui alguma letra da palavra digitada
                        if (newWord.Contains(palavraDigitada[i]))
                        {
                            contadorLetrasIguais++;
                            letrasIguais += palavraDigitada[i].ToString();

                            // Pinta o textBox que possui a letra de amarelo, ajusto a borda e os botões
                            ListaTextBoxsPrimeiraLinha[i].Background = corAlmost;
                            ListaTextBoxsPrimeiraLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            // Váriavel que irá receber o nome do botão
                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                            // Percorro a lista dos botões até achar o correspondente ao nome
                            foreach (Button btn in listaBotoes)
                            {
                                // Verifico se é igual ao nome
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    foreach (char k in palavraCerta)
                                    {
                                        if (palavraCerta.Contains(palavraDigitada[i]))
                                        {
                                            contadorParaSaberACorDoBotao++;
                                        }
                                    }

                                    if (btn.Background == corRight && contadorParaSaberACorDoBotao < 1)
                                    {
                                        btn.Background = corRightAndAlmost;
                                        btn.BorderBrush = null;
                                    }
                                    else if (btn.Background != corRight)
                                    {
                                        btn.Background = corAlmost;
                                        btn.BorderBrush = null;
                                        break;
                                    }
                                }
                            }

                            if (contadorLetrasIguais > 1)
                            {
                                if(palavraDigitada[i].ToString() == letrasIguais[0].ToString())
                                {
                                    // Pinta o textBox que não possui a letra de preto/corEscura, ajusto a borda e os botões
                                    ListaTextBoxsPrimeiraLinha[i].Background = corNaoTem;
                                    ListaTextBoxsPrimeiraLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                                    // Váriavel que irá receber o nome do botão
                                    auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                                    // Percorro a lista dos botões até achar o correspondente ao nome
                                    foreach (Button btn in listaBotoes)
                                    {
                                        // Verifico se é igual ao nome
                                        if (btn.Name == auxilioAcharBotao)
                                        {
                                            if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                            {
                                                // Diminuo a opacidade do botão para 50%
                                                btn.Opacity = .50;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            // Pinta o textBox que não possui a letra de preto/corEscura, ajusto a borda e os botões
                            ListaTextBoxsPrimeiraLinha[i].Background = corNaoTem;
                            ListaTextBoxsPrimeiraLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                    {
                                        // Diminuo a opacidade do botão para 50%
                                        btn.Opacity = .50;
                                        break;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            /*==============================================
                     LÓGICA PARA A SEGUNDA LINHA (B)
            ===============================================*/
            else if (wordIndex == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (palavraDigitada[i] == palavraCerta[i])
                    {
                        ListaTextBoxsSegundaLinha[i].Background = corRight;
                        ListaTextBoxsSegundaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                        auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                        foreach (Button btn in listaBotoes)
                        {
                            if (btn.Name == auxilioAcharBotao)
                            {
                                btn.Background = corRight;
                                btn.BorderBrush = corRight;
                                break;
                            }
                        }
                        newWordArray[i] = ' ';
                        letrasCertas.Add(i);
                    }
                }

                newWord = new string(newWordArray);

                for (int i = 0; i < 5; i++)
                {
                    if (!letrasCertas.Contains(i))
                    {
                        if (newWord.Contains(palavraDigitada[i]))
                        {
                            contadorLetrasIguais++;
                            letrasIguais += palavraDigitada[i].ToString();

                            ListaTextBoxsSegundaLinha[i].Background = corAlmost;
                            ListaTextBoxsSegundaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    foreach (char k in palavraCerta)
                                    {
                                        if (palavraCerta.Contains(palavraDigitada[i]))
                                        {
                                            contadorParaSaberACorDoBotao++;
                                        }
                                    }

                                    if (btn.Background == corRight && contadorParaSaberACorDoBotao < 1)
                                    {
                                        btn.Background = corRightAndAlmost;
                                        btn.BorderBrush = null;
                                    }
                                    else if (btn.Background != corRight)
                                    {
                                        btn.Background = corAlmost;
                                        btn.BorderBrush = null;
                                        break;
                                    }
                                }
                            }

                            if (contadorLetrasIguais > 1)
                            {
                                if (palavraDigitada[i].ToString() == letrasIguais[0].ToString())
                                {
                                    ListaTextBoxsSegundaLinha[i].Background = corNaoTem;
                                    ListaTextBoxsSegundaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                                    auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                                    foreach (Button btn in listaBotoes)
                                    {
                                        if (btn.Name == auxilioAcharBotao)
                                        {
                                            if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                            {
                                                btn.Opacity = .50;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            ListaTextBoxsSegundaLinha[i].Background = corNaoTem;
                            ListaTextBoxsSegundaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                    {
                                        btn.Opacity = .50;
                                        break;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            /*==============================================
                     LÓGICA PARA A TERCEIRA LINHA (C)
            ===============================================*/
            else if (wordIndex == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (palavraDigitada[i] == palavraCerta[i])
                    {
                        ListaTextBoxsTerceiraLinha[i].Background = corRight;
                        ListaTextBoxsTerceiraLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                        auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                        foreach (Button btn in listaBotoes)
                        {
                            if (btn.Name == auxilioAcharBotao)
                            {
                                btn.Background = corRight;
                                btn.BorderBrush = corRight;
                                break;
                            }
                        }
                        newWordArray[i] = ' ';
                        letrasCertas.Add(i);
                    }
                }

                newWord = new string(newWordArray);

                for (int i = 0; i < 5; i++)
                {
                    if (!letrasCertas.Contains(i))
                    {
                        if (newWord.Contains(palavraDigitada[i]))
                        {
                            contadorLetrasIguais++;
                            letrasIguais += palavraDigitada[i].ToString();

                            ListaTextBoxsTerceiraLinha[i].Background = corAlmost;
                            ListaTextBoxsTerceiraLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    foreach (char k in palavraCerta)
                                    {
                                        if (palavraCerta.Contains(palavraDigitada[i]))
                                        {
                                            contadorParaSaberACorDoBotao++;
                                        }
                                    }

                                    if (btn.Background == corRight && contadorParaSaberACorDoBotao < 1)
                                    {
                                        btn.Background = corRightAndAlmost;
                                        btn.BorderBrush = null;
                                    }
                                    else if (btn.Background != corRight)
                                    {
                                        btn.Background = corAlmost;
                                        btn.BorderBrush = null;
                                        break;
                                    }
                                }
                            }

                            if (contadorLetrasIguais > 1)
                            {
                                if (palavraDigitada[i].ToString() == letrasIguais[0].ToString())
                                {
                                    ListaTextBoxsTerceiraLinha[i].Background = corNaoTem;
                                    ListaTextBoxsTerceiraLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                                    auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                                    foreach (Button btn in listaBotoes)
                                    {
                                        if (btn.Name == auxilioAcharBotao)
                                        {
                                            if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                            {
                                                btn.Opacity = .50;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            ListaTextBoxsTerceiraLinha[i].Background = corNaoTem;
                            ListaTextBoxsTerceiraLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                    {
                                        btn.Opacity = .50;
                                        break;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            /*==============================================
                     LÓGICA PARA A QUARTA LINHA (D)
            ===============================================*/
            else if (wordIndex == 3)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (palavraDigitada[i] == palavraCerta[i])
                    {
                        ListaTextBoxsQuartaLinha[i].Background = corRight;
                        ListaTextBoxsQuartaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                        auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                        foreach (Button btn in listaBotoes)
                        {
                            if (btn.Name == auxilioAcharBotao)
                            {
                                btn.Background = corRight;
                                btn.BorderBrush = corRight;
                                break;
                            }
                        }
                        newWordArray[i] = ' ';
                        letrasCertas.Add(i);
                    }
                }

                newWord = new string(newWordArray);

                for (int i = 0; i < 5; i++)
                {
                    if (!letrasCertas.Contains(i))
                    {
                        if (newWord.Contains(palavraDigitada[i]))
                        {
                            contadorLetrasIguais++;
                            letrasIguais += palavraDigitada[i].ToString();

                            ListaTextBoxsQuartaLinha[i].Background = corAlmost;
                            ListaTextBoxsQuartaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    foreach (char k in palavraCerta)
                                    {
                                        if (palavraCerta.Contains(palavraDigitada[i]))
                                        {
                                            contadorParaSaberACorDoBotao++;
                                        }
                                    }

                                    if (btn.Background == corRight && contadorParaSaberACorDoBotao < 1)
                                    {
                                        btn.Background = corRightAndAlmost;
                                        btn.BorderBrush = null;
                                    }
                                    else if (btn.Background != corRight)
                                    {
                                        btn.Background = corAlmost;
                                        btn.BorderBrush = null;
                                        break;
                                    }
                                }
                            }

                            if (contadorLetrasIguais > 1)
                            {
                                if (palavraDigitada[i].ToString() == letrasIguais[0].ToString())
                                {
                                    ListaTextBoxsQuartaLinha[i].Background = corNaoTem;
                                    ListaTextBoxsQuartaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                                    auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                                    foreach (Button btn in listaBotoes)
                                    {
                                        if (btn.Name == auxilioAcharBotao)
                                        {
                                            if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                            {
                                                btn.Opacity = .50;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            ListaTextBoxsQuartaLinha[i].Background = corNaoTem;
                            ListaTextBoxsQuartaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                    {
                                        btn.Opacity = .50;
                                        break;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            /*==============================================
                    LÓGICA PARA A QUINTA LINHA (E)
           ===============================================*/
            else if (wordIndex == 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (palavraDigitada[i] == palavraCerta[i])
                    {
                        ListaTextBoxsQuintaLinha[i].Background = corRight;
                        ListaTextBoxsQuintaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                        auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                        foreach (Button btn in listaBotoes)
                        {
                            if (btn.Name == auxilioAcharBotao)
                            {
                                btn.Background = corRight;
                                btn.BorderBrush = corRight;
                                break;
                            }
                        }
                        newWordArray[i] = ' ';
                        letrasCertas.Add(i);
                    }
                }

                newWord = new string(newWordArray);

                for (int i = 0; i < 5; i++)
                {
                    if (!letrasCertas.Contains(i))
                    {
                        if (newWord.Contains(palavraDigitada[i]))
                        {
                            contadorLetrasIguais++;
                            letrasIguais += palavraDigitada[i].ToString();

                            ListaTextBoxsQuintaLinha[i].Background = corAlmost;
                            ListaTextBoxsQuintaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    foreach (char k in palavraCerta)
                                    {
                                        if (palavraCerta.Contains(palavraDigitada[i]))
                                        {
                                            contadorParaSaberACorDoBotao++;
                                        }
                                    }

                                    if (btn.Background == corRight && contadorParaSaberACorDoBotao < 1)
                                    {
                                        btn.Background = corRightAndAlmost;
                                        btn.BorderBrush = null;
                                    }
                                    else if (btn.Background != corRight)
                                    {
                                        btn.Background = corAlmost;
                                        btn.BorderBrush = null;
                                        break;
                                    }
                                }
                            }

                            if (contadorLetrasIguais > 1)
                            {
                                if (palavraDigitada[i].ToString() == letrasIguais[0].ToString())
                                {
                                    ListaTextBoxsQuintaLinha[i].Background = corNaoTem;
                                    ListaTextBoxsQuintaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                                    auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                                    foreach (Button btn in listaBotoes)
                                    {
                                        if (btn.Name == auxilioAcharBotao)
                                        {
                                            if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                            {
                                                btn.Opacity = .50;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            ListaTextBoxsQuintaLinha[i].Background = corNaoTem;
                            ListaTextBoxsQuintaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                    {
                                        btn.Opacity = .50;
                                        break;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            /*==============================================
                    LÓGICA PARA A SEXTA LINHA (F)
           ===============================================*/
            else if (wordIndex == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (palavraDigitada[i] == palavraCerta[i])
                    {
                        ListaTextBoxsSextaLinha[i].Background = corRight;
                        ListaTextBoxsSextaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                        auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                        foreach (Button btn in listaBotoes)
                        {
                            if (btn.Name == auxilioAcharBotao)
                            {
                                btn.Background = corRight;
                                btn.BorderBrush = corRight;
                                break;
                            }
                        }
                        newWordArray[i] = ' ';
                        letrasCertas.Add(i);
                    }
                }

                newWord = new string(newWordArray);

                for (int i = 0; i < 5; i++)
                {
                    if (!letrasCertas.Contains(i))
                    {
                        if (newWord.Contains(palavraDigitada[i]))
                        {
                            contadorLetrasIguais++;
                            letrasIguais += palavraDigitada[i].ToString();

                            ListaTextBoxsSextaLinha[i].Background = corAlmost;
                            ListaTextBoxsSextaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();

                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    foreach (char k in palavraCerta)
                                    {
                                        if (palavraCerta.Contains(palavraDigitada[i]))
                                        {
                                            contadorParaSaberACorDoBotao++;
                                        }
                                    }

                                    if (btn.Background == corRight && contadorParaSaberACorDoBotao < 1)
                                    {
                                        btn.Background = corRightAndAlmost;
                                        btn.BorderBrush = null;
                                    }
                                    else if (btn.Background != corRight)
                                    {
                                        btn.Background = corAlmost;
                                        btn.BorderBrush = null;
                                        break;
                                    }
                                }
                            }

                            if (contadorLetrasIguais > 1)
                            {
                                if (palavraDigitada[i].ToString() == letrasIguais[0].ToString())
                                {
                                    ListaTextBoxsSextaLinha[i].Background = corNaoTem;
                                    ListaTextBoxsSextaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                                    auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                                    foreach (Button btn in listaBotoes)
                                    {
                                        if (btn.Name == auxilioAcharBotao)
                                        {
                                            if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                            {
                                                btn.Opacity = .50;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            ListaTextBoxsSextaLinha[i].Background = corNaoTem;
                            ListaTextBoxsSextaLinha[i].BorderThickness = new Thickness(0, 0, 0, 0);

                            auxilioAcharBotao = "btn" + palavraDigitada[i].ToString().ToUpper();
                            foreach (Button btn in listaBotoes)
                            {
                                if (btn.Name == auxilioAcharBotao)
                                {
                                    if (btn.Background != corRightAndAlmost && btn.Background != corRight && btn.Background != corAlmost)
                                    {
                                        btn.Opacity = .50;
                                        break;
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        private void AjustarCampos()
        {
            List<TextBox> linhaB = new List<TextBox>() {txtCampoB1, txtCampoB2, txtCampoB3, txtCampoB4, txtCampoB5};
            List<TextBox> linhaC = new List<TextBox>() {txtCampoC1, txtCampoC2, txtCampoC3, txtCampoC4, txtCampoC5 };
            List<TextBox> linhaD = new List<TextBox>() {txtCampoD1, txtCampoD2, txtCampoD3, txtCampoD4, txtCampoD5 };
            List<TextBox> linhaE = new List<TextBox>() {txtCampoE1, txtCampoE2, txtCampoE3, txtCampoE4, txtCampoE5 };
            List<TextBox> linhaF = new List<TextBox>() {txtCampoF1, txtCampoF2, txtCampoF3, txtCampoF4, txtCampoF5 };

            if (wordIndex == 1)
            {
                foreach (TextBox b in linhaB)
                {
                    b.Background = corReset;
                    b.BorderThickness = new Thickness(5, 5, 5, 5);
                    b.BorderBrush = corBordaReset;
                }
            }
            else if (wordIndex == 2)
            {
                foreach (TextBox c in linhaC)
                {
                    c.Background = corReset;
                    c.BorderThickness = new Thickness(5, 5, 5, 5);
                    c.BorderBrush = corBordaReset;
                }
            }
            else if (wordIndex == 3)
            {
                foreach (TextBox d in linhaD)
                {
                    d.Background = corReset;
                    d.BorderThickness = new Thickness(5, 5, 5, 5);
                    d.BorderBrush = corBordaReset;
                }
            }
            else if (wordIndex == 4)
            {
                foreach (TextBox e in linhaE)
                {
                    e.Background = corReset;
                    e.BorderThickness = new Thickness(5, 5, 5, 5);
                    e.BorderBrush = corBordaReset;
                }
            }
            else if (wordIndex == 5)
            {
                foreach (TextBox f in linhaF)
                {
                    f.Background = corReset;
                    f.BorderThickness = new Thickness(5, 5, 5, 5);
                    f.BorderBrush = corBordaReset;
                }
            }
        }

        private void ReiniciarJogo()
        {
            // Listas que contém todas as textBoxs da linha A
            List<TextBox> ListaTextBoxsPrimeiraLinha = new List<TextBox>() {txtCampoA1, txtCampoA2, txtCampoA3, txtCampoA4, txtCampoA5};
            // Listas que contém todas as textBoxs menos a linha A
            List<TextBox> ListaRestoTextBoxs = new List<TextBox>() {txtCampoB1, txtCampoB2, txtCampoB3, txtCampoB4, txtCampoB5, txtCampoC1, txtCampoC2, txtCampoC3, txtCampoC4, txtCampoC5, 
            txtCampoD1, txtCampoD2, txtCampoD3, txtCampoD4, txtCampoD5, txtCampoE1, txtCampoE2, txtCampoE3, txtCampoE4, txtCampoE5, txtCampoF1, txtCampoF2, txtCampoF3, txtCampoF4, txtCampoF5};
            // Lista com todos os botões
            List<Button> listaBotoes = new List<Button>() {btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI,
            btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ};

            letterIndex = 0;
            wordIndex = 0;
            contarLetrasBotoes = 0;
            palavraCerta = "";
            palavraDigitada = "";
            nomeBotao = "";

            foreach (TextBox a in ListaTextBoxsPrimeiraLinha)
            {
                a.Background = corReset;
                a.BorderThickness = new Thickness(5, 5, 5, 5);
                a.BorderBrush = corBordaReset;
                a.Text = "";
            }

            foreach (TextBox c in ListaRestoTextBoxs)
            {
                c.Background = corParaReiniciar;
                c.BorderBrush = corParaReiniciar;
                c.Text = "";
            }

            foreach (Button b in listaBotoes)
            {
                b.Background = corBordaReset;
                b.BorderBrush = corBordaReset;
                b.Opacity = 1;
            }

            rectantePalavrasReveladas.Visibility = Visibility.Hidden;
            txtPalavrasReveladas.Text = "";
            txtPalavrasReveladas2.Text = "";
            txtPalavrasReveladas3.Text = "";

            SortearPalavra();
        }

        private void AparecerListaDePalavras(object sender, RoutedEventArgs e)
        {
            if (txtPalavrasReveladas.Text == "")
            {
                bool existeArquivo = File.Exists(caminho);
                int contadorInterno = 0;

                rectantePalavrasReveladas.Visibility = Visibility.Visible;

                if (existeArquivo == true)
                {
                    var linhas = File.ReadLines(caminho);
                    foreach (string linha in linhas)
                    {
                        if (contadorInterno >= 14 && contadorInterno < 28)
                        {
                            txtPalavrasReveladas2.Text += linha.ToString() + "\n";
                        }
                        else if (contadorInterno >= 28)
                        {
                            txtPalavrasReveladas3.Text += linha.ToString() + "\n";
                        }
                        else
                        {
                            txtPalavrasReveladas.Text += linha.ToString() + "\n";
                        }
                        contadorInterno++;
                    }
                }
            }
        }

        private void AbrirRegras(object sender, RoutedEventArgs e)
        {
            Regras regras = new Regras();
            regras.Show();
            Close();
        }
    }
}