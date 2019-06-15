function Purchase(nameProduct,price,quantity){
    this.nameProduct=nameProduct;
    this.price=Math.round(price*100)/100;
    this.quantity=quantity;
}
Purchase.prototype.getCost=function(){
    return (Math.round(this.price*this.quantity*100)/100);
}
Purchase.prototype.toString=function(){
    return (this.nameProduct+';'+this.price+';'+this.quantity+';'+this.getCost());
}

function DiscountPurchase(nameProduct,price,quantity,discount){
    Purchase.apply(this,arguments);
    this.discount=discount;
    this.getCost=function(){
         var total=Purchase.prototype.getCost.apply(this,arguments);
         return (Math.round(total*(1-this.discount/100)*100)/100);
    }
    this.toString=function(){
        var parentData=Purchase.prototype.toString.apply(this,arguments);
        var newData=parentData.split(';');
        newData.splice(3,0,this.discount);
        return newData.join(';');
    }
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
FixedDiscountPurchase.prototype.toString=function(){
    var parentData=Purchase.prototype.toString.apply(this,arguments);
    var newData=parentData.split(';');
    newData.splice(3,0,this.fixedDiscount);
    return newData.join(';');
}

var purchases=[
    new Purchase("milk",2.11,4),
    new Purchase("breed",0.89,2),
    new Purchase("meat",5.43,6),
    new DiscountPurchase("shoes",255.0,2,35),
    new DiscountPurchase("fridge",122.31,1,10),
    new DiscountPurchase("telephone",232.09,3,30),
    new FixedDiscountPurchase("apple",2.21,3,5.5),
    new FixedDiscountPurchase("pear",3.5,3,2.12),
    new FixedDiscountPurchase("juice",2.08,4,3.5)
];
function ShowArray(object){
    document.write("<p>"+object+"</p>");
}
document.write("<h2>1).Original data:</h2>")
purchases.forEach(ShowArray);

document.write("<h2>2).TotalCost>20:</h2>")
var total=purchases.filter(function(purchase){
    return (purchase.getCost()>20);
})
total.forEach(ShowArray);

document.write("<h2>3).Changes base classes(map):</h2>")
var mapArr=purchases.map(function(object){
    return ((!("discount" in object))&&(!("fixedDiscount" in object))) ?new DiscountPurchase(object.nameProduct,object.price,object.quantity,object.quantity*2):object;
})
mapArr.forEach(ShowArray);

document.write("<h2>4).Every purchasies cost>50</h2>");
function IsCostMore(object){
    return (object.getCost()>50);
};
document.write("<p>"+purchases.every(IsCostMore)+"</p>");
document.write("<h2>5).Some purchasies cost>50</h2>");
document.write("<p>"+purchases.some(IsCostMore)+"</p>");

document.write("<h2>Purchase with max cost(reduce)</h2>");
var maxCostPurchase=purchases.reduce(function(maxCost,currentObject){
    return ((maxCost.getCost()<currentObject.getCost())?maxCost=currentObject:maxCost);
},purchases[0]);
document.write("<p>"+maxCostPurchase+"</p>");

document.write("<h2>New purchase(max word length,max price,min quantity)</h2>")
var newPurchase=purchases.reduceRight(function(previewItem,currentItem){
    if(previewItem.nameProduct<currentItem.nameProduct){
        previewItem.nameProduct=currentItem.nameProduct;
    }
    if(previewItem.price<currentItem.price){
        previewItem.price=currentItem.price;
    }
    if(previewItem.quantity>currentItem.quantity){
        previewItem.quantity=currentItem.quantity;
    }
    return previewItem;
},new Purchase(purchases[purchases.length-1].nameProduct,purchases[purchases.length-1].price,purchases[purchases.length-1].quantity));
document.write("<p>"+newPurchase+"</p>");