function Purchase(nameProduct,price,quantity){
    this.nameProduct=nameProduct;
    this.price=Math.round(price*100)/100;
    this.quantity=quantity;
    this.getCost=function(){
        return (Math.round(this.price*this.quantity*100)/100);
    };
    this.toString=function(){
        return (this.nameProduct+';'+this.price+';'+this.quantity+';'+this.getCost());
    }
}
function DiscountPurchase(nameProduct,price,quantity,discont){
    Purchase.apply(this,arguments);
    this.discont=discont;
    var parentToString=this.toString;
    this.getCost=function(){
         return (Math.round((this.price*this.quantity*(1-this.discont/100))*100)/100);
    }
    this.toString=function(){
        var parentData=parentToString.call(this);
        var newData=parentData.split(';');
        //вставка скидки перед итоговым вычисление
        newData.splice(3,0,this.discont);
        //возврат новой строки с разделителями
        return newData.join(';');
    }
}

var purchases=[
    new Purchase("milk",2.11,4),
    new Purchase("breed",0.89,2),
    new Purchase("meat",5.43,6),
    new Purchase("fridge",122.31,1),
    new Purchase("telephone",232.09,3),
    
];
purchases[5]=new DiscountPurchase("apple",2.21,3,15);
purchases[6]=new DiscountPurchase("pear",3.5,3,10);
purchases[7]=new DiscountPurchase("juice",2.08,4,5);
purchases[8]=new DiscountPurchase("shoes",255.0,2,35);
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
           return total+=purchase.getCost();
       }
    }
}

var makeS=makeTotal();

for(var i=0;i<purchases.length;i++){
    makeS(purchases[i]);
}

document.write("<h2>Total: "+makeS()+"</h2>");