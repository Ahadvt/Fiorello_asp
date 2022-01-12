$(document).ready(function(){
    $(".content .icon").css("display","none")
    $(document).scroll(function(){
        let scrolpax=$(document).scrollTop()
        
        if (scrolpax>600) {
            $(".content .icon").css("display","flex")
        }else{
            $(".content .icon").css("display","none")
        }
        $(".content .icon").click(function(){
            $(document).scrollTop(0)
        })
    })

    $(".categoryF").click(function(e){
        e.preventDefault()
      let id=  $(this).attr("id")
      let cards=document.querySelectorAll(".all")
      cards.forEach(card=>{
        card.style.display="none"
        if ($(this).attr("id")==1) {
            card.style.display="block"
        }
        if (card.getAttribute("data-id")==$(this).attr("id")) {
            
            card.style.display="block"
        }
      })
    })
  
$(document).scroll(function(){
    $("#secondheader").hide()
    let scrol=$(document).scrollTop()
    if (scrol>610) {
        $("#secondheader").show()
    }
})

    let search=$(".search-icon")
    search.click(function(){
       let searchInput= $(this).next("div")
       searchInput.slideToggle(200)
       console.log(searchInput);
       
       
    })

    $(".icon-close").click(function(){
        
        let menu=document.querySelector(".menuresponsive")
        
        // menu.style.display="none"
       let a= $(this).parent()
       a.slideToggle()
        
       
    })
    $(".icon-menu").click(function(){
        
        let menu=$(this).next()
        menu.slideToggle()
        
       
    })
   
let resp=$(".li")
$(resp).click(function(){
    let u=$(this).children("ul")
    u.slideToggle()
    
})

let filterresponsive=document.querySelector("#filterresponsive")
let ulresp=document.querySelector("#category")

$("#filterresponsive").click(function(){

    $("#categoryresp").slideToggle()
})



$(".text-filter p").hover(function(){
    $(".Filters").slideToggle()
    
})
 

    
$('.owl-carousel').owlCarousel({
    loop:true,
    margin:10,
    nav:true,
    dots:false,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:1
        }
    }
})


$('.parallax-window').parallax({imageSrc: './assets/img/h3-background-img.jpg'});


//let AdtoCard=document.querySelectorAll(".adCart")
//let Products=document.querySelector(".basket-products .Basket-top")

//AdtoCard.forEach(btn=>{
    
//    btn.onclick=function(ev){
//        ev.preventDefault()
//        let ID=this.parentNode.parentNode.getAttribute("data-id")
//        let Img=this.parentNode.parentNode.children[0].children[0].getAttribute("src")
//        let Name=this.parentNode.parentNode.children[1].children[0].innerText;
//        let Price=this.parentNode.children[1].innerText;
        
//        if (localStorage.getItem("basket")==null) {
//            localStorage.setItem("basket",JSON.stringify([]))
//        }
//        let basket=JSON.parse(localStorage.getItem("basket"))
//        let exsistProduct=basket.find((p)=>p.id==ID)
//        if (exsistProduct===undefined) {
//            let product={
//                id:ID,
//                img:Img,
//                name:Name,
//                price:Price,
//                count:1
//            }
//            basket.push(product)
//            getProductbody(product)
           
//        }else{
//            // let Count=document.getElementById(`${exsistProduct.id}`)
//            // +Count.innerHTML++;
//            exsistProduct.count++;

//        }

//        localStorage.setItem("basket", JSON.stringify(basket))
//        calcCount()
//        TotalPrice()
        
//        getProducts()
//    }
//})

//calcCount()
//function calcCount(){
//    if (localStorage.getItem("basket")==null) {
//        localStorage.setItem("basket",JSON.stringify([]))
//    }
//    let countProduct= document.querySelector(".basket-icon span")
   
//    let basket=JSON.parse(localStorage.getItem("basket"))
//    countProduct.innerHTML=basket.length
//}
//TotalPrice()

//function TotalPrice(){
//    if (localStorage.getItem("basket")==null) {
//        localStorage.setItem("basket",JSON.stringify([]))
//    }
//    getProducts()
    
//    // let Price=document.querySelector(".count-price .price")
//    // let pricetext = $(Price).text()
//    let basket=JSON.parse(localStorage.getItem("basket"))

//    let totalpr =document.querySelector(".total-price .total p")
    

//   let total= basket.reduce((totall,p)=>{
//       totall = parseInt(totall)
//       price = parseInt(p.price)
//       count = parseInt(p.count)
//        return totall += price * count
//    },0)

//    $(totalpr).text(total)

//}

//getProducts()
//   function getProducts(){
//       let basket=JSON.parse(localStorage.getItem("basket"))
       
//       let baskettop = document.querySelector(".Basket-top")
//       baskettop.innerHTML = ""
//       basket.forEach((p)=>{
//         getProductbody(p)
//       })
//   }

//   function getProductbody(product){

//Products.innerHTML+=`
//<ul>
//                                <li data-id="${product.id}">
//                                    <div class="img">
//                                        <img src="${product.img}" alt="">
//                                    </div>
//                                    <div class="delete-name">
//                                        <div class="name">
//                                            <p>${product.name}</p>
//                                        </div>
                                
//                                        <i class="fas fa-times" onclick="removeProduct(this)" ></i>
//                                    </div>
//                                    <div class="count-price">
//                                         <div id="${product.id}" class="count">
//                                             ${product.count} x 
//                                         </div>
//                                         <div class="price">
//                                             ${product.price}
//                                         </div>
//                                    </div>
//                                </li>
                                
//                            </ul>
                            
//`   
    
//   }
   
 
 let category=$("#category li")

 category.click(function(){
     
 })


})

//function removeItem(id){
//    let basket=JSON.parse(localStorage.getItem("basket"))
//    const newItemSet=basket.filter((i)=>i.id !==id)
//    localStorage.setItem("basket",JSON.stringify(newItemSet))
//}

//function removeProduct(e){
//    removeItem(e.parentElement.parentElement.getAttribute("data-id"))
//    e.parentElement.parentElement.remove();
//    // calcCount()
//    // TotalPrice()
//}







