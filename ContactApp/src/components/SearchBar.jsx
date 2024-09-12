import React, { useCallback } from "react";
import { useDispatch, useSelector } from "react-redux";
import { setSearchTerm } from "../redux/searchSlice";
import "../styles/searchBar.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faSearch } from "@fortawesome/free-solid-svg-icons";
import debounce from "lodash/debounce";

const SearchBar = () => {
  const dispatch = useDispatch();
  const { totalPages, pageSize } = useSelector((state) => state.contacts);
  const count = totalPages * pageSize;

  const handleSearchChange = useCallback(
    debounce((value) => {
      dispatch(setSearchTerm(value));
    }, 300), 
    [dispatch]
  );

  const onInputChange = (e) => {
    handleSearchChange(e.target.value);
  };

  return (
    <div className="search-bar">
      <input
        className="search-bar input"
        type="text"
        placeholder={`Search in ${count}+ Contacts by Name or Phone Number ...`}
        onChange={onInputChange}
      />
      <FontAwesomeIcon icon={faSearch} className="search-icon" />
    </div>
  );
};

export default SearchBar;
