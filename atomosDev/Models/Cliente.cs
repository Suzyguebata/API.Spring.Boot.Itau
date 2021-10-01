using System;
using System.Collections.Generic;

namespace atomosDev.Models
 /*
 "id": 6,
        "nome": "Vanessa Gomes",
        "email": "vanessa@itau.com",
        "telefone": "(11) 98709-4781",
        "cpf": "368.478.789-13",
        "contas": [
            */

{
    public class Cliente
    {
        public string nome {get; set;}
        public string email {get; set;}
        public string telefone {get; set;}
        public string cpf {get; set;}

        public List<Conta> contas {get;set;}

    }
}