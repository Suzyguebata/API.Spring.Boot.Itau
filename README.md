<h3 align="center">
<img src="https://fontmeme.com/permalink/211001/6042e20110b46ec8dd51c5b81b5aa76e.png" alt="fonts" border="0">
<h3 align = "left">
<img src="https://fontmeme.com/permalink/211001/5cefc7c5fd89a24a74041e0ee39842e3.png"
alt="fonts" border= "0">
<p align="left">Estamos em um contexto de gerenciamento de clientes e contas bancárias da instituição.Precisamos disponibilizar uma API que forneça dados de clientes e contas (inicialmente para
consulta).
</p>
<br>
<h3 align = "left">
<img src="https://fontmeme.com/permalink/211001/5f75d40b40c5f801a0b61dc25dceff1d.png"
alt="fonts" border= "0">
<p align="left">1. Construir uma API Spring BOOT que possua 2 endpoints principais:
</p>
<p align="left">a. Recuperação de todas as contas bancárias
</p>
<p align="left">b. Recuperação dos detalhes de 1 conta bancária (inclusive dados do seu titular)
</p>
<br>
<h3 align = "left">
<img src="https://fontmeme.com/permalink/211001/8b37c82f3ebd1c18b4da83b5b64157e4.png"
alt="fonts" border= "0">
<p align="left">Algumas tecnologias são obrigatórias para este projeto:
</p>
<p align="left">Banco de Dados: 
</p>
<img alt="MySQL Icon" src="img/mysql.svg" width="15px" /> &nbsp;
<p align="left">API: 
</p>
<img alt="Spring Boot Icon" src="img/spingboot.png" width="30px" /> &nbsp;
<p align="left">Modelagem de Dados:
</p>
<p align="left">Todo cliente possui os seguintes dados para serem cadastrados
●codigo interno
●nome
●cpf
●telefone
●email
</p>
<p align="left">Toda conta bancária possui os seguintes dados
●numero
●agência
●tipo da conta (0 - conta corrente, 1 - poupança, 2 - investimento)
●saldo
●titular da conta
</p>
<br>
<h3 align = "left">
<img src="https://fontmeme.com/permalink/211001/8b37c82f3ebd1c18b4da83b5b64157e4.png"
alt="fonts" border= "0">
<p align="left">Endpoint para consulta de todas as contas (deve retornar uma lista de objetos do tipo
que armazena Conta Bancária):
</p>
<p align="center">/contas
</p>
<p align="left">Endpoint para consultas do detalhe da conta
</p>
<p align="center">/contas/{id}
</p>