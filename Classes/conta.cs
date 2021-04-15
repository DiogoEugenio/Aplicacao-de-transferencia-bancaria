 using System;
namespace Bank
{
    public class conta
    {
      private tipodeConta tipodeConta {get; set;}
      private double Saldo {get; set;}
      private double Credito {get; set;}
      private string Nome {get; set;}

      public conta(tipodeConta tipodeConta,double Saldo, double Credito,string Nome)
      {
        this.tipodeConta = tipodeConta;
        this.Saldo = Saldo;
        this.Credito = Credito;
        this.Nome = Nome;
      }
      public bool sacar(double ValorSaque)
      {
        if (this.Saldo - ValorSaque < (this.Credito * -1))
        {
            Console.WriteLine("Saldo insuficiante");
            return false;    
        }
        this.Saldo = ValorSaque;
        Console.WriteLine("O saldo atual da conta de{0} e {1}", this.Nome, this.Saldo);

        return true;
      
      }
      public void depositar(double valordeposito){

        this.Saldo += valordeposito;
         Console.WriteLine("O saldo atual da conta de{0} e {1}", this.Nome, this.Saldo);

      }
      public void transferir(double valorTrasferencia, conta contadestino)
      {
        if (this.sacar(valorTrasferencia))
        {
          contadestino.depositar(valorTrasferencia);  
        }
      }

        public override string ToString()
        {
            string retorno = "";
            retorno+= "tipodeConta " + this.tipodeConta + " | ";
            retorno+= "Nome " + this.Nome + " | ";
            retorno+= "Saldo " + this.Saldo + " | ";
            retorno+= "Credito " + this.Credito; 
            return retorno;

        }
    }
}