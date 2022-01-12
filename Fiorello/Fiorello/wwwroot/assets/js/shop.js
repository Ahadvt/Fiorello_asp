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

let btns=document.querySelectorAll(".butns .butn")
let btna=document.querySelector(".butns .butn")
$(btna).css("backgroundColor", "#F34F3F")
$(btna).css("color", "white")


btns.forEach(btn=>{
    let id= $(btn).attr("data-id")
         let card=document.getElementById(id)
         let cards=$(card).parent()
         cards.children().hide()
         $(card).show()
        

    $(btn).click(function(){
        $(this).parent().children().not(this).css("backgroundColor","white")
        $(this).parent().children().not(this).css("color","#1b1b1b")
        cards.children().hide()
         $(card).show()
         $(btn).css("backgroundColor", "#F34F3F")
         $(btn).css("color", "white")
         
     })
})



    $(document).scroll(function(){
        $("#secondheader").hide()
        
        let scrol=$(document).scrollTop()
        if (scrol>610) {
            $("#secondheader").show()
            
        }else{
            $("#secondheader").hide()
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
            
            menu.style.display="none"
            console.log(menu);
           
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
        
    })
    
    
    
    
    
    
    
    
    