# desafio-do-felipao-dio
desafio do herói



📘 Documentação dos Projetos
🟨 JavaScript
Objetivo

Classificar um herói com base em sua experiência (XP) e exibir o nível correspondente.
Conceitos Utilizados

    Variáveis (let): armazenam nome e XP do herói.

    Estruturas de decisão:

        if/else: usado para verificar intervalos de XP.

        switch(true): simula um switch case com condições booleanas, permitindo trabalhar com intervalos.

    Interpolação de strings (template literals): usada para montar a mensagem final com ${variável}.

Exemplo de Saída
Code

O Herói de nome Arthas está no nível de Platina

Observações

    switch(true) é um padrão alternativo em JavaScript para lidar com condições complexas.

    Para projetos maiores, pode-se usar objetos de mapeamento ou funções auxiliares para tornar o código mais escalável.

☕ Java
Objetivo

Classificar o herói com base em XP e exibir o nível.
Conceitos Utilizados

    Variáveis (String, int): armazenam nome e XP.

    Estruturas de decisão:

        switch case tradicional só aceita valores exatos.

        A partir do Java 14, é possível usar switch expressions com condições (case int n when ...).

    Saída (System.out.println): imprime a mensagem final.

Exemplo de Saída
Code

O Herói de nome Arthas está no nível de Platina

Observações

    Em versões anteriores ao Java 14, deve-se usar if/else para intervalos.

    switch expressions tornam o código mais limpo e moderno.

🎯 C#
Objetivo

Classificar o herói com base em XP e exibir o nível.
Conceitos Utilizados

    Variáveis (string, int): armazenam nome e XP.

    Estruturas de decisão (if/else): verificam intervalos de XP.

    Interpolação de strings ($""): usada para montar a mensagem final.

Exemplo de Saída
Code

O Herói de nome Arthas está no nível de Platina

Observações

    C# não possui switch case com intervalos diretos, então if/else é a forma mais prática.

    Para projetos maiores, pode-se usar expressões lambda ou dicionários para mapear XP → nível.

🐍 Python
Objetivo

Classificar o herói com base em XP e exibir o nível.
Conceitos Utilizados

    Variáveis (nome, xp): armazenam nome e XP.

    Estruturas de decisão:

        match case (Python 3.10+): funciona como switch case, permitindo condições com if.

        if/else: alternativa para versões anteriores.

    Interpolação de strings (f-string): usada para montar a mensagem final.

Exemplo de Saída
Code

O Herói de nome Arthas está no nível de Platina

Observações

    match case é ideal para organizar múltiplas condições.

    Em versões anteriores ao Python 3.10, deve-se usar if/else.

📑 Conclusão

Cada linguagem tem sua forma de lidar com estruturas de decisão:

    JavaScript: if/else ou switch(true) para intervalos.

    Java: switch expressions (Java 14+) ou if/else em versões antigas.

    C#: if/else é mais comum, já que switch não aceita intervalos.

    Python: match case (3.10+) ou if/else em versões anteriores.

