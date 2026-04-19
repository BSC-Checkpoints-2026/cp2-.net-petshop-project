# CP2 — Persistência com EF Core, Mapeamento e Camada de Infraestrutura

## 👥 Integrantes

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

## ▶️ Como Executar a API:
### ⚠️ Pré-requisitos
  - JetBrains Rider (ou outro IDE)
  - Terminal (PowerShell, CMD ou integrado do Rider)
    
 ### Passo a passo
1. **Clone o repositório**  
   Se ainda não tiver o repositório localmente, execute:

   ```bash
   git clone https://github.com/BSC-Checkpoints-2026/cp2-.net-petshop-project.git
   ```

   Após clonar, entre na pasta do projeto:
   ```bash
   cd cp2-.net-petshop-project
   ```

   Abra a pasta em seu editor de código.
<br/>

2. **Execute a API**  
  No terminal, execute o comando:

   ```bash
   dotnet run --project src/PetShop.API
   ```
<br/>

3. **Acesse o Swagger pelo navegador:**  
  No navegador, digite a URL:

   ```bash
   https://localhost:xxxx/swagger
   ```
<br/>
      
---

## 🖼️ Testes da API (Swagger prints)
### GET - Listar Customers
<img src="https://res.cloudinary.com/dt26mfzpw/image/upload/v1776605333/swagger-get-customer_hd6pag.png" width="1000" height="800">
<br/>

### POST - Criar Customer
<img src="https://res.cloudinary.com/dt26mfzpw/image/upload/v1776608747/swagger-post-customer_afvabp.png" width="1000" height="1200">
<br/>

### Customer criado:
<img src="https://res.cloudinary.com/dt26mfzpw/image/upload/v1776609314/swagger-post-customer2_k1cfgh.png" width="1000" height="900">
<br/>

---

### GET - Listar Products
<img src="https://res.cloudinary.com/dt26mfzpw/image/upload/v1776614931/swagger-get-product_mzhgbu.png" width="1000" height="650">
<br/>

### POST - Criar Product
<img src="https://res.cloudinary.com/dt26mfzpw/image/upload/v1776614932/swagger-post-product_i8m8sg.png" width="1000" height="950">
<br/>

### Product criado:
<img src="https://res.cloudinary.com/dt26mfzpw/image/upload/v1776614931/swagger-post-product2_srcc4i.png" width="1000" height="700">

---

## 🖼️ Banco de Bados (SQLite prints)
### Table Customers:
<img src="https://res.cloudinary.com/dt26mfzpw/image/upload/v1776616211/table-customers_gylzoy.png" width="1600" height="1000">
<br/>

### Table Products:
<img src="https://res.cloudinary.com/dt26mfzpw/image/upload/v1776616210/table-products_ot8h3a.png" width="1600" height="1000">
<br/>
