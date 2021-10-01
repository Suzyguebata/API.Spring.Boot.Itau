using System;
using System.Collections.Generic;

namespace atomosDev.Models
{
    /*
    "id": 5,
    "agencia": 777,
    "conta": "741258",
    "saldo": 9.0,
    "titular_da_conta": {
        "id": 6,
        "nome": "Vanessa Gomes",
        "email": "vanessa@itau.com",
        "telefone": "(11) 98709-4781",
        "cpf": "368.478.789-13",
        "contas": [
            */

    public class Conta
    {
        public int id {get;set;}
        public int tipo {get;set;}
        public int agencia {get;set;}
        public string conta {get;set;}
        public double saldo {get;set;}   
        public virtual Cliente titular_da_conta {get;set;}
    }
}