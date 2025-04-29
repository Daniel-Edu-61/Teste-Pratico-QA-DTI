Cenário 1: Login com dados incorretos

Dado que o usuário está na página de login
Quando ele preenche um e-mail e senha inválidos
Então o sistema deve exibir uma mensagem:
Authentication failed.

Cenário 2: Campos vazios

Dado que o usuário está na página de login
Quando ele clica no botão "Login" sem preencher e-mail e senha
Então o sistema deve exibir uma mensagem:
An email address required.

Cenário 3: E-mail com formato inválido

Dado que o usuário está na página de login
Quando ele preenche um e-mail sem @ e uma senha qualquer
Então o sistema deve exibir uma mensagem:
Invalid email address.
