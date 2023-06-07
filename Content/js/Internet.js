const wrapper = document.querySelector(".wrapper"),
    toast = wrapper.querySelector(".toast"),
    title = toast.querySelector("span"),
    subTitle = toast.querySelector("p"),
    wifiIcon = toast.querySelector(".icon"),
    closeIcon = toast.querySelector(".close-icon");




window.onload = () => {
    function ajax() {
        let xhr = new XMLHttpRequest(); //creating new XML object
        xhr.open("GET", "https://jsonplaceholder.typicode.com/posts", true); //sending get request on this URL
        xhr.onload = () => { //once ajax loaded
            //if ajax status is equal to 200 or less than 300 that mean user is getting data from that provided url
            //or his/her response status is 200 that means he/she is online
            
            if (xhr.status == 200 && xhr.status < 300) {
                //toast.classList.remove("offline");
                //title.innerText = "Centro Biomedico";
                //subTitle.innerText = "alerta!Internet Esta Conectado.";
                //wifiIcon.innerHTML = '<i class="uil uil-wifi"></i>';
                //closeIcon.onclick = () => { //hide toast notification on close icon click
                //    wrapper.classList.add("hide");
                //}
                setTimeout(() => { //hide the toast notification automatically after 5 seconds
                    wrapper.classList.add("hide");
                }, 1000);
            } else {
                offline(); //calling offline function if ajax status is not equal to 200 or not less that 300
            }
        }
        xhr.onerror = () => {
            offline(); ////calling offline function if the passed url is not correct or returning 404 or other error
        }
        xhr.send(); //sending get request to the passed url
    }

    function offline() { //function for offline
        visible_elemento("Contenedor")
        wrapper.classList.remove("hide");
        toast.classList.add("offline");
        title.innerText = "Centro Biomedico";
        subTitle.innerText = "Opps! Internet esta Desconectado.";
        wifiIcon.innerHTML = '<i class="uil uil-wifi-slash"></i>';
    }

    setInterval(() => { //this setInterval function call ajax frequently after 100ms
        ajax();
    }, 100);
}


//var status = 'online';
//var current_status = 'online';

//function check_internet_connection() {

//    if (navigator.onLine) {

//        status = 'online';
//    }
//    else {
//        status = 'offline';
//    }

//    if (current_status == status) {

//        if (status == 'online') {
//            /*alert("Internet connected")*/
//            swal({
//                text: "Internet connected",
//                icon: "success",
//                button: "OK",
//            });
//        }
//        else {
//            //alert("Opps! Internet is disconnected.")
//            swal({
//                text: "Opps! Internet is disconnected.",
//                icon: "warning",
//                button: "OK",

//            });

//        }

//        current_status = status;

//    }
//}

//check_internet_connection();

//setInterval(function () {
//    check_internet_connection();

//}, 5000);
