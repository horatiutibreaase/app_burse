import { combineReducers } from 'redux';
import {
  SET_USERNAME,
  SET_FACULTY,
  SET_IS_ADMIN,
  LOG_IN,
  LOG_OUT,
  TOGGLE_DARK_MODE,
} from './actions';

const usernameReducer = (state = "", action) => {
  switch (action.type) {
    case SET_USERNAME:
      return action.payload;
    case LOG_OUT:
      return '';
    default:
      return state;
  }
};

const facultyReducer = (state = '', action) => {
  switch (action.type) {
    case SET_FACULTY:
      return action.payload;
    case LOG_OUT:
      return '';
    default:
      return state;
  }
};

const isAdminReducer = (state = false, action) => {
  switch (action.type) {
    case SET_IS_ADMIN:
      return action.payload;
    case LOG_OUT:
      return false;
    default:
      return state;
  }
};

const loggedInReducer = (state = false, action) => {
  switch (action.type) {
    case LOG_IN:
      return true;
    case LOG_OUT:
      return false;
    default:
      return state;
  }
};

const darkModeReducer = (state = false, action) => {
  switch (action.type) {
    case TOGGLE_DARK_MODE:
      return !state;
    default:
      return state;
  }
};

const rootReducer = combineReducers({
  username: usernameReducer,
  faculty: facultyReducer,
  isAdmin: isAdminReducer,
  loggedIn: loggedInReducer,
  darkMode: darkModeReducer,
});

export default rootReducer;