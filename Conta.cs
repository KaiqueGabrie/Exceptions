using System;

public class Conta
{
    private double _saldo;
    public void SetSaldo(double saldo)
    {
        try
        {
            if (saldo >= 0)
            {
                _saldo = saldo;
            }
            else
            {
                throw new Exception("O saldo não pode ser negativo!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
