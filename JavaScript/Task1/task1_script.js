function Purchase(nameProduct,price,quantity){
    this.nameProduct=nameProduct;
    this.price=Math.round(price*100)/100;
    this.quantity=quantity;
    this.getCoast=function(){
        return (Math.round(this.price*this.quantity*100)/100);
    }
    this.toString=function(){
        return (this.nameProduct+';'+this.price+';'+this.quantity+';'+this.getCoast());
    }
}


var purchases=[
    new Purchase("milk",2.11,4),
    new Purchase("breed",0.89,2),
    new Purchase("meat",5.43,6),
    new Purchase("fridge",122.31,1),
    new Purchase("telephone",232.09,3)
];


for(var i=0;i<purchases.length;i++){
    document.write("<p>"+purchases[i]+"</p>");
}

function makeTotal(purchase){
    var total=0;
    return function(purchase){
       if(purchase===undefined){
           return total;
       }
       else{
           return total+=purchase.getCoast();
       }
    }
}

var makeS=makeTotal();

for(var i=0;i<purchases.length;i++){
    makeS(purchases[i]);
}

document.write("<h2>Total: "+makeS()+"</h2>");