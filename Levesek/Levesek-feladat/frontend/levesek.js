document.addEventListener("DOMContentLoaded", function () {
    var table = document.getElementById("levesek");

    window.addEventListener("load", async (event) => {
        let baseUrl = "http://localhost/Levesek-feladat/backend/index.php?levesek";
        let options = {
            method: "GET",
            headers: {
                "Content-Type": "application/json"
            }
        };
        let response = await fetch(baseUrl, options);
        let data = await response.json();
        let lista = "";
        data.forEach(element => {
            lista += `<div class="card col-4" style="width: 18rem;">
            <img src="res/noimage.svg" class="card-img-top" alt="noimage">
            <div class="card-body">
              <h5 class="card-title">`+ element.megnevezes + `</h5>
              <p class="card-text">Kaloria: `+ element.kaloria + `</p>
              <p class="card-text">Fehérje: `+ element.feherje + `</p>
              <p class="card-text">Zsír: `+ element.zsir + `</p>
              <p class="card-text">Szénhidrát: `+ element.szenhidrat + `</p>
              <p class="card-text">Hamu: `+ element.hamu + `</p>
              <p class="card-text">Rost: `+ element.rost + `</p>
            </div></div>`;
        });
        table.innerHTML = lista;
    })
});
