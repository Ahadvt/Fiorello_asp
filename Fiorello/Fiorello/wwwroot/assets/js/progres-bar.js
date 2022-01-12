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

    let Thirdanimate=$("div[data-id='animate-third']")
    let Firstanimate=$("div[data-id='animate-first']")
    let Secondanimate=$("div[data-id='animate-second']")
    
    $(document).scroll(function(){
        let scroll=$(document).scrollTop()
        if(scroll>200){
        Thirdanimate.css("animation-name","third")
        Firstanimate.css("animation-name","first")
        Secondanimate.css("animation-name","second")
        }
        
    })

    let firsts=document.querySelectorAll(".progresfirst")
    let seconds=document.querySelectorAll(".progressecond")
    let thirds=document.querySelectorAll(".progresthird")

    firsts.forEach(first=>{
        let dataId1=first.getAttribute("data-id")
        let progresvalue1=0
        let progresvaluend1= parseInt(dataId1)

        let progres=setInterval(() => {
            progresvalue1++
            first.textContent= `${progresvalue1}%`
            if(progresvalue1==progresvaluend1 ){
                clearInterval(progres)
            }
        },20);

    })

    thirds.forEach(third=>{
        let dataId3=third.getAttribute("data-id")
        let progresvalue3=0
        let progresvaluend3= parseInt(dataId3)


        let progresss=setInterval(() => {
            progresvalue3++
            third.textContent= `${progresvalue3}%`
            if(progresvalue3==progresvaluend3 ){
                clearInterval(progresss)
            }
        },20);

    })
    seconds.forEach(second=>{
        let dataId2=second.getAttribute("data-id")
        let progresvalue2=0
        let progresvaluend2= parseInt(dataId2)

        let progress=setInterval(() => {
            progresvalue2++
            second.textContent= `${progresvalue2}%`
            if(progresvalue2==progresvaluend2 ){
                clearInterval(progress)
            }
        },20);

    }) 

    })



  