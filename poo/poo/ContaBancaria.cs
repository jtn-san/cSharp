public class ContaBancaria
{

    // Atributo privado, acesso apenas  na própria classe
    private double saldo;

    /*
     Método é:

    Pode receber parâmetros (valores de entrada).

    Pode ou não retornar um valor.

    Ajuda a organizar e reutilizar o código.
     */

    // Método publico com retorno de um atributo privado, pode ser acessado em qualquer classe da aplicação.
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
    }


    // Método publico com retorno de um atributo privado, pode ser acessado em qualquer classe da aplicação.
    public double ConsultarSaldo()
    {
        return saldo;
    }
}



// Limpar Classe desnecessária CRTL R G
// Identar o código CRTL K D