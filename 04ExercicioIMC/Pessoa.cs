using System;

class Pessoa
{

    //atributos
    public double peso, altura;

    //calculo
    public double calculo()
    {  
        return peso / (altura * altura);
    }   
    
    //situação
    public string situacao(double imc)
    {
      //variavel

      string retorno;

      //condicional
      if(imc < 18.5)
      {
          retorno = "abaixo do peso";
      }
      else if(imc < 25)
      {
          retorno = "Peso normal";
      }
      else if(imc < 30)
      {
          retorno = "Acima do peso";
      }
      else if(imc < 35)
      {
          retorno = "Obesidade I";
      }
      else if(imc < 40)
      {
          retorno = "Obesidade II";
      }
      else
      {
          retorno = "Obesidade III";
      }
      //retorno
      return retorno;
    }

    public void mensagem()
    {
        //obter imc
        double obterCalculo = calculo();

        //obter situação
        string obterSituacao = situacao(obterCalculo);

        //mensagem
        Console.WriteLine($"Olá seu IMC é de {obterCalculo}");
        Console.WriteLine($"sua situação é de {obterSituacao}");

    }

}
    