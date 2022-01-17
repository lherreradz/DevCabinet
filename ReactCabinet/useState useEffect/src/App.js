import logo from './logo.svg';
import './App.css';
import Autor from './components/Autor';
import Saludar, {SaludarUser} from './components/Saludar';
import Auto from './components/Auto';

function App() {

  const name = "Carlos Herrera"
  const age = "26"

  const user = {
   name: "Carlos Herrera",
   age: 280
  }

  return (
    <div className="App">
      <Autor/>
      <Saludar name={name} edad={age}/>
      <SaludarUser userInfo={user} />
      <Auto/>
    </div>
  );
}

export default App;
