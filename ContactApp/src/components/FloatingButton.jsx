import React from "react";
import "../styles/FloatingButton.css";

const FloatingButton = ({ onClick }) => {
  return (
    <button
      className="floating-button"
      title="Add new Contact"
      onClick={onClick}
    >
      +
    </button>
  );
};

export default FloatingButton;
