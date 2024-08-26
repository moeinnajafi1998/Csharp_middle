
class Animal{
    // this is a property
    public string? Name {get; set;}
    // this is another property
    public string? Color {get; set;}
    // default constructor. Even when we don't create any constructor, this construcotor will be created as default
    // if we create another constructor, this constructor will be not created except we create it ourselves
    public Animal(){

    }

    public Animal(string name,string color){
        this.Name = name;
        this.Color = color;
    }

    public Animal(string name){
        this.Name = name;
    }
}