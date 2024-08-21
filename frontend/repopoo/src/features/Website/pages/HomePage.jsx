import { useEffect, useState } from "react";
import { useWorld } from "../hooks";
import { Await } from "react-router-dom";

export const HomePage = () => {
  const { word, isLoading, loadWord } = useWorld();
  const [fetching, setFetching] = useState(true);
    const [palabra , setPalabra] =useState('')
  const [largo, setLargo] = useState(0);

  useEffect(() => {
    if (fetching) {
    loadWord();
    console.log(word); 
      setFetching(false);
    }
  }, [fetching]);

  useEffect( () => {
    if(!fetching)
    setPalabra( (index) => word?.data?.libros.map((palabra) => {
            if(index == word.data.random ){
                palabra
            }
        }) )
  } , [fetching])
  return (
    <div className="bg-gray-200">
      <div className=" max-w-40 mt-96 h-svh mx-auto  justify-center items-center">
        <h1>

            {palabra ? (
                <p>{palabra}</p>
            ): (
                <p>Palabra no encontrada</p>
            )}

        </h1>
      </div>
    </div>
  );
};
