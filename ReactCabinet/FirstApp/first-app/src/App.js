import logo from './assets/images/logo.svg';
import './assets/css/App.css';

import FirstComponent from './components/FirstComponent';
import SecondComponent from './components/SecondComponent'

function UpperCase(txt){
  return txt.toUpperCase();
}

function GetFacts(){
  var facts = (
  <div>
    <h3>Facts: </h3>
    <ul>
      <li>It's a sunny day</li>
      <li>I'm hungry</li>
      <li>I love animals</li>
    </ul>
  </div>
  )

  return facts;
}

function App() {
  var name = "Alejo";
  var message = "Hi, I'm " + name + ", this is my first app using React";
  var hello = "Hello world!";

  return (
    <div className="App">
      <header className="App-header">
        <h1><code>{UpperCase(hello)}</code></h1>
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          {message}
        </p>
        {GetFacts()}
        {
          alert("Welcome!")
        }
      </header>
      <section className='components'>
        <FirstComponent/>
        <FirstComponent/>
        <SecondComponent/>
      </section>
    </div>

  );
}

export default App;
