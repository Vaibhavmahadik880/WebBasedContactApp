import React, { useState, useEffect } from "react";
import { useDispatch, useSelector } from "react-redux";
import { handleSubmitForm,getRandomNumber } from "./ContactFormHandler";// Import handlers
import "../styles/ContactForm.css";

const ContactForm = ({ initialContact, onClose }) => {
  const dispatch = useDispatch();
  const { data: contacts, pageNumber,pageSize,totalPages,sortBy,sortOrder } = useSelector((state) => state.contacts); // Fetch contacts from Redux
  const [contact, setContact] = useState({
    id: null,
    name: "",
    mobileNumber: "",
    secondaryMobileNumber: "",
    email: "",
    photo: "",
  });
  const [mobileError, setMobileError] = useState("");
  const [emailError, setEmailError] = useState("");
  const [nameError, setNameError] = useState("");

  useEffect(() => {
    if (initialContact) {
      setContact(initialContact);
    } else {
      setContact({
        ...contact,
        photo: `https://randomuser.me/api/portraits/men/${getRandomNumber()}.jpg`,
      });
    }
  }, [initialContact]);

  const handleChange = (e) => {
    const { name, value, type, files } = e.target;

    if (type === "file") {
      const file = files[0];
      if (file) {
        const reader = new FileReader();
        reader.onloadend = () => {
          setContact((prevData) => ({
            ...prevData,
            photo: reader.result,
          }));
        };
        reader.readAsDataURL(file);
      }
    } else {
      setContact({ ...contact, [name]: value });
    }

    // Clear errors on change
    if (name === "mobileNumber") {
      setMobileError("");
    }
    if (name === "email") {
      setEmailError("");
    }
    if (name === "name") {
      setNameError("");
    }
  };

  return (
    <div className="contact-form-overlay">
      <div className="contact-form">
        <h2>{contact.id ? "Edit Contact" : "Add Contact"}</h2>
        <form
          onSubmit={(e) =>
            handleSubmitForm(
              e,
              contact,
              contacts,
              setMobileError,
              setEmailError,
              setNameError,
              dispatch,
              pageNumber,
              pageSize,
              sortOrder,
              sortBy,
              onClose
            )
          }
        >
          <img src={contact.photo} alt="Contact Avatar" />
          <label>
            <strong>Name:</strong>
            <input
              type="text"
              name="name"
              value={contact.name}
              onChange={handleChange}
            />
          </label>
          {nameError && <div className="error-message">{nameError}</div>}
          <label>
            <strong>Mobile Number:</strong>
            <input
              type="text"
              name="mobileNumber"
              value={contact.mobileNumber}
              onChange={handleChange}
              maxLength="10"
            />
          </label>
          {mobileError && <div className="error-message">{mobileError}</div>}
          <label>
            <strong>Secondary Mobile Number:</strong>
            <input
              type="text"
              name="secondaryMobileNumber"
              value={contact.secondaryMobileNumber}
              onChange={handleChange}
            />
          </label>
          <label>
            <strong>Email:</strong>
            <input
              type="email"
              name="email"
              value={contact.email}
              onChange={handleChange}
            />
          </label>
          {emailError && <div className="error-message">{emailError}</div>}
          <label>
            <strong>Upload Profile Photo</strong>
            <input
              type="file"
              name="photo"
              className="image-input"
              onChange={handleChange}
            />
          </label>

          <div className="contact-form-button-container">
            <button type="submit">
              {contact.id ? "Save Changes" : "Save"} 
            </button>
            <button type="button" className="close-button" onClick={onClose}>
              Close
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};

export default ContactForm;
