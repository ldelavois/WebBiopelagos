// initialize the map
var map = L.map('map', { center: [-13.19658, 183.60855], zoom: 7 });

// load a tile layer
L.tileLayer('http://{s}.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',
}).addTo(map);

$.get("js/wallalis.json",function(data) {
    L.geoJSON(data, {
    }).bindPopup(function (layer) {
        return "<b>Campagne Wallalis</b><br>" +
            "Opération n°:<a href='./SetBases'>" + layer.feature.properties.set_base_id+"</a><br>" +
            "Coordonnées: [" + layer.feature.geometry.coordinates + "]<br>" +
            "Gear: " + layer.feature.properties.gear_id;

    }).addTo(map);
});


//layer.feature.properties.set_base_id
var Zooplankton = L.layerGroup();


