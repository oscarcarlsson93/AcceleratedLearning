console.log('Moi moi');

let root = document.getElementById("root");
class Text extends React.Component {

    state = { value: "" }

    handleInput = (event) => {
        this.setState({
            value: event.target.value
        })
    }

    handleInputRev = (event) => {
        this.setState({

            updateArray = event.split(""),
            reversearray = updateArray.reverse(),
            joinArray = reversearray.join(""),
            
            joinArray: event.target.value
        })
    }
    render() {
       
        return (
            <div>
                <input onChange={this.handleInput}
                    value={this.state.value}/>
                
                <input onChange={this.handleInput}
                    value={this.state.value} />
                <input onChange={this.handleInput}
                    value={this.state.value} />
                <input onChange={this.handleInputRev}
                    value={this.state.value } />
                <input onChange={this.handleInput}
                    value={this.state.value} />
            </div>
        )
    }
}


ReactDOM.render(<Text />, root);