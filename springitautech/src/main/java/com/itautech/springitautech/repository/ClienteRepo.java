package com.itautech.springitautech.repository;

import com.itautech.springitautech.model.Cliente;

import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface ClienteRepo extends CrudRepository<Cliente, Long> {
     //  public List<Cliente> findAllByOrderByNome();

    // consulta nativa no BD, diretamente em SQL
    @Query(value = "select * from tb_cliente where id = ?", nativeQuery = true)
    public Object buscaUsuario(int id);
}
