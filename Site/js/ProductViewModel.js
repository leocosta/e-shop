

function ProductViewModel() {
    var self = this;

    self.ProductList = [
        { Nome: "Camisa Flamengo", Peso: 2, Preco: 150, Marca: "Olypikus", UrlImagem: "../../Images/products/camisa1.jpg" },
        { Nome: "Camisa Atlético", Peso: 2, Preco: 220, Marca: "Nike", UrlImagem: "../../Images/products/camisa2.jpg" },
        { Nome: "Camisa Botafogo", Peso: 2, Preco: 70, Marca: "Puma", UrlImagem: "../../Images/products/camisa3.jpg" }];

}

ko.applyBindings(new ProductViewModel());