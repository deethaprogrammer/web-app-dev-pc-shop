import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Navbar from './components/navbar/Navbar'
import Home from './Pages/Home';
import Create from './Pages/Create';
import Prebuilts from './Pages/Prebuilt';
import Community from './Pages/Community';

export default function App() {
  return (
    <>
      <BrowserRouter>
        <Navbar />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/create" element={<Create />} />
          <Route path="/prebuilts" element={<Prebuilts />} />
          <Route path="/community" element={<Community />} />
        </Routes>
      </BrowserRouter>
    </>
  )
}

