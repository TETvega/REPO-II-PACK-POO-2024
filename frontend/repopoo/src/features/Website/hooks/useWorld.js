import { useState } from "react";
import { getRandomWord } from "../../../shared/actions/word";

export const useWorld = () => {
  const [word, setWord] = useState({});
  const [isLoading, setIsLoading] = useState(false);


  const loadWord = async () => {
    setIsLoading(true);
    const result = await getRandomWord();
    setWord(result);
    setIsLoading(false);
  };

  return {
    // Properties
    word,
    isLoading,
        //Methods
    loadWord,
  };
};