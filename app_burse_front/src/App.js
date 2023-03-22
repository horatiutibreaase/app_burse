//React
import React from 'react';
import { useState } from 'react';
import { createContext } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

//Redux
import { useDispatch, useSelector } from 'react-redux';
import { toggleDarkMode } from './redux/actions';

//CSS
import './App.css';

//Material ui
import { getDesign } from './theme.js';
import { ThemeProvider, createTheme } from '@mui/material/styles';
import { roRO } from '@mui/material/locale';
import CssBaseline from '@mui/material/CssBaseline';
import Grid from '@mui/material/Grid';

//Fonts
import '@fontsource/roboto/300.css';
import '@fontsource/roboto/400.css';
import '@fontsource/roboto/500.css';
import '@fontsource/roboto/700.css';

//Pages
import { Login } from './pages/Login.js';
import { AcordareBursa } from './pages/AcordareBursa';
import { Cuantum } from './pages/Cuantum';
import { Logs } from './pages/Logs';
import { About } from './pages/Despre';
import { Error404 } from './pages/Error404';

//Components
import { Navbar } from './components/Navbar';

//Theme context
export const ColorModeContext = createContext();
export const NavbarTitleContext = createContext();

function App() {
    //Redux
    const dispatch = useDispatch();
    const isAdmin = useSelector((state) => state.isAdmin);
    const loggedIn = useSelector((state) => state.loggedIn);
    const darkMode = useSelector((state) => state.darkMode);

    //Theme
    const [colorMode, setColorMode] = useState(darkMode ? 'dark' : 'light');
    const toggleColorMode = () => setColorMode((prevMode) => {
        dispatch(toggleDarkMode());
        return (prevMode === 'light' ? 'dark' : 'light');
    });
    const theme = createTheme(getDesign(colorMode), roRO);

    //Navbar title
    const [navbarTitle, setNavbarTitle] = useState("Aplicatia de burse");

    return (
        <ColorModeContext.Provider value={{ colorMode, toggleColorMode }}>
            <NavbarTitleContext.Provider value={{ navbarTitle, setNavbarTitle }}>
                <ThemeProvider theme={theme}>
                    <CssBaseline />
                    <Router>
                        <Grid container direction="column" justifyContent="flex-start" alignItems="center" sx={{ height: '100vh' }}>
                            {loggedIn && <Navbar title={navbarTitle} />}
                            <Routes>
                                <Route exact path="/" element={<Login />} />
                                {loggedIn && <Route path="/acordare-bursa" element={<AcordareBursa />} />}
                                {loggedIn && isAdmin && <Route path="/cuantum" element={<Cuantum />} />}
                                {loggedIn && isAdmin && <Route path="/jurnal" element={<Logs />} />}
                                {loggedIn && <Route path="/despre" element={<About />} />}
                                <Route path="*" element={<Error404 />} />
                            </Routes>
                        </Grid>
                    </Router>
                </ThemeProvider>
            </NavbarTitleContext.Provider>
        </ColorModeContext.Provider>
    );
}

export default App;
