package com.itautech.springitautech.repository;

import java.util.List;

import com.itautech.springitautech.model.Cliente;

import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;

public interface ClienteRepo extends CrudRepository<Cliente, Long> {
    
    public List<Cliente> findAllByOrderByNome();

    @Query(value = "select * from tb_cliente where id = ?", nativeQuery = true)
    public Object buscaClient(long id);
}
