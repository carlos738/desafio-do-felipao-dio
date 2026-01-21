nome = "Arthas"
xp = 7500

match xp:
    case n if n < 1000:
        nivel = "Ferro"
    case n if n <= 2000:
        nivel = "Bronze"
    case n if n <= 5000:
        nivel = "Prata"
    case n if n <= 7000:
        nivel = "Ouro"
    case n if n <= 8000:
        nivel = "Platina"
    case n if n <= 9000:
        nivel = "Ascendente"
    case n if n <= 10000:
        nivel = "Imortal"
    case _:
        nivel = "Radiante"

print(f"O Herói de nome {nome} está no nível de {nivel}")
