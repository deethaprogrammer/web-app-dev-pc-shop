import { Routes, Route } from 'react-router-dom';

import Home from './Pages/Home';
import Create from './Pages/Create';
import Prebuilts from './Pages/Prebuilt';
import Community from './Pages/Community';
import UserProfile from './Pages/UserProfile';
import MyBuilds from './Pages/MyBuilds';
import Login from './Pages/Login';

export default function Router()
{
    return (
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/create" element={<Create />} />
          <Route path="/prebuilts" element={<Prebuilts />} />
          <Route path="/community" element={<Community />} />
          <Route path="/UserProfile" element={<UserProfile />} />
          <Route path="/MyBuilds" element={<MyBuilds />} />
          <Route path="/Login" element={<Login />} />
        </Routes>
    )
}
