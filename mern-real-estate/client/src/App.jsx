import { BrowserRouter, Routes, Route } from "react-router-dom";
import SignIn from "./pages/SignIn";
import SignOut from "./pages/SignOut";
import Profile from "./pages/Profile";
import About from "./pages/About";
import Home from "./pages/Home";

export default function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/sign-in" element={<SignIn />} />
        <Route path="/sign-out" element={<SignOut />} />
        <Route path="/Profile" element={<Profile />} />
        <Route path="/About" element={<About />} />
      </Routes>
    </BrowserRouter>
  );
}
