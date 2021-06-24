
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const points = JSON.parse(document.querySelector('#mapid').dataset.points);
const map = L.map('mapid').setView([52.230, 21.00], 6);
// add the OpenStreetMap tiles
L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="https://openstreetmap.org/copyright">OpenStreetMap contributors</a>'
}).addTo(map);

// show the scale bar on the lower left corner
L.control.scale().addTo(map);


const addIcon = (name) => L.icon({
    iconUrl: `../content/images/${name}.png`,

    iconSize: [35, 35], // size of the icon
    iconAnchor: [22, 30], // point of the icon which will correspond to marker's location
    popupAnchor: [-3, -76] // point from which the popup should open relative to the iconAnchor
});




// show a marker on the map
for (let i = 0; i < points.length; i++) {
    // Create a marker and set its position.
    L.marker({ lon: points[i].longtitude, lat: points[i].latitude }, {
        icon: addIcon(points[i].iconName) }).bindPopup(points[i].popup).addTo(map);

}

//add markers for other journeys
