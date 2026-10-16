import { Routes, Route } from 'react-router-dom';

import Home from './Pages/Home';
import Create from './Pages/Create';
import Prebuilts from './Pages/Prebuilt';
import Community from './Pages/Community';

export default function Router()
{
    return (
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/create" element={<Create />} />
          <Route path="/prebuilts" element={<Prebuilts />} />
          <Route path="/community" element={<Community />} />
        </Routes>
    )
}
