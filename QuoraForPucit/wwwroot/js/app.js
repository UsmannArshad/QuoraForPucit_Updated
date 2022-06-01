var collection = document.getElementsByClassName("like-btn");
var collection1 = document.getElementsByClassName("dislike-btn");
for (let i = 0; i < collection.length; i++) {
    collection[i].onclick = function () {
        console.log("gg");
        if (collection[i].style.backgroundColor !="rgb(2, 117, 216)")
    {
            collection[i].style.backgroundColor = "rgb(2, 117, 216)";
            collection1[i].disabled = true;
    }
    else
    {
            collection[i].style.backgroundColor = "rgb(255,255,255)";
            collection1[i].disabled = false;
    }  
  }
}
for (let i = 0; i < collection1.length; i++) {
  collection1[i].onclick=function(){
      if (collection1[i].style.backgroundColor !="rgb(217, 83, 79)")
    {
          collection1[i].style.backgroundColor = "rgb(217, 83, 79)";
          collection[i].disabled = true;
    }
    else
    {
          collection1[i].style.backgroundColor = "rgb(255,255,255)";
          collection[i].disabled = false;
    }  
  }
}