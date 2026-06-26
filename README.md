# Oráculo Mundial 2026 🔮

> Un oráculo del Mundial que funciona como huele.

App en .NET 9 + Blazor Server para predecir el Mundial 2026. Usa una escalera de modelos (FIFA, Elo, forma, goles) y corre +10.000 simulaciones Monte Carlo del torneo. Las predicciones se ajustan según goles, lesiones y rankings reales.

---
---

## Cómo correrlo en local

Requisitos: [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

```bash
git clone https://github.com/Jeysshonb/oraculo_mundial_2026.git
cd oraculo_mundial_2026
dotnet restore
dotnet run --project OracuMundial2026.Web
```

Abrí `http://localhost:5235` cuando veas `Now listening on...`.

## Cómo hacer tus predicciones

1. **`/datos`** → "Actualizar rankings" para traer FIFA/Elo al día.
2. **`/partidos`** → predicciones de cada partido del grupo.
3. **`/lab`** → comparar dos equipos en toda la escalera de modelos.
4. **`/torneo`** → "Correr simulación" para ver probabilidades de campeón (10.000 simulaciones).
5. **`/rendimiento`** → qué tan bien predijo (Brier, RPS, log loss, top-pick).

## Stack

.NET 9 · Blazor Server · MudBlazor · EF Core 9 · SQLite · CsvHelper · xUnit · API-Football (opcional) · OpenRouter (opcional)

## Estructura

```
OracuMundial2026.sln
OracuMundial2026.Web/        App: Components, DAL, Data, Helpers, Models, Predictors, Probability, Services
OracuMundial2026.Web.Tests/  Tests xUnit
```

## Tests

```bash
dotnet test
```

## Datos

CSVs en `OracuMundial2026.Web/Data/`: grupos, resultados históricos, goleadores, rankings FIFA y Elo.

<!-- oracumundial2026:snapshots:start -->
## Predicciones más recientes
_A medida que se recibe nueva información y se juegan partidos reales, el Oloráculo ajusta sus predicciones y las publica acá. A continuación vas a encontrar las más recientes._

### Torneo

_Generado 2026-06-26 19:57 UTC a través de 10,000 simulaciones._

| Equipo | Grupo | Clasifica | 4tos | Semis | Final | Campeón |
| --- | --- | ---: | ---: | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ar.svg" width="18" alt=""> Argentina | J | 97 % | 59 % | 45 % | 32 % | **22.2 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/es.svg" width="18" alt=""> Spain | H | 96 % | 42 % | 29 % | 18 % | **10.1 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ma.svg" width="18" alt=""> Morocco | C | 94 % | 43 % | 28 % | 16 % | **9.5 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/jp.svg" width="18" alt=""> Japan | F | 94 % | 41 % | 27 % | 15 % | **8.5 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/br.svg" width="18" alt=""> Brazil | C | 94 % | 41 % | 26 % | 14 % | **7.0 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/co.svg" width="18" alt=""> Colombia | K | 86 % | 39 % | 21 % | 12 % | **6.2 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gb-eng.svg" width="18" alt=""> England | L | 95 % | 40 % | 21 % | 11 % | **6.1 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/fr.svg" width="18" alt=""> France | I | 86 % | 33 % | 17 % | 8 % | **4.1 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/pt.svg" width="18" alt=""> Portugal | K | 81 % | 31 % | 15 % | 8 % | **3.6 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/de.svg" width="18" alt=""> Germany | E | 91 % | 28 % | 13 % | 6 % | **2.1 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ec.svg" width="18" alt=""> Ecuador | E | 87 % | 25 % | 12 % | 5 % | **2.1 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/nl.svg" width="18" alt=""> Netherlands | F | 85 % | 23 % | 11 % | 5 % | **2.0 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/au.svg" width="18" alt=""> Australia | D | 82 % | 23 % | 10 % | 4 % | **1.6 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ir.svg" width="18" alt=""> Iran | G | 80 % | 22 % | 9 % | 4 % | **1.5 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/uy.svg" width="18" alt=""> Uruguay | H | 85 % | 20 % | 10 % | 4 % | **1.5 %** |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/mx.svg" width="18" alt=""> Mexico | A | 83 % | 21 % | 8 % | 3 % | **1.3 %** |

### Grupos

<details open>
<summary><strong>Group A</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/mx.svg" width="18" alt=""> Mexico vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cz.svg" width="18" alt=""> Czechia | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 52 % | 26 % | 22 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/mx.svg" width="18" alt=""> Mexico vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/za.svg" width="18" alt=""> South Africa | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 52 % | 28 % | 20 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/mx.svg" width="18" alt=""> Mexico vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/kr.svg" width="18" alt=""> South Korea | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 38 % | 28 % | 34 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/za.svg" width="18" alt=""> South Africa vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cz.svg" width="18" alt=""> Czechia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 33 % | 28 % | 39 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/za.svg" width="18" alt=""> South Africa vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/kr.svg" width="18" alt=""> South Korea | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 22 % | 26 % | 53 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/kr.svg" width="18" alt=""> South Korea vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cz.svg" width="18" alt=""> Czechia | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 52 % | 24 % | 24 % |

</details>

<details open>
<summary><strong>Group B</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ba.svg" width="18" alt=""> Bosnia and Herzegovina vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/qa.svg" width="18" alt=""> Qatar | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 29 % | 25 % | 46 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ba.svg" width="18" alt=""> Bosnia and Herzegovina vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ch.svg" width="18" alt=""> Switzerland | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-2 | 11 % | 18 % | 71 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ca.svg" width="18" alt=""> Canada vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ba.svg" width="18" alt=""> Bosnia and Herzegovina | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 68 % | 21 % | 11 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ca.svg" width="18" alt=""> Canada vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/qa.svg" width="18" alt=""> Qatar | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 64 % | 21 % | 15 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ca.svg" width="18" alt=""> Canada vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ch.svg" width="18" alt=""> Switzerland | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1, +1 more | 35 % | 28 % | 37 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/qa.svg" width="18" alt=""> Qatar vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ch.svg" width="18" alt=""> Switzerland | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-2 | 15 % | 19 % | 67 % |

</details>

<details open>
<summary><strong>Group C</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/br.svg" width="18" alt=""> Brazil vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ht.svg" width="18" alt=""> Haiti | Programado | Predicción: 3-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 79 % | 13 % | 8 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/br.svg" width="18" alt=""> Brazil vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ma.svg" width="18" alt=""> Morocco | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 32 % | 30 % | 38 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/br.svg" width="18" alt=""> Brazil vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gb-sct.svg" width="18" alt=""> Scotland | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 70 % | 18 % | 12 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ht.svg" width="18" alt=""> Haiti vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gb-sct.svg" width="18" alt=""> Scotland | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 31 % | 24 % | 45 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ma.svg" width="18" alt=""> Morocco vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ht.svg" width="18" alt=""> Haiti | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 73 % | 18 % | 9 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ma.svg" width="18" alt=""> Morocco vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gb-sct.svg" width="18" alt=""> Scotland | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 65 % | 23 % | 12 % |

</details>

<details open>
<summary><strong>Group D</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/au.svg" width="18" alt=""> Australia vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/tr.svg" width="18" alt=""> Turkey | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1, +1 more | 50 % | 26 % | 25 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/py.svg" width="18" alt=""> Paraguay vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/au.svg" width="18" alt=""> Australia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 24 % | 30 % | 45 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/py.svg" width="18" alt=""> Paraguay vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/tr.svg" width="18" alt=""> Turkey | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1, +1 more | 37 % | 28 % | 34 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/us.svg" width="18" alt=""> United States vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/au.svg" width="18" alt=""> Australia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 32 % | 27 % | 41 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/us.svg" width="18" alt=""> United States vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/py.svg" width="18" alt=""> Paraguay | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 43 % | 28 % | 29 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/us.svg" width="18" alt=""> United States vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/tr.svg" width="18" alt=""> Turkey | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 50 % | 23 % | 27 % |

</details>

<details open>
<summary><strong>Group E</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cw.svg" width="18" alt=""> Curacao vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ec.svg" width="18" alt=""> Ecuador | Programado | Predicción: 0-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 10 % | 22 % | 68 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cw.svg" width="18" alt=""> Curacao vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ci.svg" width="18" alt=""> Ivory Coast | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 14 % | 22 % | 64 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/de.svg" width="18" alt=""> Germany vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cw.svg" width="18" alt=""> Curacao | Programado | Predicción: 3-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 80 % | 12 % | 7 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/de.svg" width="18" alt=""> Germany vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ec.svg" width="18" alt=""> Ecuador | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1, +1 more | 36 % | 31 % | 34 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/de.svg" width="18" alt=""> Germany vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ci.svg" width="18" alt=""> Ivory Coast | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 47 % | 26 % | 28 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ci.svg" width="18" alt=""> Ivory Coast vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ec.svg" width="18" alt=""> Ecuador | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-0 | 25 % | 36 % | 39 % |

</details>

<details open>
<summary><strong>Group F</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/jp.svg" width="18" alt=""> Japan vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/se.svg" width="18" alt=""> Sweden | Programado | Predicción: 3-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 75 % | 15 % | 10 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/jp.svg" width="18" alt=""> Japan vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/tn.svg" width="18" alt=""> Tunisia | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 62 % | 24 % | 14 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/nl.svg" width="18" alt=""> Netherlands vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/jp.svg" width="18" alt=""> Japan | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1, +1 more | 29 % | 26 % | 46 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/nl.svg" width="18" alt=""> Netherlands vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/se.svg" width="18" alt=""> Sweden | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-1 | 66 % | 18 % | 16 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/nl.svg" width="18" alt=""> Netherlands vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/tn.svg" width="18" alt=""> Tunisia | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 54 % | 25 % | 20 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/se.svg" width="18" alt=""> Sweden vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/tn.svg" width="18" alt=""> Tunisia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1, +1 more | 34 % | 28 % | 38 % |

</details>

<details open>
<summary><strong>Group G</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/be.svg" width="18" alt=""> Belgium vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/eg.svg" width="18" alt=""> Egypt | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 43 % | 29 % | 28 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/be.svg" width="18" alt=""> Belgium vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ir.svg" width="18" alt=""> Iran | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1, +1 more | 37 % | 27 % | 36 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/be.svg" width="18" alt=""> Belgium vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/nz.svg" width="18" alt=""> New Zealand | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 51 % | 24 % | 24 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/eg.svg" width="18" alt=""> Egypt vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ir.svg" width="18" alt=""> Iran | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 27 % | 30 % | 44 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/eg.svg" width="18" alt=""> Egypt vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/nz.svg" width="18" alt=""> New Zealand | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 40 % | 30 % | 31 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ir.svg" width="18" alt=""> Iran vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/nz.svg" width="18" alt=""> New Zealand | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 52 % | 25 % | 23 % |

</details>

<details open>
<summary><strong>Group H</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cv.svg" width="18" alt=""> Cape Verde vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/sa.svg" width="18" alt=""> Saudi Arabia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 28 % | 31 % | 41 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cv.svg" width="18" alt=""> Cape Verde vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/uy.svg" width="18" alt=""> Uruguay | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 13 % | 26 % | 61 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/sa.svg" width="18" alt=""> Saudi Arabia vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/uy.svg" width="18" alt=""> Uruguay | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 17 % | 31 % | 52 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/es.svg" width="18" alt=""> Spain vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cv.svg" width="18" alt=""> Cape Verde | Programado | Predicción: 3-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 80 % | 14 % | 6 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/es.svg" width="18" alt=""> Spain vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/sa.svg" width="18" alt=""> Saudi Arabia | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 71 % | 19 % | 10 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/es.svg" width="18" alt=""> Spain vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/uy.svg" width="18" alt=""> Uruguay | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 47 % | 29 % | 24 % |

</details>

<details open>
<summary><strong>Group I</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/fr.svg" width="18" alt=""> France vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/iq.svg" width="18" alt=""> Iraq | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 61 % | 24 % | 15 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/fr.svg" width="18" alt=""> France vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/no.svg" width="18" alt=""> Norway | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 46 % | 25 % | 30 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/fr.svg" width="18" alt=""> France vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/sn.svg" width="18" alt=""> Senegal | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 44 % | 27 % | 29 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/iq.svg" width="18" alt=""> Iraq vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/no.svg" width="18" alt=""> Norway | Programado | Predicción: 1-2 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 20 % | 25 % | 55 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/sn.svg" width="18" alt=""> Senegal vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/iq.svg" width="18" alt=""> Iraq | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 52 % | 28 % | 20 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/sn.svg" width="18" alt=""> Senegal vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/no.svg" width="18" alt=""> Norway | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 37 % | 26 % | 37 % |

</details>

<details open>
<summary><strong>Group J</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/dz.svg" width="18" alt=""> Algeria vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/at.svg" width="18" alt=""> Austria | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1, +1 more | 40 % | 28 % | 31 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/dz.svg" width="18" alt=""> Algeria vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/jo.svg" width="18" alt=""> Jordan | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 58 % | 22 % | 20 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ar.svg" width="18" alt=""> Argentina vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/dz.svg" width="18" alt=""> Algeria | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 60 % | 24 % | 16 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ar.svg" width="18" alt=""> Argentina vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/at.svg" width="18" alt=""> Austria | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 65 % | 23 % | 13 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/ar.svg" width="18" alt=""> Argentina vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/jo.svg" width="18" alt=""> Jordan | Programado | Predicción: 3-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 79 % | 14 % | 7 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/at.svg" width="18" alt=""> Austria vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/jo.svg" width="18" alt=""> Jordan | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 50 % | 24 % | 26 % |

</details>

<details open>
<summary><strong>Group K</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cd.svg" width="18" alt=""> Congo DR vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/co.svg" width="18" alt=""> Colombia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 17 % | 29 % | 54 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cd.svg" width="18" alt=""> Congo DR vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/uz.svg" width="18" alt=""> Uzbekistan | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-0 | 29 % | 36 % | 35 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/pt.svg" width="18" alt=""> Portugal vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/co.svg" width="18" alt=""> Colombia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 33 % | 26 % | 41 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/pt.svg" width="18" alt=""> Portugal vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/cd.svg" width="18" alt=""> Congo DR | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 52 % | 29 % | 19 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/pt.svg" width="18" alt=""> Portugal vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/uz.svg" width="18" alt=""> Uzbekistan | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 51 % | 27 % | 22 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/uz.svg" width="18" alt=""> Uzbekistan vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/co.svg" width="18" alt=""> Colombia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 0-1 | 20 % | 27 % | 53 % |

</details>

<details open>
<summary><strong>Group L</strong></summary>

| Partido | Estado | Resultado / Predicción | Por qué | L | E | V |
| --- | --- | --- | --- | ---: | ---: | ---: |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/hr.svg" width="18" alt=""> Croatia vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gh.svg" width="18" alt=""> Ghana | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 61 % | 23 % | 16 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/hr.svg" width="18" alt=""> Croatia vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/pa.svg" width="18" alt=""> Panama | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 56 % | 23 % | 21 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gb-eng.svg" width="18" alt=""> England vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/hr.svg" width="18" alt=""> Croatia | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-0 | 49 % | 28 % | 23 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gb-eng.svg" width="18" alt=""> England vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gh.svg" width="18" alt=""> Ghana | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 72 % | 19 % | 9 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gb-eng.svg" width="18" alt=""> England vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/pa.svg" width="18" alt=""> Panama | Programado | Predicción: 2-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 2-0 | 69 % | 19 % | 12 % |
| <img src="OracuMundial2026.Web/wwwroot/flags/4x3/gh.svg" width="18" alt=""> Ghana vs <img src="OracuMundial2026.Web/wwwroot/flags/4x3/pa.svg" width="18" alt=""> Panama | Programado | Predicción: 1-1 | Model: Or&#225;culo final<br>Signals: Fuerza de ataque ajustada por rival, Vulnerabilidad defensiva ajustada por rival, Grilla de marcadores Dixon-Coles, Marcador m&#225;s probable: 1-1 | 30 % | 26 % | 44 % |

</details>
<!-- oracumundial2026:snapshots:end -->

