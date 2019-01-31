console.log("MAil");

let root = document.getElementById("root");
class Textruta extends React.Component {


    state = { text: '' }
    //value = { this.state.Efternamn }
    //value = { this.state.Email }

    validateInput = (event) => {
        let x = event.target.value
        //console.log(x);
        //console.log(this.props.validera)
        let regex = new RegExp(this.props.validera, this.props.ignoreracasing? 'i':'');
        
        
        let res = regex.test(x);
       

        if (res) {
            this.setState( { backgroundColor: "green" } )
        }
        else {
            this.setState( {backgroundColor:"red"})
        }

    }

    render() {
        return (
            <div className="textwrap">
                <label>{this.props.lejbel}</label>
                <input onChange={this.validateInput} style={{backgroundColor: this.state.backgroundColor}} 
                   />
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


ReactDOM.render(<App />, root);