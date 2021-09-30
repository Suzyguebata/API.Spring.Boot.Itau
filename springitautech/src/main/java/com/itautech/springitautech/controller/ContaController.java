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
@RequestMapping("/conta")
@CrossOrigin("*")
public class ContaController {
    @Autowired
    private ContaRepo repo; 

    @GetMapping("/all")
    public List<Conta> obterTodos(){
        return (List<Conta>) repo.findAll();
    }

    @GetMapping("/id/{id}")
    public ResponseEntity<Conta> obterCarro(@PathVariable long id) {
        Conta contaEncontrada = repo.findById(id).orElse(null);

        if (contaEncontrada != null) {
            return ResponseEntity.ok(contaEncontrada);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

}
    


