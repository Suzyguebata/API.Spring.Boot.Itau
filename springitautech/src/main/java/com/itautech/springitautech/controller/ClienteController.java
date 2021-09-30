package com.itautech.springitautech.controller;

import java.util.List;

import com.itautech.springitautech.model.Cliente;
import com.itautech.springitautech.repository.ClienteRepo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/cliente")
@CrossOrigin("*")
public class ClienteController {
    @Autowired
    private ClienteRepo repo;

    public ClienteController(ClienteRepo repo){
        this.repo = repo;
    }

    @GetMapping("/all")
    public List<Cliente> obterTodos() {
        return (List<Cliente>) repo.findAll();

    }
}
