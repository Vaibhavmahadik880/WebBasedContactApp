import React ,{useState}from "react";
import SearchBar from "./SearchBar";
import "../styles/header.css";
import ContactsDrawer from "./ContactsDrawer";
import { RiContactsBook3Line } from "react-icons/ri";
import { AiOutlineMenuUnfold } from "react-icons/ai";
function Header() {
  const [drawerOpen, setDrawerOpen] = useState(false);
  const toggleDrawer = () => {
    setDrawerOpen(!drawerOpen);
  };
  return (
    <div className="header-container">
      <h1>
        <RiContactsBook3Line className="header-icon" /> Contacts Directory
      </h1>

      <SearchBar />
      <button onClick={toggleDrawer} className="drwaeer-icon"><AiOutlineMenuUnfold />
      </button>
      <ContactsDrawer open={drawerOpen} onClose={toggleDrawer} />
    </div>
  );
}

export default Header;
