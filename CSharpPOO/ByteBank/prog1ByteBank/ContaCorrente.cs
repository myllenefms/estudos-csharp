﻿using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int conta;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor || valor < 0) return false;
            else
            {
                this.saldo -= valor;
                destino.Depositar(valor);
                return true;
            }
        }

    }
}