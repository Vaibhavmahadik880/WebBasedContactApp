import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import App from './App.jsx'
import { store } from './store.js'
import { Provider } from 'react-redux'
import { Slide, ToastContainer,toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

createRoot(document.getElementById('root')).render(
  <Provider store={store}>
  <App />
  <ToastContainer
        
        transition={Slide} // You can use Slide, Zoom, Bounce, etc.
        autoClose={1000}
        ProgressBar
        newestOnTop
        closeOnClick
        rtl={false}
        pauseOnFocusLoss
        draggable
        pauseOnHover
        position='bottom-left'
        
        // Apply custom class
      />
</Provider>,
)
