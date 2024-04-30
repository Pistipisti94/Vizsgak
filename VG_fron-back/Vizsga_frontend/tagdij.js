document.addEventListener("DOMContentLoaded", function () {
    const createButton = document.getElementById("create");
    const readButton = document.getElementById("read");
    const updateButton = document.getElementById("update");
    const deleteButton = document.getElementById("delete");
    var table = document.getElementById("ugyfellista");
    const formData = new FormData(document.getElementById("myForm"));
    
    createButton.addEventListener("click", async function () {
        let baseUrl = "http://localhost/Vizsga_backend/index.php?ugyfel";
        let options = {
            method: "POST",
            body: formData
        };
        response = await fetch(baseUrl, options);
    })
    readButton.addEventListener("click", async function () {
        let baseUrl = "http://localhost/Vizsga_backend/index.php?ugyfel";        
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
                                    <th scope="col">Nev</th>
                                    <th scope="col">Született</th>
                                    <th scope="col">Iranyitoszam</th>
                                    <th scope="col">Orszag</th>
                                    <th scope="col">#</th>
                                    </tr>
                                </thead>
                            <tbody>
                            `;
        let row = 1;
        data.forEach(element => {
            tabla += `<tr><th scope='row'>` + element.azon + `</th><td id="nev`+element.azon+`">` + element.nev + `</td><td id="szulev`+element.azon+`">` + element.szulev + `</td><td id="irszam`+element.azon+`">` + element.irszam + `</td><td id="orsz`+element.azon+`">` + element.orsz + `</td><td><Button class="btn btn-primary pick" id="` + element.azon + `">Pick</Button></td></tr>`;
            row++;
        });
        tabla += `</tbody>
                            </table>`;
        table.innerHTML = tabla;
        const pickButton = document.getElementsByClassName("pick");
        for (let i = 0; i < pickButton.length; i++) {
            pickButton[i].addEventListener("click", function () {
                var azon = document.getElementById("azon");
                var nev = document.getElementById("nev");
                var szulev = document.getElementById("szulev");
                var irszam = document.getElementById("irszam");
                var orsz = document.getElementById("orsz");
                azon.value = this.id;              
                nev.value = document.getElementById("nev"+this.id).innerHTML;
                szulev.value = document.getElementById("szulev"+this.id).innerHTML;
                irszam.value = document.getElementById("irszam"+this.id).innerHTML;
                orsz.value = document.getElementById("orsz"+this.id).innerHTML;                
            })
        }
    })
    updateButton.addEventListener("click", function () {

    });
    deleteButton.addEventListener("click", async function () {
        let baseUrl = "http://localhost/Vizsga_backend/index.php?ugyfel";
        let dataJSON = {
            "azon": document.getElementById("azon").value,
        };               
        let options = {
            method: "DELETE",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(dataJSON)
        }
            response = await fetch(baseUrl, options);
            console.log(response);
    });
});

