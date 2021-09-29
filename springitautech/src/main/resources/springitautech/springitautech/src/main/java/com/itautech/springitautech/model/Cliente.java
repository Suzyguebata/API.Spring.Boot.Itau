package com.itautech.springitautech.model;

import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

@Entity // esta classe será mapeada no Banco de Dados
@Table(name = "tb_cliente") // nome da tabela no Banco de Dados
public class Cliente {
    
    @Id // essa será a chave primária (PK)
    @GeneratedValue(strategy = GenerationType.IDENTITY) // o BD gera este código automaticamente em sequência
    private int cliente_id;

    @Column (name = "cliente_nome", length = 150, nullable = false)
    private String cliente_nome;
    @Column(name = "cliente_email", length = 30, nullable = false, unique = true)
    private String cliente_email;
    @Column(name = "cliente_cpf", length = 14, nullable = false, unique = true)
    private String cliente_cpf;
    @Column(name = "cliente_telefone", length = 16, nullable = false)
    private String cliente_telefone;

    @OneToMany(mappedBy = "cliente_id")
    @JsonIgnoreProperties("cliente_id")
    private List<Conta> contas;

    public int getCliente_id() {
        return cliente_id;
    }
    public void setCliente_id(int cliente_id) {
        this.cliente_id = cliente_id;
    }
    public String getCliente_nome() {
        return cliente_nome;
    }
    public void setCliente_nome(String cliente_nome) {
        this.cliente_nome = cliente_nome;
    }
    public String getCliente_email() {
        return cliente_email;
    }
    public void setCliente_email(String cliente_email) {
        this.cliente_email = cliente_email;
    }
    public String getCliente_cpf() {
        return cliente_cpf;
    }
    public void setCliente_cpf(String cliente_cpf) {
        this.cliente_cpf = cliente_cpf;
    }
    public String getCliente_telefone() {
        return cliente_telefone;
    }
    public void setCliente_telefone(String cliente_telefone) {
        this.cliente_telefone = cliente_telefone;
    }
    public List<Conta> getConta() {
        return contas;
    }
    public void setConta(List<Conta> contas) {
        this.contas = contas;
    }

}
