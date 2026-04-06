# CP1 — Modelo Entidade-Relacionamento (MER) e Criação do Projeto WebAPI

## 👥 Integrantes do Grupo

<table>
  <tr>
    <td width="130">
      <img src="https://github.com/moisesBarsoti.png" width="120" style="border-radius: 50%;"/>
    </td>
    <td>
      <b>👨‍💻 Moisés Barsoti Andrade de Oliveira</b><br/>
      🆔 <b>RM:</b> 565049 &nbsp;&nbsp;|&nbsp;&nbsp; 🏫 <b>Turma:</b> 2TDSPG - FIAP <br/>
    </td>
  </tr>

  <tr>
    <td width="130">
      <img src="https://github.com/sSofia-s.png" width="120" style="border-radius: 50%;"/>
    </td>
    <td>
      <b>🎨 Sofia Siqueira Fontes</b><br/>
      🆔 <b>RM:</b> 563829 &nbsp;&nbsp;|&nbsp;&nbsp; 🏫 <b>Turma:</b> 2TDSPG - FIAP <br/>
    </td>
  </tr>

  <tr>
    <td width="130">
      <img src="https://github.com/lunaguima.png" width="120" style="border-radius: 50%;"/>
    </td>
    <td>
      <b>⚙️ Luna de Carvalho Guimarães</b><br/>
      🆔 <b>RM:</b> 562290 &nbsp;&nbsp;|&nbsp;&nbsp; 🏫 <b>Turma:</b> 2TDSPG - FIAP <br/>
    </td>
  </tr>
</table>

---

## 🏪 Domínio Escolhido

O domínio escolhido para o projeto foi 🐶 **Pet shop**.
O sistema tem como objetivo auxiliar no gerenciamento de um pet shop, permitindo o controle de clientes, pets, serviços oferecidos, funcionários, agendamentos e vendas de produtos.

---

## 🗂️ Entidades Modeladas
As entidades modeladas no sistema foram:

* **👤 Customer (Cliente):**
  Representa o cliente do pet shop, responsável pelos pets cadastrados e pelos pedidos realizados na loja.

* **🐶 Pet:**
  Representa o animal pertencente ao cliente, contendo informações como nome, espécie, raça, peso e data de nascimento.

* **👨‍💼 Employee (Funcionário):**
   Representa os funcionários do pet shop responsáveis por realizar os serviços disponibilizados no pet shop.

* **✂️ Service (Serviço):**
  Representa os serviços oferecidos pelo pet shop.

* **📅 Appointment (Agendamento):**
  Representa o agendamento de um serviço para um pet, indicando qual serviço será realizado, em qual data e por qual funcionário.

* **📦 Product (Produto):**
  Representa os produtos vendidos pelo pet shop.

* **🧾 Order (Pedido):**
  Representa um pedido realizado por um cliente.
  
* **📋 OrderItem (Item do Pedido):**
  Representa os produtos incluídos dentro de um pedido, indicando quantidade e preço unitário.

---

## 🔗 Resumo dos Relacionamentos

Os relacionamentos entre as entidades do sistema foram definidos da seguinte forma:

* Um **Customer** pode possuir **vários Pets** e pode realizar **vários Orders** (1:N).
* Cada **Pet** pertence a **apenas um Customer** (N:1).
* Um **Pet** pode ter **vários Appointments** para realização de serviços (1:N).
* Um **Employee** pode atender **vários Appointments** (1:N).
* Um **Service** pode estar associado a **vários Appointments** (1:N).
* Um **Appointment** está vinculado a **um Pet**, **um Service** e **um Employee** (N:1).
* Um **Product** pode aparecer em **vários OrderItems** (1:N).
* Um **Order** pertence a **um Customer** (N:1).
* Um **Order** pode conter **vários OrderItems** (1:N).
* Cada **OrderItem** pertence a **um Order** e está associado a **um Product** (N:1).

---
