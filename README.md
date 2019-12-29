# Introducción a los Scripts en Unity.

 -Autor: Gabriel Melián Hernández.
 
 Gif para ver su funcionamiento: https://gyazo.com/34e4d808fe6aaeabd2d6b069a17e91f4
 
 
 En esta práctica se realiza la implementación de un script para llevar a cabo el movimiento de una Esfera controlada por teclado por el usuario.
 Para llevar a cabo este movimiento en primer lugar definimos los dos valores numéricos que queramos que tome nuestra esfera a la hora de rotar y la velocidad de la misma. En nuestro caso estos valores serán.
    
    public float rotacion = 100f;
    public float velocidad = 10f;
    
A continuación definiremos el comportamiento de la Esfera, para su movimiento con las teclas WASD y para su rotación con las teclas QE, para ello usaremos Input.GetKey(KeyCode.X) para reconocer la tecla que se esta pulsando en el teclado y poder luego proceder a su interpretación siendo para el movimiento el uso de transform.Translate y transform.Rotate para la rotacion, por esto nuestros metodos para la rotacion y para el movimiento quedarán de la siguiente manera.

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(new Vector3(0f, -rotacion, 0f) * Time.deltaTime);
            
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
            
Por último para crear el campo que permita elegir la velocidad a la que se mueve la esfera (si queremos cambiar el valor inicial) usaremos las teclas IH, de la misma manera que en los métodos anteriores, pero sin actualizar ningun valor de la esfera sino actualizando el valor de la variable velocidad creada al inicio.

        if (Input.GetKey(KeyCode.H)) 
            velocidad = velocidad + 1;
        if (Input.GetKey(KeyCode.L))
            velocidad = velocidad - 1;
            
Para que todos estos métodos funcionen correctamente haremos una llamada a cada uno de ellos en el Update.
