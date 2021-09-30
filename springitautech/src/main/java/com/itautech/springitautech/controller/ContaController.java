package com.itautech.springitautech.controller;

import com.itautech.springitautech.model.Conta;
import com.itautech.springitautech.repository.ContaRepo.ContaRepo;

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

    @GetMapping("/id/{id}")
    public ResponseEntity<Conta> obterConta(@PathVariable long id) {
        Conta contaEncontradaConta = repo.findById(id).orElse(null);

        if (contaEncontradaConta != null) {
            return ResponseEntity.ok(contaEncontradaConta);
        } else {
            return ResponseEntity.notFound().build();
        }
    }
}
