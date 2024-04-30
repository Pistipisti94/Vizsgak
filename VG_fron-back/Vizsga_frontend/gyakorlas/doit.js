document.addEventListener("DOMContentLoaded", function () {
    const createButton = document.getElementById("create");
    var table = document.getElementById("azons");
    const formData = new FormData(document.getElementById("myForm"));
    createButton.addEventListener("click", async function () {
        const osszeg = document.getElementById("osszeg").value;
        let azons = document.getElementById("azons").value;
        let baseUrl = "http://localhost/Vizsga_Backend/index.php?befizetes";
        let options = {
            method: "POST",
            body: formData
        };
        response = await fetch(baseUrl, options);        
    })
    window.addEventListener("load", async (event) => {
        let baseUrl = "http://localhost/Vizsga_Backend/index.php?ugyfelek";
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
            lista += `<option value="`+element.azon+`">`+element.azon+`</option>`;            
        });                
        table.innerHTML = lista;                
            })
        });
