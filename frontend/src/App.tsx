import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Navbar from './components/navbar/Navbar'
import Home from './components/pages/HomePage';
import CreatePage from './components/pages/CreatePage';
import Prebuilts from './components/pages/PrebuiltsPage';
import Community from './components/pages/CommunityPage';

export default function App() {
  return (
    <>
      <BrowserRouter>
        <Navbar />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/create" element={<CreatePage />} />
          <Route path="/prebuilts" element={<Prebuilts />} />
          <Route path="/community" element={<Community />} />
        </Routes>
      </BrowserRouter>
    </>
  )
}

