console.log("MAil");

let root = document.getElementById("root");
class Text extends React.Component {

    render() {
        return (
            <div>
                <div >
                    <label>Förnamn</label>
                    <input />
                </div>
                <div>

                    <label>Efternamn</label>
                    <input />
                </div>
                <div>

                    <label>Email</label>
                    <input />
                </div>
            </div>

        )
    }
}

class App extends React.Component {

    render() {
        return (
            <div>
                <Textruta lejbel="Förnamn" />
                <Textruta lejbel="Efternamn" validera="son$" />
                <Textruta lejbel="Email" validera="\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b" ignoreracasing="true" />
            </div>
        )
    }
}

ReactDOM.render(<Text />, root);









