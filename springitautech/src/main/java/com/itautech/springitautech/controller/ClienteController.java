package com.itautech.springitautech.controller;

import java.util.List;

import com.itautech.springitautech.model.Cliente;
import com.itautech.springitautech.repository.ClienteRepo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/cliente")
@CrossOrigin("*")
public class ClienteController {
    //métodos
    @Autowired
    private ClienteRepo repo; 

    @GetMapping("/all")
    public List<Cliente> obterTodos(){
        return (List<Cliente>) repo.findAll();
    }

    @GetMapping("/id/{codigo}")
    public ResponseEntity<Cliente> obterCliente(@PathVariable long codigo) {
        Cliente ClienteEncontrado = repo.findById(codigo).orElse(null);

        if(ClienteEncontrado != null) {
            return ResponseEntity.ok(ClienteEncontrado);
        } else {
            return ResponseEntity.notFound().build(); 
        }
    }
    
    
}
