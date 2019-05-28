var mapboxTiles = L.tileLayer('http://{s}.basemaps.cartocdn.com/light_all/{z}/{x}/{y}.png', {
    attribution: '<a href="http://www.mapbox.com/about/maps/" target="_blank">Terms &amp; Feedback</a>'
});

var zooplanktonIcon = L.AwesomeMarkers.icon({
    prefix: 'fa',
    markerColor: 'green',
    icon: 'circle'
});

var ctdIcon = L.AwesomeMarkers.icon({
    prefix: 'fa',
    markerColor: 'orange',
    icon: 'circle'
});

var micronektonIcon = L.AwesomeMarkers.icon({
    prefix: 'fa',
    markerColor: 'red',
    icon: 'circle'
});

var map = L.map('map')
    .addLayer(mapboxTiles)
    .setView([-13.19658, 183.60855], 7);

// load a tile layer
L.tileLayer('https://{s}.tile.openstreetmap.fr/osmfr/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
}).addTo(map);

// EEZs / Nations
var eezLayer = L.tileLayer('http://tile1.mpatlas.org/tilecache/eezs/{z}/{x}/{y}.png', {
    tms: true,
    opacity: 0.3
}).addTo(map);

var promise = $.getJSON("js/wallalis.json");
promise.then(function (data) {
    var all = L.geoJson(data);
    var zooplankton = L.geoJson(data, {
        filter: function (feature, layer) {
            return feature.properties.gear_id == "Zooplankton multi-net";
        },
        pointToLayer: function (feature, latlng) {
            return L.marker(latlng, {
                icon: zooplanktonIcon
            }).bindPopup("<b>Campagne Wallalis</b><br>"
                + "Opération n°: <a href='./SetBases'>" + feature.properties.set_base_id + "</a><br>"
                + "Coordonnées: [" + feature.geometry.coordinates + "]<br>" +
                "Gear: " + feature.properties.gear_id).openPopup();
        }
    });
    var ctd = L.geoJson(data, {
        filter: function (feature, layer) {
            return feature.properties.gear_id == "CTD/Water";
        },
        pointToLayer: function (feature, latlng) {
            return L.marker(latlng, {
                icon: ctdIcon
            }).bindPopup("<b>Campagne Wallalis</b><br>"
            + "Opération n°: <a href='./SetBases'>" + feature.properties.set_base_id + "</a><br>"
            + "Coordonnées: [" + feature.geometry.coordinates + "] <br> " +
                "Gear: " + feature.properties.gear_id).openPopup();

        }
    });

    var micronekton = L.geoJson(data, {
        filter: function (feature, layer) {
            return feature.properties.gear_id == "Micronekton trawl";
        },
        pointToLayer: function (feature, latlng) {
            return L.marker(latlng, {
                icon: micronektonIcon
            }).bindPopup("<b>Campagne Wallalis</b><br>"
            + "Opération n°: <a href='./SetBases'>" + feature.properties.set_base_id + "</a><br>"
            + "Coordonnées: [" + feature.geometry.coordinates + "] <br> " +
                "Gear: " + feature.properties.gear_id).openPopup();

        }
    });


    map.fitBounds(all.getBounds(), {
        padding: [50, 50]
    });
    zooplankton.addTo(map)
    ctd.addTo(map)
    micronekton.addTo(map)
    // The JavaScript below is new    
    $("#all").click(function () {
        map.addLayer(zooplankton)
        map.addLayer(ctd)
        map.addLayer(micronekton)
    });

    $("#zooplankton").click(function () {
        map.addLayer(zooplankton)
        map.removeLayer(ctd)
        map.removeLayer(micronekton)
    });
    $("#ctd").click(function () {
        map.addLayer(ctd)
        map.removeLayer(zooplankton)
        map.removeLayer(micronekton)
    });

    $("#micronekton").click(function () {
        map.addLayer(micronekton)
        map.removeLayer(ctd)
        map.removeLayer(zooplankton)
    });

});