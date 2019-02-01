console.log("Moi Mukulat!");

async function clickSeed() {

    let response = await fetch(`api/news/seed`, { method: "post" });
    //console.log(response.status);
    if (response.status === 204) {
        console.log("Seed done!");
    }
    else {
        console.error("Unexpected error", response);
    }
}

async function showAllNews() {

    let response = await fetch(`api/news/`, { method: "get" });
    //console.log(response.status);
    document.getElementById("newsList").innerText = "";

    if (response.status === 200) {

        //let array = await response.json();

        //for (let i = 0; i < array.length; i++) {
        //    let obj = array[i];
        //    let para = document.createElement("p");
        //    let t = document.createTextNode("ID:" + obj.id + " " + obj.header);
        //    para.appendChild(t);
        //    document.getElementById("newsList").appendChild(para);

        //}

        let allNews = await response.json();
        console.log("allNews", allNews);

        let html = `<table>
            <tr>
            <th>Id</th>
            <th>Date</th>
            <th>Intro</th>
            <th>Body</th>
            <th>Category</th>

  </tr > `;

        for (let n of allNews) {
            html += ` 

             <tr>
    <td>${n.id}</td>
    <td>${n.header}</td>
    <td>${n.intro}</td>
    <td>${n.body}</td>
    <td>${n.category}</td>
    <td>${n.category}</td>
    <td> <button onclick="clickShowUpdateArea(${n.id})">Update</button> </td>


  </tr>


            `;
        }
        html + "</table >";

        document.getElementById("newsList").innerHTML = html;
        //<p>Id: ${n.id} Rubrik: ${n.header}</p>

        //for (const x of array) {
        //    console.log(newsList = x.header);
        //    console.log(newsList = x.intro);

        //    newsList = x.header;

        //}
        //newsList = array[0].intro;

        //console.log(newsList[0].header); 
        //console.log(newsList);
    }
    else {
        console.error("Unexpected error", response);
    }

}

//async function clickStatArea() {

//    let response = await fetch(`api/news/`, { method: "get" });
//    let array = await response.json();

//    console.log(array.length);
//    let nrOfNews = document.getElementById("nrOfNews");
//    nrOfNews.innerText = array.length;


//}
async function clickStatArea() {

    let response = await fetch(`api/news/count`, { method: "get" });
    let count = await response.json();
    document.getElementById("nrOfNews").innerText = count;

}

async function clickAddNews() {
    let addHeader = document.getElementById("addAreaHeader").value;
    //let addCategory = document.getElementById("addAreaCategory").value;
    let addIntro = document.getElementById("addAreaIntro").value;
    let addBody = document.getElementById("addAreaBody").value;

    let response = await fetch("api/News", {
        method: "POST",
        body: JSON.stringify(
            {
                header: addHeader,
                intro: addIntro,
                body: addBody,
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });
    console.log(response.status);

    document.getElementById("addArea").style.display = "none";
    showAllNews();
}

async function clickRecreate() {

    let response = await fetch(`api/news/recreate`, { method: "POST" });
    console.log(response.status);

}


document.getElementById("addArea").style.display = "none";
async function clickShowAddNews() {
    document.getElementById("addArea").style.display = "block";

}


document.getElementById("updateArea").style.display = "none";
async function clickShowUpdateArea(id) {

    document.getElementById("updateArea").style.display = "block";


    document.getElementById("updateAreaHeader").value = id.header;

    let response = await fetch(`api/news/${id}`, {
        method: "GET",
        body: JSON.stringify(
            {
                header: addHeader,
                intro: addIntro,
                body: addBody,
       
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });
    console.log(response);
    } 
        




async function clickUpdateNews(id) {

    let updateId = document.getElementById("updateAreaId").value;
    let updateHeader = document.getElementById("updateAreaHeader").value;
    let updateIntro = document.getElementById("updateAreaIntro").value;
    let updateBody = document.getElementById("updateAreaBody").value;

    let response = await fetch("api/news/", {
        method: "PUT",
        body: JSON.stringify(
            {
                id: id,
                header: updateHeader,
                intro: updateIntro,
                body: updateBody,
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });
    console.log(response.status);


}

