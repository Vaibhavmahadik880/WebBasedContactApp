import React, { useState } from "react";
import { BiSortUp, BiSortDown } from "react-icons/bi";
import "../styles/contactList.css";

const SortDropdown = ({ currentSortBy, currentSortOrder, onSortChange }) => {
  const [isDropdownOpen, setIsDropdownOpen] = useState(false);

  const handleSortChange = (field) => {
    onSortChange(field);
    setIsDropdownOpen(false);
  };

  return (
    <div className="sort-dropdown">
      <button
        className="sort-button"
        onClick={() => setIsDropdownOpen(!isDropdownOpen)}
      >
        Sort by {currentSortBy || "Select"}{" "}
        {currentSortOrder === "asc" ? <BiSortDown /> : <BiSortUp />}
      </button>
      {isDropdownOpen && (
        <div className="dropdown-menu">
          <div className="dropdown-section">
            <button
              className={
                currentSortBy === "name" && currentSortOrder === "asc"
                  ? "selected"
                  : ""
              }
              onClick={() => handleSortChange("name")}
            >
              Name Asc
            </button>
            <button
              className={
                currentSortBy === "name" && currentSortOrder === "desc"
                  ? "selected"
                  : ""
              }
              onClick={() => handleSortChange("name")}
            >
              Name Desc
            </button>
            <button
              className={
                currentSortBy === "number" && currentSortOrder === "asc"
                  ? "selected"
                  : ""
              }
              onClick={() => handleSortChange("number")}
            >
              Mobile No Asc
            </button>
            <button
              className={
                currentSortBy === "number" && currentSortOrder === "desc"
                  ? "selected"
                  : ""
              }
              onClick={() => handleSortChange("number")}
            >
              Mobile No Desc
            </button>
          </div>
        </div>
      )}
    </div>
  );
};

export default SortDropdown;
