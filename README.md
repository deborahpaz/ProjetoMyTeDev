# Orange O’clock

## Descrição do Projeto
A aplicação **Orange O’clock** foi desenvolvida para registrar as horas trabalhadas pelos funcionários em atividades específicas, conhecidas como Work Breakdown Structure (WBS).
Ela permite ao usuário Administrador: criar, visualizar, atualizar e excluir registros de um funcionário. Podendo cadastrar novos funciónários, WBS, cargos e departamentos.
O acesso de funcionário tem a permissão para realizar o registo de suas horas por quinzena e entrar em contato com o suporte para dúvidas.

## Funcionalidades Principais:

### Gerenciamento de Departamentos
- Adicionar, visualizar, atualizar e excluir registros de departamentos.
- Filtrar departamentos por nome ou ID.

### Gerenciamento de Funcionários
- Adicionar, visualizar, atualizar e excluir registros de funcionários.
- Cada registro de funcionário contém informações como ID, nome, departamento e data de contratação.

## Fluxos Principais

### 1. Login
Permite que os usuários façam login na aplicação fornecendo suas credenciais de acesso.

O primeiro acesso deverá ser feito pelo Administrador, utilizando as credenciais a seguir:
- **Login de Administrador:**
- **Email: admin@avanade.com** 
- **Senha: Admin2024@**

### 2. Criação e Manutenção de WBS (Work Breakdown Structure)
Os usuários autorizados podem criar, editar e excluir WBS, representando diferentes atividades ou projetos.

### 3. Apontamento de Horas nas Atividades Específicas
Funcionários podem registrar as horas trabalhadas em atividades específicas, associando-as às respectivas WBS.

## Histórias

### 1. Tela de Login e Acesso
Os usuários podem acessar o sistema MyTE através de um login com usuário e senha.

### 2. Gerenciar WBS
Administradores podem criar, editar e visualizar a lista de WBS.

### 3. Tela de Lançamento de Horas
Os usuários têm uma tela de lançamento de horas para registrar as horas trabalhadas em cada WBS.

### 4. Navegação entre Quinzenas
Os usuários podem navegar entre as quinzenas na tela de lançamento de horas.

### 5. Relatórios no Power BI - A implementar
Gerentes de projeto podem acessar relatórios no Power BI para analisar dados relacionados às WBS com mais apontamentos de horas.

## Pré-requisitos
- Base de dados de usuários cadastrados.
- Framework ou biblioteca para implementação de autenticação.
- Interface de administração para realizar operações CRUD nas WBS.

## Critérios e Regras
- Validação das credenciais de login.
- Validação do preenchimento de horas.
- Restrições de caracteres para códigos de WBS.
- Exigência de pelo menos 8 horas preenchidas por dia útil.
- Navegação de quinzenas não anterior a 01/01/2024.

## Colaboradoras do Projeto ##
- <a href="https://www.linkedin.com/in/deborahpazb/">Déborah Brodowski</a>
- <a href="https://www.linkedin.com/in/isaaregina//">Isabella Coutinho</a>
- <a href="https://www.linkedin.com/in/giovanna-camelo-0220992a2/">Giovanna Camelo</a>
- <a href="https://www.linkedin.com/in/liviarnascimento/">Lívia Nascimento</a>
- <a href="https://www.linkedin.com/in/zandravieitez/">Zandra Vieitez</a>
