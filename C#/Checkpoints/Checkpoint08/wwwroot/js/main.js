
async function recreateDatabase() {
    document.getElementById("recreateButton").style.display = "none";
    document.body.style.backgroundColor = "blue";
    let response = await fetch("/observation/recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "green";
        
    } else {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "red";
    }
}

async function addBird() {
    let addName = document.getElementById("addSpecie").value;
    let addDate = document.getElementById("addDate").value;
    let addLocation = document.getElementById("addLocation").value;
    let addNotes = document.getElementById("addNotes").value;

    console.log(addName);
    let response = await fetch("observation/", {
        method: "POST",
        body: JSON.stringify(
            {
                Name: addName,
                Date: addDate,
                Location: addLocation,
                Notes: addNotes,
            }),
        
        headers: {
            "Content-Type": "application/json"
        }
    });
    console.log(response.status);
    showAllObservs();
}

async function showAllObservs() {
    let response = await fetch("observation", { method: "GET" });
    console.log(response.status);
    document.getElementById("showAll").innerText = "";

    if (response.status === 200) {
        console.log("SHOW" + response.status);  
        let array = await response.json();
       
        let html = `
    <h3>All observations</h3>

            <table>
            <thead>
            <tr>
            <th>Id</th>
            <th>Date</th>
            <th>Specie</th>
            <th>Location</th>
            <th>Notes</th>
            
  </tr >
</thead>
`;
        for (let n of array) {
            html += ` 

             <tr>
    <td>${n.id}</td>
    <td>${n.date}</td>
    <td>${n.name}</td>
    <td>${n.location}</td>
    <td>${n.notes}</td>

  </tr>
`;
        }
        html + "</table >";
        document.getElementById("showAll").innerHTML = html;

        showAllUnique();
    }
    else {
        console.error("Unexpected error", response);
    }
}

async function showAllUnique() {
    let response = await fetch("observation/unique", { method: "GET" });
    console.log(response.status);
    document.getElementById("showSpecies").innerText = "";
    let array = await response.json();

    let html2 = `<h3>Species</h3></br>`;
    for (let n of array) {
        html2 += `
        ${n} </br>
            `;
    }
    document.getElementById("showSpecies").innerHTML = html2;
}
