import React from 'react';
import './App.css';
import { Children } from './components/Children';
import { Greet } from './components/Greet';
import { Heading } from './components/Heading';
import { Status } from './components/Status';
import { Profile } from './components/Profile';
import { people } from './data/data';

function App() {
  
  return (
    <div className="App">
      <Status status="loading" />
      <Heading>Placeholder</Heading>
      <Children>
        <Greet name="john" isLoggedIn={false} />
      </Children>
      
      {people.map(person => (
        <Profile
          key={person.id}
          name={person.name}
          imageId={person.imageId}
        />
      ))}

    </div>
  );
}

export default App;
