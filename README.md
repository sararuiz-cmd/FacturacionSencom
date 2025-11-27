# Proyect_Sencom_Form

> Aplicación de escritorio (WinForms .NET Framework 4.7.2) para gestión y análisis de facturación energética fotovoltaica.

## Tabla de Contenido
- [Descripción](#descripción)
- [Características Principales](#características-principales)
- [Capturas (Placeholder)](#capturas-placeholder)
- [Arquitectura y Capas](#arquitectura-y-capas)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Requisitos](#requisitos)
- [Instalación y Ejecución](#instalación-y-ejecución)
- [Flujo de Uso](#flujo-de-uso)
- [Temas (Dark / Light)](#temas-dark--light)
- [Navegación de Formularios](#navegación-de-formularios)
- [Generación de Facturas](#generación-de-facturas)
- [Predicción Inteligente (IA)](#predicción-inteligente-ia)
- [Exportación Profesional a PDF](#exportación-profesional-a-pdf)
- [Gráficos](#gráficos)
- [Validaciones](#validaciones)
- [Extensión / Personalización](#extensión--personalización)
- [Contribuciones](#contribuciones)

---
## Descripción
La aplicación permite registrar usuarios, generar facturas simuladas de producción eléctrica, analizar evolución mensual, predecir montos futuros mediante un servicio sencillo de IA, exportar reportes en PDF con diseño profesional y visualizar tendencias en gráficos interactivos.

## Características Principales
| Módulo | Descripción |
|--------|-------------|
| Autenticación | Registro e inicio de sesión con validaciones. |
| Facturación | Generación de facturas mensuales simuladas con acumulados. |
| Historial Persistente | Reapertura de `FrmFactura` mantiene facturas acumuladas. |
| Predicción IA | Estimación de montos futuros basada en historial. |
| Exportación PDF | Documento formal con encabezado, pie, tablas estilizadas. |
| Visualización | Gráfica de producción mensual (Chart WinForms). |
| Temas | Alterna entre tema claro y oscuro dinámicamente. |
| Navegación Única | Solo un formulario activo a la vez (`SingleFormContext`). |

## Capturas (Placeholder)
Agregue aquí imágenes de los formularios:
```
/docs/img/login.png
/docs/img/main.png
/docs/img/facturas.png
/docs/img/pdf.png
```

## Arquitectura y Capas
- Capa UI (`UI/`): Formularios WinForms (Login, Main, Factura, Predicción, Gráfico, Visor PDF).
- Capa Business (`Business/`): Lógica de dominio: generación de facturas, predicción, PDF, validaciones y temas.
- Capa Domain (`Domain/`): Entidades (`Factura`, `Cliente`, `ArbolFacturas`, etc.).
- Infraestructura ligera integrada (no base de datos; almacenamiento en memoria durante la ejecución).

## Estructura del Proyecto
```
Proyect_Sencom_Form/
 ?? Program.cs
 ?? SingleFormContext.cs
 ?? UI/
 ?   ?? FrmLogin.*
 ?   ?? FrmMain.*
 ?   ?? FrmFactura.*
 ?   ?? FrmPrediccionIA.*
 ?   ?? FrmGrafico.*
 ?   ?? FrmVisorPDF.*
 ?? Business/
 ?   ?? FacturaController.cs
 ?   ?? PdfService.cs
 ?   ?? PrediccionIAService.cs
 ?   ?? ValidadorFactura.cs / ValidadorUsuario.cs
 ?   ?? ThemeManager.cs
 ?   ?? AuthService.cs
 ?? Domain/
 ?   ?? Cliente.cs
 ?   ?? Factura.cs
 ?   ?? ArbolFacturas.cs / NodoFactura.cs
 ?? Properties/
```

## Requisitos
- Windows con .NET Framework 4.7.2
- Visual Studio 2019+ o equivalente.
- Paquete NuGet: `iTextSharp` para generación de PDF.

## Instalación y Ejecución
1. Clonar repositorio:
   ```bash
   git clone https://github.com/<usuario>/Prueba_SencomForm.git
   ```
2. Abrir la solución en Visual Studio.
3. Restaurar paquetes (NuGet restore automático).
4. Compilar en modo `Debug` o `Release`.
5. Ejecutar (inicia en `FrmLogin`).

## Flujo de Uso
1. Registrar usuario (opcional) o iniciar sesión.
2. Acceder al menú principal (`FrmMain`).
3. Generar facturas (ingresar cliente, capacidad y meses) en `FrmFactura`.
4. Consultar gráfico de producción en `FrmGrafico`.
5. Entrenar y predecir montos en `FrmPrediccionIA`.
6. Exportar PDF y visualizarlo en `FrmVisorPDF`.
7. Cerrar formularios: vuelve automáticamente a `FrmMain` o `FrmLogin` según contexto.

## Temas (Dark / Light)
El `ThemeManager` aplica colores y fuentes a cada formulario. El botón de alternancia en `FrmMain` fuerza cambio inmediato sin reiniciar la aplicación.

## Navegación de Formularios
`SingleFormContext` garantiza que sólo un formulario se muestre. Al cerrar:
- Formularios secundarios: regresan a `FrmMain`.
- `FrmMain`: regresa a `FrmLogin`.
- `FrmLogin` cerrado: termina la aplicación.

## Generación de Facturas
`FacturaController` simula producción mensual con variaciones aleatorias calculando:
- Producción del mes y acumulada.
- Montos por kWh (tarifa fija configurable en código).
- Inserción en árbol (`ArbolFacturas`) para búsqueda ordenada.
El `DataGridView` se rellena con el historial completo persistido en memoria mientras dure la sesión.

## Predicción Inteligente (IA)
`PrediccionIAService` (simplificado) entrena un modelo básico derivado de histórico para estimar monto futuro. Requiere al menos un conjunto de facturas generadas.

## Exportación Profesional a PDF
`PdfService` crea un reporte con:
- Encabezado con marca del sistema.
- Pie con fecha y numeración de página.
- Secciones estilizadas (Cliente / Factura / Totales).
- Tabla de montos con colores suaves y fuentes jerarquizadas.
Personalizable editando `PdfService.cs` (márgenes, colores, fuentes).

## Gráficos
`FrmGrafico` usa `System.Windows.Forms.DataVisualization.Charting` para columnas de producción kWh por mes, con ejes y títulos configurados.

## Validaciones
Clases `ValidadorFactura` y `ValidadorUsuario` aseguran datos consistentes (nombres, dirección, números positivos, formato de credenciales). Mensajes claros en UI.

## Extensión / Personalización
Ideas:
- Persistencia en BD (EF / SQLite).
- Cacheo de PDFs generados.
- Internacionalización (multi-idioma).
- Roles de usuario y auditoría.
- Reportes adicionales (comparativos trimestrales / anuales).
- Gráficos múltiples (líneas, áreas, stacked).

## Contribuciones
1. Crear rama feature:
   ```bash
   git checkout -b feature/mi-mejora
   ```
2. Realizar cambios y commit.
   ```bash
   git commit -m "feat: mejora X"
   ```
3. Push y Pull Request.
