// initialize the map
var map = L.map('map').setView([-13.19658, 183.60855], 7);

// load a tile layer
L.tileLayer('http://{s}.tile.osm.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',
}).addTo(map);




$.get("js/wallalis.json",function(data) {
    L.geoJSON(data, {
    }).bindPopup(function (layer) {
        return "<b>Campagne Wallalis</b><br>" +
            "Opération n°: <a asp-action='Details' asp-route-id='layer.feature.properties.set_base_id'>"
            + layer.feature.properties.set_base_id +
            "</a><br>" +
            "Coordonnées: [" + layer.feature.geometry.coordinates + "]<br>" +
            "Gear: " + layer.feature.properties.gear_id;

    }).addTo(map);
});



var Zooplankton = L.layerGroup();


