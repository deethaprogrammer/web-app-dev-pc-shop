import { Routes, Route } from 'react-router-dom';

import Home from '#pages/Home';
import Create from '#pages/Create';
import Prebuilts from '#pages/Prebuilt';
import Community from '#pages/Community';
import UserProfile from '#pages/UserProfile';
import MyBuilds from '#pages/MyBuilds';
import Login from '#pages/Login';

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
