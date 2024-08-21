import { webApi } from "../../config/api/WebApi";

export const getRandomWord = async () => {
    try{
      const {data} = await webApi.get('/ahorcado');
  
      return data;
    }catch (error){
      console.error(error);
      return error.response;
    }
  }