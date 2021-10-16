import React from 'react';
import './App.css';
import { Greet } from './components/Greet';
import { Person } from './components/Person';
import { PersonList } from './components/PersonList';
import { Status } from './components/Status';

function App() {
  const personName = {
    firstName: 'Bruce',
    lastName: 'Wayne'
  }
  const personList = [
    {
      firstName: 'Bruce',
      lastName: 'Wayne'
    },
    {
      firstName: 'Superman',
      lastName: 'Kent'
    },
    {
      firstName: 'Spiderman',
      lastName: 'Parker'
    },
  ]
  
  return (
    <div className="App">
      <Greet name="john" messageCount={5} isLoggedIn={false} />
      <Person name={personName} />
      <PersonList personList={personList}/>
      <Status status="loading" />
    </div>
  );
}

export default App;
