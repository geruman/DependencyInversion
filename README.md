# Dependency Inversion


- Las clases de alto nivel no deberían depender de las clases de bajo nivel. Ambas deberían depender de las abstracciones.
- Las abstracciones no deberían depender de los detalles. Los detalles deberían depender de las abstracciones.

## OrderService es capaz de trabajar con cualquier proveedor de correo porque solo hace uso de la interfaz no de la clase en si.
El cambiar de proveedor de correo no es un problema porque  no tenemos una fuerte dependencia hacia la clase.
