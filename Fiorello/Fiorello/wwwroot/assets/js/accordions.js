$(document).ready(function(){

  
    
    
    
        $(document).scroll(function(){
            $("#secondheader").hide()
            
            let scrol=$(document).scrollTop()
            if (scrol>510) {
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


        $(document).ready(function(){

            $(".card-header").click(function(){
             if($(this).next(".card-body").hasClass("active")){
               $(this).next(".card-body").removeClass("active").slideUp()
              $(this).children("span").removeClass("fa-minus").addClass("fa-plus")	
             }
           else{
             $(".card .card-body").removeClass("active").slideUp()
             $(".card .card-header span").removeClass("fa-minus").addClass("fa-plus");
             $(this).next(".card-body").addClass("active").slideDown()
              $(this).children("span").removeClass("fa-plus").addClass("fa-minus")
            }
            })
          })