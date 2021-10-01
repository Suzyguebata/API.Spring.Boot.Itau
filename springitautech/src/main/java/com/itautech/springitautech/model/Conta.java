package com.itautech.springitautech.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table (name = "tb_conta")
public class Conta {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    @Column(name = "agencia", length = 8, nullable = false)
    private int agencia;
    
    @Column(name = "conta", length = 15, nullable = false, unique = true)
    private String conta;

    @Column(name = "saldo", length = 200, nullable = false)
    private double saldo;

    @Column(name = "tipo_da_conta", length = 100, nullable = false)
    private int tipo_da_conta;

    @ManyToOne
    @JoinColumn(name = "titular_da_conta")
    private Cliente titular_da_conta;

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public int getAgencia() {
        return agencia;
    }

    public void setAgencia(int agencia) {
        this.agencia = agencia;
    }

    public String getConta() {
        return conta;
    }

    public void setConta(String conta) {
        this.conta = conta;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public int getTipo() {
        return tipo_da_conta;
    }

    public void setTipo(int tipo_da_conta) {
        this.tipo_da_conta = tipo_da_conta;
    }

    public Cliente getTitular_da_conta() {
        return titular_da_conta;
    }

    public void setTitular_da_conta(Cliente titular_da_conta) {
        this.titular_da_conta = titular_da_conta;
    }
}
