document.addEventListener("DOMContentLoaded", function () {
    var table = document.getElementById("dolgozok");


    window.addEventListener("onload", async function () {
        let baseUrl = "http://localhost/VizsDolgozok/Web/Back/index.php?dolgozok";
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
        data.forEach(element => {
        });
        tabla += `</tbody>
                            </table>`;
        table.innerHTML = tabla;
    })
});