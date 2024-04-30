document.addEventListener("DOMContentLoaded", function () {
    var table = document.getElementById("futarok");

    window.addEventListener("DOMContentLoaded", async function () {
        let baseUrl = "http://localhost/PizzaVizsgaBackend/index.php?futar";        
        let options = {
            method: "GET",
            headers: {
                "Content-Type": "application/json"
            }
        };        
        let response = await fetch(baseUrl, options);
        let data = await response.json();
        let tabla = "";                    
        data.forEach(element => {
            tabla += `<div class="card col-sm-12 col-md-3 col-lg-3>
            <div class="card-body">
              <h5 class="card-title">Név: `+element.fnev+`</h5>
              <p class="card-text">ID: `+element.fazon+`</p>
              <p class="card-text">Tel.: `+element.ftel+`</p>
            </div>
            </div>`;
        });
        table.innerHTML = tabla;       
    })
});
