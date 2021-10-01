package com.itautech.springitautech.repository;

import com.itautech.springitautech.model.Conta;

import org.springframework.data.repository.CrudRepository;

public interface ContaRepo extends CrudRepository<Conta, Long> {
    public Conta findByConta(int conta);
}
