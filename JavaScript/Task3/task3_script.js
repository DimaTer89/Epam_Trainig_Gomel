function Purchase(nameProduct,price,quantity){
    this.nameProduct=nameProduct;
    this.price=Math.round(price*100)/100;
    this.quantity=quantity;
}
Purchase.prototype.getCost=function(){
    return (Math.round(this.price*this.quantity*100)/100);
};
Purchase.prototype.toString=function(){
    return (this.nameProduct+';'+this.price+';'+this.quantity+';'+this.getCost());
}

FixedDiscountPurchase.prototype=Object.create(Purchase.prototype);

function FixedDiscountPurchase(nameProduct,price,quantity,fixedDiscount){
    Purchase.apply(this,arguments);
    this.fixedDiscount=fixedDiscount;
}
FixedDiscountPurchase.prototype.getCost=function(){
    var result=Purchase.prototype.getCost.apply(this,arguments);
    return (Math.round((result-this.fixedDiscount)*100)/100);
}
FixedDiscountPurchase.prototype.toString=function()
{
    var parentData=Purchase.prototype.toString.apply(this,arguments);
    var newData=parentData.split(';');
    newData.splice(3,0,this.fixedDiscount);
    return newData.join(';');
}
 
var purchases=[
    new Purchase("milk",2.11,4),
    new Purchase("breed",0.89,2),
    new Purchase("meat",5.43,6),
    new Purchase("fridge",122.31,1),
    new Purchase("telephone",232.09,3),
    
];
purchases[5]=new FixedDiscountPurchase("apple",2.21,3,5.5);
purchases[6]=new FixedDiscountPurchase("pear",3.5,3,2.12);
purchases[7]=new FixedDiscountPurchase("juice",2.08,4,3.5);
purchases[8]=new FixedDiscountPurchase("shoes",255.0,2,135);

for(var i=0;i<purchases.length;i++){
    document.write("<p>"+purchases[i]+"</p>");
}

function makeTotal(purchase){
    var total=0;
    return function(purchase){
        if(purchase===undefined){
            return total;
        }
        return total+=purchase.getCost();
    }
}

var makeS=makeTotal();

for(var i=0;i<purchases.length;i++){
    makeS(purchases[i]);
}

document.write("<h2>Total:"+makeS()+"</h2>")