# Sistema de Estacionamento em C#
O objetivo do programa é fornecer, através de um menu interativo, funcionalidades básicas para gerenciar o controle de veículos de um estacionamento pago, explorando conceitos básicos da linguagem.

## Funcionalidades

- Definição dos valores de preço inicial e preço por hora para posterior cálculo do valor que veículos estacionados deverão pagar;
- que irão reger o quanto, cada uma herdando de uma conta principal. Essas contas possuem os seguintes atributos e métodos:

### Classe Estacionamento

Atributos

- `precoInicial`: Preço cobrado para deixar seu veículo estacionado (decimal)
- `precoPorHora`: Preço por hora que o veículo permanecer estacionado (decimal)
- `veiculos`: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.
  
Métodos:

- `AdicionarVeiculo`: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veiculos.
- `RemoverVeiculo`:  Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: precoInicial * precoPorHora, exibindo para o usuário.
- `ListarVeiculos`:Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibi a mensagem "Não há veículos estacionados".


## Tecnologias Utilizadas
<div style="display: inline_block">
  <img align="center" alt="JsIcon" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/csharp/csharp-plain.svg">
  <img align="center" alt="JsIcon" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/dotnetcore/dotnetcore-original.svg">
</div>
