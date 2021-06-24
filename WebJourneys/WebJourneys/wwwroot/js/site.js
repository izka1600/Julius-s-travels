// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var map = L.map('mapid').setView([52.230, 21.00], 6);
// add the OpenStreetMap tiles
L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="https://openstreetmap.org/copyright">OpenStreetMap contributors</a>'
}).addTo(map);

// show the scale bar on the lower left corner
L.control.scale().addTo(map);


var redIcon = L.icon({
    iconUrl: '../content/images/red_heart.png',

    iconSize: [35, 35], // size of the icon
    iconAnchor: [22, 30], // point of the icon which will correspond to marker's location
    popupAnchor: [-3, -76] // point from which the popup should open relative to the iconAnchor
});
var yellowIcon = L.icon({
    iconUrl: '../content/images/yell_heart.png',

    iconSize: [35, 35], // size of the icon
    iconAnchor: [22, 30], // point of the icon which will correspond to marker's location
    popupAnchor: [-3, -76] // point from which the popup should open relative to the iconAnchor
});



// show a marker on the map
L.marker({ lon: 21.00, lat: 52.230 }, { icon: redIcon }).bindPopup('Początek każdej przygody').addTo(map);

//add markers for other journeys
