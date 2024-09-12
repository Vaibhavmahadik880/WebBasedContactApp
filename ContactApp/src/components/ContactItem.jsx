import React, { useEffect } from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import "../styles/contactList.css";
import { faEdit, faTrash, faEnvelope } from "@fortawesome/free-solid-svg-icons";

const ContactItem = ({ contact, onEdit, onDelete }) => (
  <div className="contact-item">
    <img
      src={contact.photo}
      alt={`${contact.name}`}
      style={{ width: "100px", height: "100px" }} />
    <div className="contact-item-details">
      <h1> {contact.name}</h1>
      <p>
        <strong>Mob No:</strong> {contact.mobileNumber}
      </p>
      <p>
        <strong>Office :</strong> {contact.secondaryMobileNumber}
      </p>
      <p>
        <strong>
          <FontAwesomeIcon icon={faEnvelope} />
        </strong>{" "}
        {contact.email} <a href={`mailto:${contact.email}`}></a>
      </p>
    </div>
    <div className="contact-item-actions">
      <button className="edit-btn" title="Edit Contact" onClick={onEdit}>
        <FontAwesomeIcon icon={faEdit} />{" "}
      </button>
      <button
        className="delete-btn"
        title="Delete Contact"
        onClick={onDelete}
      >
        <FontAwesomeIcon icon={faTrash} />{" "}
      </button>
    </div>
  </div>
);

export default ContactItem;
