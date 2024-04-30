document.addEventListener("DOMContentLoaded", function () {
    var futarok = document.getElementById("futarok");
    var pizzak = document.getElementById("pizzak");
    var vevok = document.getElementById("vevok");

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
        tabla = `
                            <table class="table table-striped ">
                                <thead>
                                    <tr>
                                    <th scope="col">ID</th>
                                    <th scope="col">Futár</th>
                                    <th scope="col">Telefonszám</th>                                    
                                    <th scope="col">Pick</th>                                    
                                    </tr>
                                </thead>
                            <tbody>
                            `;
        let row = 1;
        data.forEach(element => {
            tabla += `<tr><th scope='row'>` + element.fazon + `</th>  <td>` + element.fnev + `</td> <td>` + element.ftel + `</td> <td> <a class="btn btn-primary" href="insert.html">Kiválasztás</a></td></tr>`;
            row++;
        });
        tabla += `</tbody>
                            </table>`;
        futarok.innerHTML = tabla;       
    })
    //###############################################
    window.addEventListener("DOMContentLoaded", async function () {
        let baseUrl = "http://localhost/pizzaUgyfelek/Backend/index.php?pizza";        
        let options = {
            method: "GET",
            headers: {
                "Content-Type": "application/json"
            }
        };        
        let response = await fetch(baseUrl, options);
        let data = await response.json();
        let tabla = "";
        tabla = `
                            <table class="table table-striped ">
                                <thead>
                                    <tr>
                                    <th scope="col">ID</th>
                                    <th scope="col">Pizza</th>
                                    <th scope="col">Ár</th>                                    
                                    <th scope="col">Pick</th>                                    
                                    </tr>
                                </thead>
                            <tbody>
                            `;
        let row = 1;
        data.forEach(element => {
            tabla += `<tr><th scope='row'>` + element.pazon + `</th>  <td>` + element.pnev + `</td> <td>` + element.par + ` Ft</td><td> <a class="btn btn-primary" href="http://localhost/pizzaUgyfelek/Backend/index.php?pizza/`+element.pazon+`">Kiválasztás</a></td></tr>`;
            row++;
        });
        tabla += `</tbody>
                            </table>`;
        pizzak.innerHTML = tabla;
    })
        //###############################################
    window.addEventListener("DOMContentLoaded", async function () {
        let baseUrl = "http://localhost/pizzaUgyfelek/Backend/index.php?vevo";        
        let options = {
            method: "GET",
            headers: {
                "Content-Type": "application/json"
            }
        };        
        let response = await fetch(baseUrl, options);
        let data = await response.json();
        let tabla = "";
        tabla = `
                            <table class="table table-striped ">
                                <thead>
                                    <tr>
                                    <th scope="col">ID</th>
                                    <th scope="col">Pizza</th>
                                    <th scope="col">ár</th>                                    
                                    <th scope="col">Pick</th>                                    
                                    </tr>
                                </thead>
                            <tbody>
                            `;
        let row = 1;
        data.forEach(element => {
            tabla += `<tr><th scope='row'>` + element.vazon + `</th>  <td>` + element.vnev + `</td> <td>` + element.vcim + `</td><td> <a class="btn btn-primary" href="http://localhost/pizzaUgyfelek/Backend/index.php?vevo/`+element.vazon+`">Kiválasztás</a></td></tr>`;
            row++;
        });
        tabla += `</tbody>
                            </table>`;
        vevok.innerHTML = tabla;
    })
});
