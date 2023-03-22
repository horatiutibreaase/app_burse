export const SET_USERNAME = 'SET_USERNAME';
export const SET_FACULTY = 'SET_FACULTY';
export const SET_IS_ADMIN = 'SET_IS_ADMIN';
export const LOG_IN = 'LOG_IN';
export const LOG_OUT = 'LOG_OUT';
export const TOGGLE_DARK_MODE = 'TOGGLE_DARK_MODE';

export const setUsername = (username) => ({
  type: SET_USERNAME,
  payload: username,
});

export const setFaculty = (faculty) => ({
  type: SET_FACULTY,
  payload: faculty,
});

export const setIsAdmin = (isAdmin) => ({
  type: SET_IS_ADMIN,
  payload: isAdmin,
});

export const logIn = () => ({
  type: LOG_IN,
});

export const logOut = () => ({
  type: LOG_OUT,
});

export const toggleDarkMode = () => ({
  type: TOGGLE_DARK_MODE,
});