import React from 'react';
import './App.css';
import { Children } from './components/Children';
import { Greet } from './components/Greet';
import { Heading } from './components/Heading';
import { Status } from './components/Status';

function App() {
  
  return (
    <div className="App">
      <Status status="loading" />
      <Heading>Placeholder</Heading>
      <Children>
        <Greet name="john" isLoggedIn={false} />
      </Children>
    </div>
  );
}

export default App;
