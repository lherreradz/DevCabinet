
import React, { useState, useEffect } from 'react';

export default function Auto(){
    const [stateCar, setStateCar] = useState(false);
    const [contar, setContar] = useState(0)

    useEffect(() => {
        console.log("Total:" + contar)
    }, [contar])

    const encenderApagar = () => {
        setStateCar(!stateCar)
        setContar(contar+1)
    };

    return(
        <div>
            <h3>El coche está {stateCar ? "Encendido" : "Apagado"} </h3>
            <h4>Clicks: {contar}</h4>
            <button onClick={encenderApagar}> Encender / Apagar </button>
        </div>
    )
}
