import { BrowserRouter } from 'react-router-dom';

import Router from "./Router.tsx";

import Navbar from './components/navbar/Navbar'

export default function App() {
  return (
    <>
      <BrowserRouter>
        <Navbar />
        <Router/>
      </BrowserRouter>
    </>
  )
}

