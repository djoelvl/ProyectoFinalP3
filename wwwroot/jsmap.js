﻿
   

        var mymap
    function InitMapa() {
        mymap = L.map('mapid').setView([18.735693, -70.162651], 13);
      

        L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', {
            attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>, Imagery ©️ <a href="https://www.mapbox.com/">Mapbox</a>',
            maxZoom: 18,
            id: 'mapbox/streets-v11',
            tileSize: 512,
            zoomOffset: -1,
            accessToken: 'pk.eyJ1IjoiaXNyYWVsZ3YiLCJhIjoiY2tpMHJ1dWJuMTA1NTJ5cXFwZGNiMXc5YiJ9.buarjcSJm2LkMn1FfffNcQ'
        }).addTo(mymap);
    }
    
