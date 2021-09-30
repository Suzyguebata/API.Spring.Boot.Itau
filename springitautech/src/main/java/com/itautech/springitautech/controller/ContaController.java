package com.itautech.springitautech.controller;

import java.util.List;

import com.itautech.springitautech.model.Conta;
import com.itautech.springitautech.repository.ContaRepo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@CrossOrigin("*")
@RequestMapping("/conta")
public class ContaController {
    
    @Autowired
    private ContaRepo repo;

    public ContaController(ContaRepo repo){
        this.repo = repo;
    }

    @GetMapping("/id/{id}")
    public List<Conta> obterConta(int id){
        return (List<Conta>) repo.findAll();
    }
    /*public ResponseEntity<Conta> obterConta(@PathVariable long id) {
        Conta alterarConta = repo.findById(id).orElse(null);

        if (alterarConta != null) {
            return ResponseEntity.ok(alterarConta);
        } else {
            return ResponseEntity.notFound().build();
        }
    }*/
}
