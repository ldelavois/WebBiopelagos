// initialize the map
var map = L.map('map', { center: [-13.19658, 183.60855], zoom: 7 });

// load a tile layer
L.tileLayer('https://{s}.tile.openstreetmap.fr/osmfr/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors',
}).addTo(map);

var scale = L.control.scale(); // Creating scale control
scale.addTo(map); // Adding scale control to the map


$.get("js/wallalis.json", function (data) {
    L.geoJSON(data, {
    }).bindPopup(function (layer) {
        return "<b>Campagne Wallalis</b><br>" +
            "Opération n°:<a href='./SetBases'>" + layer.feature.properties.set_base_id + "</a><br>" +
            "Coordonnées: [" + layer.feature.geometry.coordinates + "]<br>" +
            "Gear: " + layer.feature.properties.gear_id;

    }).addTo(map);
});



////codage des filtres
//var zooplanktonIcon = L.AwesomeMarkers.icon({
//    prefix: 'fa',
//    markerColor: 'green',
//    icon : 'circle'
 
//});

//var ctdIcon = L.AwesomeMarkers.icon({
//    prefix: 'fa',
//    markerColor: 'red',
//    icon: 'circle'
//});

//var micronektonIcon = L.AwesomeMarkers.icon({
//    prefix: 'fa',
//    markerColor: 'orange',
//    icon: 'circle'
//});


//var jsonFile = $.getJSON("js/wallalis.json");
//jsonFile.then(function (data) {
//    var all = L.geoJSON(data);
//    var zooplankton = L.geoJson(data, {
//        filter: function (layer) {
//            return layer.feature.properties.gear_id == "Zooplankton multi-net";
//        },
//        pointToLayer: function (latlng) {
//            return L.marker(latlng, {
//                icon: zooplanktonIcon
//            });
//        }
//    });

//    var ctd = L.geoJson(data, {
//        filter: function (layer) {
//            return layer.feature.properties.gear_id == "CTD/Water";
//        },
//        pointToLayer: function (latlng) {
//            return L.marker(latlng, {
//                icon: ctdIcon
//            });
//        }
//    });

//    var micronekton = L.geoJson(data, {
//        filter: function (layer) {
//            return layer.feature.properties.gear_id == "Micronekton trawl";
//        },
//        pointToLayer: function (latlng) {
//            return L.marker(latlng, {
//                icon: micronektonIcon
//            });
//        }
//    });



//    map.fitBounds(all.getBounds(), {
//        padding: [50, 50]
//    });
//    zooplankton.addTo(map)
//    ctd.addTo(map)
//    micronekton.addTo(map)

//    // The JavaScript below is new
//    $("#all").click(function () {
//        map.addLayer(all)
//    });
//    $("#zooplankton").click(function () {
//        map.addLayer(zooplankton)
//        map.removeLayer(all)
//        map.removeLayer(ctd)
//        map.removeLayer(micronekton)
//    });

//    $("#ctd").click(function () {
//        map.addLayer(ctd)
//        map.removeLayer(all)
//        map.removeLayer(zooplankton)
//        map.removeLayer(micronekton)
//    });

//    $("#micronekton").click(function () {
//        map.addLayer(micronekton)
//        map.removeLayer(all)
//        map.removeLayer(zooplankton)
//        map.removeLayer(ctd)

//    });

//});
