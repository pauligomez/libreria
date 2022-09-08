  //clase principal
public class libro{
    //metodo principal
    public static void Main(String[] args){
         //define una istancia de libreria como fabula y la inicialiso como nueva
        libros fabula=new libros();
        //configurar autor
        fabula.configurarautor("Gabriel");
         //configurar titulo
        fabula.configurartitulo("la cigarra y la hormiga");
        //configurar pagina
        fabula.configurarnumerodepaginas(300);
        //configurar ISBN
        fabula.configurarISBN("56789");
        //lee unos valores, los combierte y los muestra en pantalla
        fabula.tostring();

        libros fabula2=new libros();
        //configurar autor
        fabula2.configurarautor("los hermanos grimm");
         //configurar titulo
        fabula2.configurartitulo("la cenicienta");
        //configurar pagina
        fabula2.configurarnumerodepaginas(600);
         //configurar ISBN
        fabula2.configurarISBN("25878");
        //lee unos valores, los combierte y los muestra en pantalla
        fabula2.tostring();

    //condicional si
      if(fabula.consultarnumerodepaginas()>=fabula2.consultarnumerodepaginas()) {
        //muestra en pantalla fabula tiene mas pagina 
         Console.WriteLine (" tiene mas paginas");
      }
      //condicional sino
        else{
        //muestra en pantalla fabula2 tiene mas pagina 
          Console.WriteLine("la cenicienta tiene mas paginas");
        }
    }
    public class libros {
    private string ISBN;
    private string titulo;
    private string autor;
    private int numerodepaginas; 
// Las clases creadas con los atributos de los libros
public string consultarISBN(){
   return this.ISBN;
}   //Abrir un espacio en blanco para ingresar la variable
    public void configurarISBN(string isbn){
        // llama lo que haya en la variable ISBN
    this.ISBN=isbn;
}
public string consultartitulo(){
     return this.titulo;
} //Abrir un espacio en blanco para ingresar la variable
    public void configurartitulo(string titulo){
        this.titulo=titulo;
     }   // llama lo que haya en la variable titulo


public string consultarautor(){
    return this.autor;
} //Abrir un espacio en blanco para ingresar la variable

public void configurarautor(string autor){
    this.autor=autor;
 // llama lo que haya en la variable autor
}
public int consultarnumerodepaginas(){
 return this.numerodepaginas;
} //Abrir un espacio en blanco para ingresar la variable

public void configurarnumerodepaginas(int num){
    this.numerodepaginas=num;

// llama lo que haya en la variable numero de paginas

}
public void tostring(){
    Console.WriteLine("el libro "+this.titulo+" del autor "+this.autor+" tiene "+this.numerodepaginas+" paginas");
}
 
    }
      }