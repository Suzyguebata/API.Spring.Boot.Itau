package com.itautech.springitautech.repository;

import com.itautech.springitautech.model.Conta;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;
import org.springframework.data.jpa.repository.Query;

@Repository
public interface ContaRepo extends CrudRepository<Conta, Long>{
    public Conta findByConta(int conta);

}
